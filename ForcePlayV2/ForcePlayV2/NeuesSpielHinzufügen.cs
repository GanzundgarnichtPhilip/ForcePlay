using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ForcePlayV2
{
    public partial class NeuesSpielHinzufuegen : Form
    {
        // Liste der Spiele
        List<Spiele> spieleVerwalten = new List<Spiele>();

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
            // Das Form wird geschlossen.
            Close();
        }

        /// <summary>
        /// Diese Methode soll Spiele der jeweiligen Liste hinzufügen
        /// </summary>
        private void SpielHinzufügenButton_Click(object sender, EventArgs e)
        {
            // Objekt des MeineSpiele-Forms wird erzeugt, um ReceiveData-Methode aufrufen zu können
            MeineSpiele meineSpiele = new MeineSpiele();

            // Objekt von der Klasse Spiel wird erzeugt
            var spiel = new Spiele();

            // Alle Daten werden den Attributen zugewiesen.
            spiel.Titel = titel.Text;
            spiel.Zuletzt = zuletztGespielt.Text;
            spiel.Installationsdatum = Installationsdatum.Text;
            spiel.Installationspfad = installationspfad.Text;
            spiel.Kategorie = kategorie.Text;
            spiel.Publisher = publisher.Text;
            spiel.Usk = usk.Text;
            // Überprüfung der Eingabe.
            // -> Falls einem Attribut kein Wert zugewiesen wurde, poppt ein Form der Klasse 'Fehlermeldung' auf.
            if (spiel.Titel == ""
                || spiel.Zuletzt == ""
                || spiel.Installationsdatum == ""
                || spiel.Installationspfad == ""
                || spiel.Kategorie == ""
                || spiel.Publisher == ""
                || spiel.Usk == "")
            {
                // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                using Transparenzschicht transparenzschicht = new Transparenzschicht();

                // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                transparenzschicht.Show();

                // Hier wird ein Objekt des 'Fehlermeldung' Forms generiert.
                Fehlermeldung fehlermeldung = new Fehlermeldung();

                // Hier wird festgelegt, dass das 'Fehlermeldung' Form als die vorderste Anwendung gezählt wird.
                fehlermeldung.TopLevel = true;

                // Hier wird die Sichtbarkeit des 'Fehlermeldung' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                fehlermeldung.BringToFront();

                // Hier poppt das Form 'Fehlermeldung' auf.
                fehlermeldung.ShowDialog();

                // Textfelder werden gecleart.
                titel.Clear();
                zuletztGespielt.Clear();
                installationspfad.Clear();
                Installationsdatum.Clear();
                kategorie.Clear();
                publisher.Clear();
                usk.Text = "";
            }

            else
            {
                // Spiel wird der Liste hinzugefügt.
                spieleVerwalten.Add(spiel);

                // Textfelder werden gecleart.
                titel.Clear();
                zuletztGespielt.Clear();
                installationspfad.Clear();
                Installationsdatum.Clear();
                kategorie.Clear();
                publisher.Clear();
                usk.Text = "";
            }

        }

    }
}
