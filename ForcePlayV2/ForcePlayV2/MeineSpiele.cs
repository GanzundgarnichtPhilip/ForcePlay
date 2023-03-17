using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void spieleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            // Nur wenn man auf ein Objekt drückt (also nicht in die Leere), dann
            // werden die Attribute aus dem spiele-Objekt in die TextBoxen eingegeben
            if(spieleListBox.SelectedIndex != -1)
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

        private void del_button_Click(object sender, EventArgs e)
        {
            int i = spieleListBox.SelectedIndex;
            if(i != -1)
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

        private void sfChanges_button_Click(object sender, EventArgs e)
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

            // Das was in der ListBox steth wird null gesetzt und dann neu aufgefüllt
            spieleListBox.DisplayMember = null;
            spieleListBox.DisplayMember = "ListBoxAusgabe"; 
        }
    }
}
