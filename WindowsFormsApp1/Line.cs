using System.Collections.Generic;

namespace Bauteilkatalogsortierer
{
    internal class Schichtenpaket
    {
        // Spalte A - nicht erfasst
        // Spalte B
        public string eigenerBauteilName { get; set; }
        // Spalte C
        public string bauteilTyp { get; set; }
        // Spalte D
        public string schichtpaketTyp { get; set; }
        // Spalte E
        public string schichtpaket { get; set; }

        // restliche Spalten und Zeilen des Pakets
        public List<string[]> schichten { get; set; }
    }
}

