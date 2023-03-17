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
        private void button1_Click(object sender, EventArgs e)
        {
            titel.Clear();
            zuletztGespielt.Clear();
            installationspfad.Clear();
            Installationsdatum.Clear();
            kategorie.Clear();
            publisher.Clear();
            usk.Text = "";
        }

        /// <summary>
        /// Diese Methode soll Spiele der jeweiligen Liste hinzufügen
        /// </summary>
        private void SpielHinzufügenButton_Click(object sender, EventArgs e)
        {
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

            // Spiel wird der Liste hinzugefügt.
            spieleVerwalten.Add(spiel);

            // Textfelder werden gecleart
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
