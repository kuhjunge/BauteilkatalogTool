namespace Bauteilkatalogsortierer
{
    partial class FormMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            this.button1 = new System.Windows.Forms.Button();
            this.labelTyp = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonSaveTemplate = new System.Windows.Forms.Button();
            this.buttonLoadTemplate = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxBauteilName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelBox5 = new System.Windows.Forms.Label();
            this.labelBox6 = new System.Windows.Forms.Label();
            this.labelBox4 = new System.Windows.Forms.Label();
            this.labelBox3 = new System.Windows.Forms.Label();
            this.labelBox2 = new System.Windows.Forms.Label();
            this.labelBox1 = new System.Windows.Forms.Label();
            this.checkedListBox6 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.labelError = new System.Windows.Forms.Label();
            this.listBoxSaved = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.checkBoxHeader = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 829);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Erstelle Datei";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTyp
            // 
            this.labelTyp.AutoSize = true;
            this.labelTyp.Location = new System.Drawing.Point(6, 43);
            this.labelTyp.Name = "labelTyp";
            this.labelTyp.Size = new System.Drawing.Size(103, 25);
            this.labelTyp.TabIndex = 3;
            this.labelTyp.Text = "Bauteiltyp:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(760, 32);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 67);
            this.button3.TabIndex = 16;
            this.button3.Text = "Datenbank laden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(258, 33);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 25);
            this.labelPath.TabIndex = 17;
            this.labelPath.Text = " - ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInfo);
            this.groupBox1.Controls.Add(this.buttonSaveTemplate);
            this.groupBox1.Controls.Add(this.buttonLoadTemplate);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxBauteilName);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.labelBox5);
            this.groupBox1.Controls.Add(this.labelBox6);
            this.groupBox1.Controls.Add(this.labelBox4);
            this.groupBox1.Controls.Add(this.labelBox3);
            this.groupBox1.Controls.Add(this.labelBox2);
            this.groupBox1.Controls.Add(this.labelBox1);
            this.groupBox1.Controls.Add(this.checkedListBox6);
            this.groupBox1.Controls.Add(this.checkedListBox5);
            this.groupBox1.Controls.Add(this.checkedListBox4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkedListBox3);
            this.groupBox1.Controls.Add(this.labelTyp);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.checkedListBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1254, 901);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bauteile";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(7, 837);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(200, 52);
            this.buttonInfo.TabIndex = 37;
            this.buttonInfo.Text = "Zeige Auswahl";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonSaveTemplate
            // 
            this.buttonSaveTemplate.Location = new System.Drawing.Point(1088, 28);
            this.buttonSaveTemplate.Name = "buttonSaveTemplate";
            this.buttonSaveTemplate.Size = new System.Drawing.Size(156, 72);
            this.buttonSaveTemplate.TabIndex = 36;
            this.buttonSaveTemplate.Text = "Vorlage speichern";
            this.buttonSaveTemplate.UseVisualStyleBackColor = true;
            this.buttonSaveTemplate.Click += new System.EventHandler(this.buttonSaveTemplate_Click);
            // 
            // buttonLoadTemplate
            // 
            this.buttonLoadTemplate.Location = new System.Drawing.Point(926, 28);
            this.buttonLoadTemplate.Name = "buttonLoadTemplate";
            this.buttonLoadTemplate.Size = new System.Drawing.Size(156, 72);
            this.buttonLoadTemplate.TabIndex = 26;
            this.buttonLoadTemplate.Text = "Vorlage laden";
            this.buttonLoadTemplate.UseVisualStyleBackColor = true;
            this.buttonLoadTemplate.Click += new System.EventHandler(this.buttonLoadTemplate_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(481, 852);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 25);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Bauteilname:";
            // 
            // textBoxBauteilName
            // 
            this.textBoxBauteilName.Location = new System.Drawing.Point(615, 852);
            this.textBoxBauteilName.Name = "textBoxBauteilName";
            this.textBoxBauteilName.Size = new System.Drawing.Size(494, 29);
            this.textBoxBauteilName.TabIndex = 34;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1115, 837);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(129, 52);
            this.buttonSave.TabIndex = 33;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelBox5
            // 
            this.labelBox5.AutoSize = true;
            this.labelBox5.Location = new System.Drawing.Point(14, 591);
            this.labelBox5.Name = "labelBox5";
            this.labelBox5.Size = new System.Drawing.Size(19, 25);
            this.labelBox5.TabIndex = 32;
            this.labelBox5.Text = "-";
            // 
            // labelBox6
            // 
            this.labelBox6.AutoSize = true;
            this.labelBox6.Location = new System.Drawing.Point(644, 591);
            this.labelBox6.Name = "labelBox6";
            this.labelBox6.Size = new System.Drawing.Size(19, 25);
            this.labelBox6.TabIndex = 31;
            this.labelBox6.Text = "-";
            // 
            // labelBox4
            // 
            this.labelBox4.AutoSize = true;
            this.labelBox4.Location = new System.Drawing.Point(644, 348);
            this.labelBox4.Name = "labelBox4";
            this.labelBox4.Size = new System.Drawing.Size(19, 25);
            this.labelBox4.TabIndex = 30;
            this.labelBox4.Text = "-";
            // 
            // labelBox3
            // 
            this.labelBox3.AutoSize = true;
            this.labelBox3.Location = new System.Drawing.Point(6, 348);
            this.labelBox3.Name = "labelBox3";
            this.labelBox3.Size = new System.Drawing.Size(19, 25);
            this.labelBox3.TabIndex = 29;
            this.labelBox3.Text = "-";
            // 
            // labelBox2
            // 
            this.labelBox2.AutoSize = true;
            this.labelBox2.Location = new System.Drawing.Point(644, 105);
            this.labelBox2.Name = "labelBox2";
            this.labelBox2.Size = new System.Drawing.Size(19, 25);
            this.labelBox2.TabIndex = 28;
            this.labelBox2.Text = "-";
            // 
            // labelBox1
            // 
            this.labelBox1.AutoSize = true;
            this.labelBox1.Location = new System.Drawing.Point(14, 105);
            this.labelBox1.Name = "labelBox1";
            this.labelBox1.Size = new System.Drawing.Size(19, 25);
            this.labelBox1.TabIndex = 27;
            this.labelBox1.Text = "-";
            // 
            // checkedListBox6
            // 
            this.checkedListBox6.FormattingEnabled = true;
            this.checkedListBox6.Location = new System.Drawing.Point(644, 619);
            this.checkedListBox6.Name = "checkedListBox6";
            this.checkedListBox6.Size = new System.Drawing.Size(600, 212);
            this.checkedListBox6.TabIndex = 26;
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Location = new System.Drawing.Point(7, 619);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.Size = new System.Drawing.Size(600, 212);
            this.checkedListBox5.TabIndex = 25;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Location = new System.Drawing.Point(644, 376);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(600, 212);
            this.checkedListBox4.TabIndex = 24;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(7, 376);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(600, 212);
            this.checkedListBox3.TabIndex = 23;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 133);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(600, 212);
            this.checkedListBox1.TabIndex = 22;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(644, 133);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(600, 212);
            this.checkedListBox2.TabIndex = 21;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(18, 989);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(29, 25);
            this.labelError.TabIndex = 20;
            this.labelError.Text = " - ";
            // 
            // listBoxSaved
            // 
            this.listBoxSaved.FormattingEnabled = true;
            this.listBoxSaved.ItemHeight = 24;
            this.listBoxSaved.Location = new System.Drawing.Point(6, 28);
            this.listBoxSaved.Name = "listBoxSaved";
            this.listBoxSaved.Size = new System.Drawing.Size(251, 748);
            this.listBoxSaved.TabIndex = 21;
            this.listBoxSaved.SelectedIndexChanged += new System.EventHandler(this.listBoxSaved_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1231, 1014);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "© Robin Reschke und Chris Deter";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(12, 1014);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(127, 25);
            this.labelVersion.TabIndex = 24;
            this.labelVersion.Text = "Version 1.0.3";
            // 
            // checkBoxHeader
            // 
            this.checkBoxHeader.AutoSize = true;
            this.checkBoxHeader.Location = new System.Drawing.Point(6, 794);
            this.checkBoxHeader.Name = "checkBoxHeader";
            this.checkBoxHeader.Size = new System.Drawing.Size(130, 29);
            this.checkBoxHeader.TabIndex = 25;
            this.checkBoxHeader.Text = "Kopfzeilen";
            this.checkBoxHeader.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBoxHeader);
            this.groupBox2.Controls.Add(this.listBoxSaved);
            this.groupBox2.Location = new System.Drawing.Point(1272, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 901);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Erstellte Bauteile";
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 1060);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMaster";
            this.Text = "Bauteilkatalog Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTyp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckedListBox checkedListBox6;
        private System.Windows.Forms.CheckedListBox checkedListBox5;
        private System.Windows.Forms.Label labelBox6;
        private System.Windows.Forms.Label labelBox4;
        private System.Windows.Forms.Label labelBox3;
        private System.Windows.Forms.Label labelBox2;
        private System.Windows.Forms.Label labelBox1;
        private System.Windows.Forms.Label labelBox5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxSaved;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxBauteilName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.CheckBox checkBoxHeader;
        private System.Windows.Forms.Button buttonSaveTemplate;
        private System.Windows.Forms.Button buttonLoadTemplate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonInfo;
    }
}

