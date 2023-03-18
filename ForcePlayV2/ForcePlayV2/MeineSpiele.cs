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
            // Fehlerprüfung, ob man alle Felder ausgefüllt hat.
            if (titel.Text == "" || publisher.Text == "" || genres.Text == "" || zuletztGesp.Text == "" || usk.Text == "" || instDatum.Text == "" || instPfad.Text == "")
            {
                // Überprüfung, ob ein Objekt der Klasse 'Spiele' vorhanden ist.
                if (spieleList.Count <= 0)
                {
                    // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                    using Transparenzschicht transparenzschicht = new Transparenzschicht();

                    // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                    // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                    transparenzschicht.Show();

                    // Hier wird ein Objekt des 'Fehlermeldung4' Forms generiert.
                    Fehlermeldung4 fehlermeldung = new Fehlermeldung4();

                    // Hier wird festgelegt, dass das 'Fehlermeldung4' Form als die vorderste Anwendung gezählt wird.
                    fehlermeldung.TopLevel = true;

                    // Hier wird die Sichtbarkeit des 'Fehlermeldung4' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                    fehlermeldung.BringToFront();

                    // Hier poppt das Form 'Fehlermeldung4' auf.
                    fehlermeldung.ShowDialog();

                    // Alle eingegebene Werte werden verworfen.
                    Text_Clear();
                }

                else
                {
                    // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                    using Transparenzschicht transparenzschicht = new Transparenzschicht();

                    // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                    // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                    transparenzschicht.Show();

                    // Hier wird ein Objekt des 'Fehlermeldung3' Forms generiert.
                    Fehlermeldung3 fehlermeldung = new Fehlermeldung3();

                    // Hier wird festgelegt, dass das 'Fehlermeldung3' Form als die vorderste Anwendung gezählt wird.
                    fehlermeldung.TopLevel = true;

                    // Hier wird die Sichtbarkeit des 'Fehlermeldung3' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                    fehlermeldung.BringToFront();

                    // Hier poppt das Form 'Fehlermeldung3' auf.
                    fehlermeldung.ShowDialog();

                    // Das was in der ListBox steht wird null gesetzt und dann neu aufgefüllt
                    spieleListBox.DisplayMember = null;
                    spieleListBox.DisplayMember = "ListBoxAusgabe";
                }
            }

            if (titel.Text != "" || publisher.Text != "" || genres.Text != "" || zuletztGesp.Text != "" || usk.Text != "" || instDatum.Text != "" || instPfad.Text != "")
            {
                // Überprüfung, ob ein Objekt der Klasse 'Spiele' vorhanden ist.
                if (spieleList.Count <= 0)
                {
                    // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                    using Transparenzschicht transparenzschicht = new Transparenzschicht();

                    // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                    // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                    transparenzschicht.Show();

                    // Hier wird ein Objekt des 'Fehlermeldung4' Forms generiert.
                    Fehlermeldung4 fehlermeldung = new Fehlermeldung4();

                    // Hier wird festgelegt, dass das 'Fehlermeldung4' Form als die vorderste Anwendung gezählt wird.
                    fehlermeldung.TopLevel = true;

                    // Hier wird die Sichtbarkeit des 'Fehlermeldung4' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                    fehlermeldung.BringToFront();

                    // Hier poppt das Form 'Fehlermeldung4' auf.
                    fehlermeldung.ShowDialog();

                    // Alle eingegebene Werte werden verworfen.
                    Text_Clear();
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

                    // Das was in der ListBox steht wird null gesetzt und dann neu aufgefüllt
                    spieleListBox.DisplayMember = null;
                    spieleListBox.DisplayMember = "ListBoxAusgabe";
                }
            }
        }

        private void StartGame_button_Click(object sender, EventArgs e)
        {
            // Hier wird ein Objekt der Process-Klasse erstellt.
            // -> Die Process-Klasse ermöglicht es eine Anwendung zu starten.
            Process spielStart = new Process();

            // Hier wird der auszuführende Pfad erfasst.
            spielStart.StartInfo.FileName = instPfad.Text;

            // Hier wird geprüft, ob das angegebene Verzeichnis vorhanden ist
            if (File.Exists(spielStart.StartInfo.FileName))
            {
                // Hier wird die Anwendung gestartet.
                spielStart.Start();
            }

            // Falls das angegeben Verzeichnis nicht existiert, poppt eine Fehlermeldung auf.
            else
            {
                // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                using Transparenzschicht transparenzschicht = new Transparenzschicht();

                // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                transparenzschicht.Show();

                // Hier wird ein Objekt des 'Fehlermeldung2' Forms generiert.
                Fehlermeldung2 fehlermeldung = new Fehlermeldung2();

                // Hier wird festgelegt, dass das 'Fehlermeldung2' Form als die vorderste Anwendung gezählt wird.
                fehlermeldung.TopLevel = true;

                // Hier wird die Sichtbarkeit des 'Fehlermeldung2' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                fehlermeldung.BringToFront();

                // Hier poppt das Form 'Fehlermeldung2' auf.
                fehlermeldung.ShowDialog();
            }
        }
    }
}
