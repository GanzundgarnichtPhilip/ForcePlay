using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ForcePlayV2
{
    public partial class NeuesSpielHinzufuegen : Form
    {
        public NeuesSpielHinzufuegen()
        {

            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Das Form wird geschlossen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            // Die Eingabe wird geleert
            titel.Clear();
            installationspfad.Clear();
            installationsdatum.Value = DateTime.Today;
            kategorie.Clear();
            publisher.Clear();
            usk.Text = null;
        }

        /// <summary>
        /// Diese Methode soll Spiele der jeweiligen Liste hinzufügen
        /// </summary>
        private void SpielHinzufügenButton_Click(object sender, EventArgs e)
        {
            // Überprüfung der Eingabe.
            // -> Falls einem Attribut kein neuer Wert zugewiesen wurde, poppt ein Form der Klasse 'FehlermeldungNeuesSpielHinzufügen' und 'Transparentschicht' auf.
            if (titel.Text == ""
                || installationspfad.Text == ""
                || kategorie.Text == ""
                || publisher.Text == ""
                || usk.Text == null)
            {
                // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                using Transparenzschicht transparenzschicht = new Transparenzschicht();

                // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                transparenzschicht.Show();

                // Hier wird ein Objekt des 'Fehlermeldung1' Forms generiert.
                Fehlermeldung1 fehlermeldung = new Fehlermeldung1();

                // Hier wird festgelegt, dass das 'Fehlermeldung1' Form als die vorderste Anwendung gezählt wird.
                fehlermeldung.TopLevel = true;

                // Hier wird die Sichtbarkeit des 'Fehlermeldung1' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                fehlermeldung.BringToFront();

                // Hier poppt das Form 'Fehlermeldung1' auf.
                fehlermeldung.ShowDialog();

                // Textfelder werden gecleart.
                titel.Clear();
                installationspfad.Clear();
                installationsdatum.Value = DateTime.Today;
                kategorie.Clear();
                publisher.Clear();
                usk.Text = null;
            }

            else
            {
                // Objekt von der Klasse Spiel wird erzeugt.
                var spiel = new Spiele();

                // Alle Daten werden den Attributen zugewiesen.
                spiel.Titel = titel.Text;
                spiel.Installationsdatum = installationsdatum.Text;
                spiel.Installationspfad = installationspfad.Text;
                spiel.Kategorie = kategorie.Text;
                spiel.Publisher = publisher.Text;
                spiel.Usk = usk.Text;

                // Hier wird ein neues Objekt der Klasse 'MeineSpiele' erstellt.
                MeineSpiele meineSpiele = new MeineSpiele();

                // Hier wird das neu generierte Objekt 'spiel' dem Objekt 'meineSpiele' aus der Klasse 'MeineSpiele' übermittelt.
                meineSpiele.ReceiveData(spiel);

                // Für nährere Informationen: https://youtu.be/zTd6x74mtCI - 'Wie man Daten zwischen zwei Forms austauscht'.

                // Textfelder werden gecleart.
                titel.Clear();
                installationspfad.Clear();
                installationsdatum.Value = DateTime.Today;
                kategorie.Clear();
                publisher.Clear();
                usk.Text = null;
            }

        }

        private void Explorer_Button_Click(object sender, EventArgs e)
        {
            // Hier wird das Arbeitsverzeichnis ausgeführt.
            Process.Start("explorer.exe");
        }
    }
}
