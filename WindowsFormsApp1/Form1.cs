using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace Bauteilkatalogsortierer
{
    public partial class FormMaster : Form
    {
        private static char TRENNER = ';';
        List<Schichtenpaket> database = new List<Schichtenpaket>();
        List<Schichtenpaket> erstellteBauteile = new List<Schichtenpaket>();
        List<CheckedListBox> lists = new List<CheckedListBox>();
        List<Label> labels = new List<Label>();
        ToolTip toolTip1 = new ToolTip();
        private int tIndex = -1;

        public FormMaster()
        {
            InitializeComponent();
            // Alle checkedListBoxen in eine Liste
            lists.Add(checkedListBox1);
            lists.Add(checkedListBox2);
            lists.Add(checkedListBox3);
            lists.Add(checkedListBox4);
            lists.Add(checkedListBox5);
            lists.Add(checkedListBox6);
            labels.Add(labelBox1);
            labels.Add(labelBox2);
            labels.Add(labelBox3);
            labels.Add(labelBox4);
            labels.Add(labelBox5);
            labels.Add(labelBox6);
            lists.ForEach(l => l.DisplayMember = "schichtpaket");
            lists.ForEach(l => l.MouseHover += new EventHandler(checkedListBox_MouseHover));
            lists.ForEach(l => l.MouseMove += new MouseEventHandler(checkedListBox_MouseMove));
        }

        // Datenbank laden
        private void button3_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.Reflection.Assembly.GetEntryAssembly().Location; ;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                labelError.Text = "";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    var reader = new StreamReader(File.OpenRead(filePath), Encoding.UTF8);
                    Schichtenpaket data = null;
                    int i = 0;
                    database.Clear();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(TRENNER);
                        i++;
                        // Ignoriere ungültige Zeilen
                        int startColumn = 2;

                        if (values.Length > 5 && values[startColumn].Trim().Length > 0 && values[startColumn + 1].Trim().Length > 0 && values[startColumn + 2].Trim().Length > 0 && values[startColumn + 3].Trim().Length > 0)
                        {
                            if (data == null || data.bauteilTyp != values[startColumn] || data.schichtpaketTyp != values[startColumn + 1] || data.schichtpaket != values[startColumn + 2])
                            {
                                data = getData(values[startColumn], values[startColumn + 1], values[startColumn + 2]);
                                database.Add(data);
                            }
                            int bulkLineImportAt = startColumn + 3;
                            String[] result = new String[values.Length - bulkLineImportAt];
                            Array.Copy(values, bulkLineImportAt, result, 0, values.Length - bulkLineImportAt);
                            data.schichten.Add(result);
                        }
                        else
                        {
                            Console.WriteLine("failed(" + i + "): " + line);
                            if(i != 1 && line.Substring(line.IndexOf(TRENNER) + 1).Replace(TRENNER.ToString(),"").Length > 0)
                            {
                                labelError.Text = "Konnte Zeile " + i + " nicht einlesen! - " + line;
                                labelError.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
            labelPath.Text = filePath;
            comboBox1.Items.Clear();
            cleanAllListBoxes();
            foreach (String line in database.Select(x => x.bauteilTyp).Distinct().ToList())
            {
                comboBox1.Items.Add(line);
            }
        }
        void checkedListBox_MouseMove(object sender, MouseEventArgs e)
        {   
            CheckedListBox selected = (CheckedListBox)sender;
            showToolTip(selected);
        }

        void checkedListBox_MouseHover(object sender, EventArgs e)
        {
            CheckedListBox selected = (CheckedListBox)sender;
            showToolTip(selected);
        }

        void showToolTip(CheckedListBox box)
        {
            Point pos = box.PointToClient(MousePosition);
            int index = box.IndexFromPoint(pos) ;
            if (tIndex != index)
            {
                tIndex = index;
                if(index != -1)
                {
                    string content = getSchichtInfo((Schichtenpaket)box.Items[index]);
                    toolTip1.Show(content, this, this.Size.Width, this.Size.Height - (content.Split('\n').Length * 15), 5000);
                }
            } 
        }

        // Erstelle Schichtenpaket
        private Schichtenpaket getData(String id1, String id2, String id3)
        {
            var data = new Schichtenpaket
            {
                bauteilTyp = id1,
                schichtpaketTyp = id2,
                schichtpaket = id3,
                eigenerBauteilName = "",
                schichten = new List<string[]>()
            };
            return data;
        }

        // Kopiere Schichtenpaket
        private Schichtenpaket getData(Schichtenpaket copyThis)
        {
            var data = new Schichtenpaket
            {
                bauteilTyp = copyThis.bauteilTyp,
                schichtpaketTyp = copyThis.schichtpaketTyp,
                schichtpaket = copyThis.schichtpaket,
                eigenerBauteilName = copyThis.eigenerBauteilName,
                schichten = copyThis.schichten
            };
            return data;
        }

        // einzelnen Komponenten ausleeren
        private void cleanAllListBoxes()
        {
            lists.ForEach(l => l.ClearSelected());
            lists.ForEach(l => l.Items.Clear());
            lists.ForEach(l => l.Visible = false);
            labels.ForEach(l => l.Visible = false);
        }

        // Befüllen der einzelnen Komponenten nach Bauteiltyp Auswahl über Combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanAllListBoxes();
            textBoxBauteilName.Text = comboBox1.Text;
            List<String> data = database.FindAll(x => x.bauteilTyp == comboBox1.Text).Select(x => x.schichtpaketTyp).Distinct().ToList();
            int i = 0;
            foreach (CheckedListBox box in lists)
            {
                if (data.Count > 0)
                {
                    String str = data.First();
                    data.Remove(str);
                    database.FindAll(x => x.bauteilTyp == comboBox1.Text && x.schichtpaketTyp == str).ForEach(l => box.Items.Add(l));
                    box.Visible = true;
                    labels[i].Visible = true;
                    labels[i].Text = str;
                    i++;
                }
            }
        }

        // CSV Datei schreiben
        private void button1_Click(object sender, EventArgs e)
        {
            // Hier wird die CSV Datei geschrieben
            var csv = new StringBuilder();
            // Schreibe Auswahl in Variable
            int i = 1;
            string actualIdent = "";
            foreach (Schichtenpaket bauteilPaket in erstellteBauteile)
            {
                if (checkBoxHeader.Checked == true)
                {
                    // Kopfzeilen schreiben
                    if (actualIdent != bauteilPaket.eigenerBauteilName)
                    {
                        csv.AppendLine(i++.ToString()
                            + TRENNER + bauteilPaket.eigenerBauteilName);
                        actualIdent = bauteilPaket.eigenerBauteilName;
                    }
                    csv.AppendLine(i++.ToString() + TRENNER + bauteilPaket.schichtpaketTyp);
                }
                // Inhalt der CSV schreiben
                foreach (String[] schicht in bauteilPaket.schichten)
                {
                    csv.AppendLine(string.Format("{0}" + TRENNER + "{1}" + TRENNER + "{2}" + TRENNER + "{3}" + TRENNER + "{4}" + TRENNER + "{5}",
                        i++.ToString(), bauteilPaket.eigenerBauteilName, bauteilPaket.bauteilTyp, bauteilPaket.schichtpaketTyp, bauteilPaket.schichtpaket, String.Join(TRENNER.ToString(), schicht)));
                }

            }
            // Datei schreiben
            if (csv.Length > 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.InitialDirectory = System.Reflection.Assembly.GetEntryAssembly().Location;
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string name = saveFileDialog1.FileName;
                    File.WriteAllText(name, csv.ToString(), Encoding.UTF8);
                }
                cleanAllListBoxes();
            }
        }

        // Speichere Bauteil zu Bauteiliste
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listBoxSaved.Items.Contains(textBoxBauteilName.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Eintrag '" + textBoxBauteilName.Text + "' existiert bereits, soll er überspeichert werden?", "Speichern", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    erstellteBauteile.RemoveAll(l => l.eigenerBauteilName == textBoxBauteilName.Text);
                    saveToBauteile().ForEach(b => erstellteBauteile.Add(b));
                    lists.ForEach(l => l.ClearSelected());
                }
            }
            else
            {
                listBoxSaved.Items.Add(textBoxBauteilName.Text);
                saveToBauteile().ForEach(b => erstellteBauteile.Add(b));
                lists.ForEach(l => l.ClearSelected());
            }
            if (erstellteBauteile.Find(l => l.eigenerBauteilName == textBoxBauteilName.Text) == null)
            {
                listBoxSaved.Items.Remove(textBoxBauteilName.Text);
            }
        }

        // Speichere Bauteile
        private List<Schichtenpaket> saveToBauteile()
        {
            List<Schichtenpaket> auswahl = new List<Schichtenpaket>();
            foreach (CheckedListBox box in lists)
            {
                if (box.Visible == true)
                {
                    foreach (Schichtenpaket selectedLine in box.CheckedItems)
                    {
                        Schichtenpaket copyLine = getData(selectedLine);
                        copyLine.eigenerBauteilName = textBoxBauteilName.Text;
                        auswahl.Add(copyLine);
                    }
                }
            }
            return auswahl;
        }

        // Rückauswahl aus Bauteileliste
        private void listBoxSaved_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSaved.SelectedIndex >= 0)
            {
                textBoxBauteilName.Text = listBoxSaved.Items[listBoxSaved.SelectedIndex].ToString();
                List<Schichtenpaket> selectedFromBauteile = erstellteBauteile.FindAll(l => l.eigenerBauteilName == textBoxBauteilName.Text);
                selectBauteileInComponent(selectedFromBauteile);
            }
        }

        // Wählt Bauteile wieder in Componenten aus
        private void selectBauteileInComponent(List<Schichtenpaket> selectedFromBauteile)
        {
            if (selectedFromBauteile.Count > 0)
            {
                comboBox1.SelectedItem = comboBox1.Items[comboBox1.FindString(selectedFromBauteile[0].bauteilTyp)];
                comboBox1_SelectedIndexChanged(null, EventArgs.Empty);
                foreach (CheckedListBox box in lists)
                {
                    if (box.Visible == true)
                    {
                        List<int> items = new List<int>();
                        foreach (Schichtenpaket selectedLine in box.Items)
                        {
                            if (selectedFromBauteile.Find(i => i.schichtpaketTyp == selectedLine.schichtpaketTyp && i.schichtpaket == selectedLine.schichtpaket) != null)
                            {
                                items.Add(box.Items.IndexOf(selectedLine));
                            }
                        }
                        items.ForEach(item => box.SetItemChecked(item, true));
                    }
                }
            }
        }

        private void buttonSaveTemplate_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = System.Reflection.Assembly.GetEntryAssembly().Location;
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var serializer = new JavaScriptSerializer();
                var serializedResult = serializer.Serialize(saveToBauteile());
                string name = saveFileDialog1.FileName;
                File.WriteAllText(name, serializedResult, Encoding.UTF8);
            }
        }

        private void buttonLoadTemplate_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = System.Reflection.Assembly.GetEntryAssembly().Location; ;
                openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                labelError.Text = "";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    var serializer = new JavaScriptSerializer();
                    var deserializedResult = serializer.Deserialize<List<Schichtenpaket>>(content);
                    selectBauteileInComponent(deserializedResult);
                }
            }
        }

        private string getSchichtInfo(Schichtenpaket paket)
        {
            String message = "";
            message += paket.schichtpaket + ":\r\n";
            foreach (string[] line in paket.schichten)
            {
                message += "\t" + line[0] + "\r\n";
            }
            return message;
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            String message = "";
            foreach (CheckedListBox box in lists)
            {
                foreach (Schichtenpaket selectedLine in box.CheckedItems)
                {
                    message += getSchichtInfo(selectedLine);
                }
            }
            if(message == "")
            {
                message = "Keine Auswahl getroffen!";
            }
            const string caption = "Info";
            var result = MessageBox.Show(message, caption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
        }
    }
}
