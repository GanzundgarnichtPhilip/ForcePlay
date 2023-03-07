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
            // Hier wird festgelegt, dass das 'MeineSpiele' Form nicht als die vorderste Anwendung gezählt wird.
            // -> Das ist wichtig, damit das 'MeineSpiele' Form als eine Teilanwendung genutzt werden kann.

            content_panel.Controls.Add(meineSpiele);
            // Hier wird das 'MeineSpiele' Form dem Content-Panel hinzugefügt, sodass es angezeigt werden kann.

            meineSpiele.BringToFront();
            // Hier wird die Sichtbarkeit des 'MeineSpiele' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.

            meineSpiele.Show();
            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'MeineSpiele') ermöglicht.
        }

        private void neuesSpielHinzufügen_button_Click(object sender, EventArgs e)
        {
            NeuesSpielHinzufügen neuesSpielHinzufügen = new NeuesSpielHinzufügen();
            // Hier wird ein Objekt des 'NeuesSpielHinzufügen' Forms generiert.

            neuesSpielHinzufügen.TopLevel = false;
            // Hier wird festgelegt, dass das 'NeuesSpielHinzufügen' Form nicht als die vorderste Anwendung gezählt wird.
            // -> Das ist wichtig, damit das 'NeuesSpielHinzufügen' Form als eine Teilanwendung genutzt werden kann.

            content_panel.Controls.Add(neuesSpielHinzufügen);
            // Hier wird das 'NeuesSpielHinzufügen' Form dem Content-Panel hinzugefügt, sodass es angezeigt werden kann.

            neuesSpielHinzufügen.BringToFront();
            // Hier wird die Sichtbarkeit des 'NeuesSpielHinzufügen' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.

            neuesSpielHinzufügen.Show();
            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'NeuesSpielHinzufügen') ermöglicht.
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
