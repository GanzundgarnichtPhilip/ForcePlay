using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ForcePlayV2
{
    public partial class MeineSpiele : Form
    {

        static List<Spiele> spieleList = new List<Spiele>();

        BindingSource spieleBindingSource = new BindingSource();

        public MeineSpiele()
        {
            InitializeComponent();
            spieleListBox.DisplayMember = "ListBoxAusgabe";
        }
        internal void ReceiveData(Spiele meinSpiel)
        {
            // Spiel aus NeuesSpielHinzufügen-Form wird spieleList-Liste hinzugefügt
            spieleList.Add(meinSpiel);
        }

        private void MeineSpiele_Load(object sender, EventArgs e)
        {
            // Datenquelle von der BindingSource
            spieleBindingSource.DataSource = spieleList;

            // Datenquelle der ListBox
            spieleListBox.DataSource = spieleBindingSource;

            // spieleBindingSource bezieht seine Spiele aus der Liste,
            // die zuvor ein Objekt aus NeuesSpielHinzufügen-Form bekommen hat.
            // spieleListBox bezieht Daten aus der BindingSource
        }

        private void MeineSpiele_Activated(object sender, EventArgs e)
        {
            // Wenn MeineSpiele-Form aktiviert wird, das heißt wieder in den Vordergrund kommt,
            // werden die Daten aktualisiert und neu eingelesen
            spieleBindingSource.ResetBindings(false);
        }

        private void SpieleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nur wenn man auf ein Objekt drückt (also nicht in die Leere), dann
            // werden die Attribute aus dem spiele-Objekt in die TextBoxen eingegeben
            if (spieleListBox.SelectedIndex != -1)
            {

                Spiele spiele = spieleListBox.SelectedItem as Spiele;

                titel.Text = spiele.Titel;
                publisher.Text = spiele.Publisher;
                genres.Text = spiele.Kategorie;
                zuletztGesp.Text = spiele.Zuletzt;
                usk.Text = spiele.Usk;
                instDatum.Text = spiele.Installationsdatum;
                instPfad.Text = spiele.Installationspfad;
            }
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            int i = spieleListBox.SelectedIndex;
            if (i != -1)
            {
                // Objekt das man ausgewählt hat wird gelöscht
                spieleList.RemoveAt(i);
                Text_Clear();
                spieleBindingSource.ResetBindings(false);
            }
        }

        // Methode um TextBoxen zu leeren
        private void Text_Clear()
        {
            titel.Clear();
            publisher.Clear();
            genres.Clear();
            zuletztGesp.Clear();
            usk.Clear();
            instDatum.Clear();
            instPfad.Clear();
        }

        private void SfChanges_button_Click(object sender, EventArgs e)
        {

            // Fehler Prüfung, ob man alle Felder ausgefüllt hat
            if (titel.Text == "" || publisher.Text == "" || genres.Text == "" || zuletztGesp.Text == "" || usk.Text == "" || instDatum.Text == "" || instPfad.Text == "")
            {
                // Fehlermeldung
                fehlerMeldung_label.Text = "Bitte alle Felder ausfüllen";
            }
            else
            {
                // Überschreibung der Daten
                (spieleListBox.SelectedItem as Spiele).Titel = titel.Text;
                (spieleListBox.SelectedItem as Spiele).Publisher = publisher.Text;
                (spieleListBox.SelectedItem as Spiele).Kategorie = genres.Text;
                (spieleListBox.SelectedItem as Spiele).Zuletzt = zuletztGesp.Text;
                (spieleListBox.SelectedItem as Spiele).Usk = usk.Text;
                (spieleListBox.SelectedItem as Spiele).Installationsdatum = instDatum.Text;
                (spieleListBox.SelectedItem as Spiele).Installationspfad = instPfad.Text;

                // Label Text wird entfernt
                fehlerMeldung_label.Text = "";
            }

            // Das was in der ListBox steht wird null gesetzt und dann neu aufgefüllt
            spieleListBox.DisplayMember = null;
            spieleListBox.DisplayMember = "ListBoxAusgabe";
        }

        private void StartGame_button_Click(object sender, EventArgs e)
        {
            // Falls ein gültiger Installationspfad vorhanden ist, kann die Anwendung gestartet werden.
            if (instPfad.Text != "")
            {
                // Hier wird der Pfad (wo das Spiel sich befindet) unter der Variable 'spielPfad' deklariert.
                string spielPfad = instPfad.Text;

                // Hier wird ein Objekt der Process-Klasse erstellt.
                // -> Die Process-Klasse ermöglicht es eine Anwendung zu starten.
                Process spielStart = new Process();

                // Hier wird der auszuführende Pfad erfasst.
                spielStart.StartInfo.FileName = spielPfad;

                // Hier wird das Arbeitsverzeichnis auf den auszuführenden Pfad gesetzt.
                // -> Dies ist nötig, damit das Verzeichnis korrekt ausgeführt werden kann.
                spielStart.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(spielPfad);

                // Hier wird das Spiel gestartet.
                spielStart.Start();
            }

            else
            {
                // FEHLERMELDUNG
            }
        }
    }
}
