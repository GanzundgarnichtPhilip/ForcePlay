namespace ForcePlayV2
{
    public partial class menue : Form
    {
        public menue()
        {
            InitializeComponent();
        }

        private void meineSpiele_button_Click(object sender, EventArgs e)
        {
            MeineSpiele meineSpiele = new MeineSpiele();
            // Hier wird ein Objekt des 'Meine Spiele' Forms generiert.

            meineSpiele.TopLevel = false;
            // Hier wird festgelegt, dass das 'Meine Spiele' Form nicht als die vorderste Anwendung gezählt wird.
            // -> Das ist wichtig, damit das 'Meine Spiele' Form als eine Teilanwendung genutzt werden kann.

            content_panel.Controls.Add(meineSpiele);
            // Hier wird das 'Meine Spiele' Form dem Content-Panel hinzugefügt, sodass es angezeigt werden kann.

            meineSpiele.BringToFront();
            // Hier wird die Sichtbarkeit des 'Meine Spiele' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.

            meineSpiele.Show();
            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'Meine Spiele') ermöglicht.
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
