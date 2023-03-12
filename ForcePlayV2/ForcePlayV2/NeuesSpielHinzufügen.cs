using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Diese Methode soll Spiele der jeweiligen Liste hinzufügen
        /// </summary>
        private void SpielHinzufügenButton_Click(object sender, EventArgs e)
        {
            var spiel = new Spiele();

            spiel.Titel = titel.Text;
            spiel.Zuletzt = zuletztGespielt.Text;
            spiel.Installationsdatum = Installationsdatum.Text;
            spiel.Installationspfad = installationspfad.Text;
            spiel.Kategorie = kategorie.Text;
            spiel.Publisher = publisher.Text;
            spiel.Usk = usk.Text;

            if (!spiel.pruefung())
                prüfung.Text = "Problem";

            else prüfung.Text = "Perfekt";

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
