using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcePlayV2
{
     class Spiele
    {

        // Die Attribute der Spiele
        string titel;
        string installationsdatum;
        string zuletzt;
        string installationspfad;
        string kategorie;
        string publisher;
        string usk;

        List<string> spieleVerwalten = new List<String>();

        // Um Fehleingaben micht prüfen zu müssen, werden allen Attributen direkt ein Wert zugewiesen.
        public Spiele()
        {
            titel = "";
            installationsdatum = "";
            zuletzt = "";
            installationspfad = "";
            kategorie = "";
            publisher = "";
            usk = "";
        }

        // Getter und Setter der jeweiligen Attribute.
        public string Titel { get => titel; set => titel = value; }
        public string Installationsdatum { get => installationsdatum; set => installationsdatum = value; }
        public string Zuletzt { get => zuletzt; set => zuletzt = value; }
        public string Installationspfad { get => installationspfad; set => installationspfad = value; }
        public string Kategorie { get => kategorie; set => kategorie = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Usk { get => usk; set => usk = value; }
        
        public bool pruefung()
        {

            if (titel == "")
                return false;

            if (installationsdatum == "")
                return false;

            if (installationspfad == "")
                return false;

            if (zuletzt == "")
                return false;

            if (kategorie == "")
                return false;

            if (publisher == "")
                return false;

            switch (usk)
            {
                case "0":
                    return true;

                case "6":
                    return true;

                case "12":
                    return true;

                case "16":
                    return true;

                case "18":
                    return true;

                default: return false;
            }

        }

    }
}

