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

    }
}

