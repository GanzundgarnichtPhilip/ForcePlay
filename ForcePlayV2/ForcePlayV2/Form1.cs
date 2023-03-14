namespace ForcePlayV2
{
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
        }

        private void meineSpiele_button_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            // Hier werden nach offenen Forms gesucht und unter der Variable 'form' initialisiert.
            // -> Die Schleifenanweisung 'foreach' sorgt daf�r, dass jedes Formular durchlaufen bzw. gepr�ft wird.
            // -> Der Opperator 'in' pr�ft, ob das aktuelle Element der Sammlung 'offenen Forms' zugeh�rt.
            {
                if (form is MeineSpiele)
                // Falls ein Form der Klasse 'MeineSpiele' ge�ffnet ist, wird es geschlossen.
                {
                    form.Close();
                    break;
                }

                if (form is NeuesSpielHinzufügen)
                // Falls ein Form der Klasse 'NeuesSpielHinzuf�gen' ge�ffnet ist, wird es geschlossen.
                {
                    form.Close();
                    break;
                }
            }

            MeineSpiele meineSpiele = new MeineSpiele();
            // Hier wird ein Objekt des 'MeineSpiele' Forms generiert.

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
            foreach (Form form in Application.OpenForms)
            // Hier werden nach offenen Forms gesucht und unter der Variable 'form' initialisiert.
            // -> Die Schleifenanweisung 'foreach' sorgt daf�r, dass jedes Formular durchlaufen bzw. gepr�ft wird.
            // -> Der Opperator 'in' pr�ft, ob das aktuelle Element der Sammlung 'offenen Forms' zugeh�rt.
            {
                if (form is MeineSpiele)
                // Falls ein Form der Klasse 'MeineSpiele' ge�ffnet ist, wird es geschlossen.
                {
                    form.Close();
                    break;
                }

                if (form is NeuesSpielHinzufügen)
                // Falls ein Form der Klasse 'NeuesSpielHinzuf�gen' ge�ffnet ist, wird es geschlossen.
                {
                    form.Close();
                    break;
                }
            }

            NeuesSpielHinzufügen neuesSpielHinzufügen = new NeuesSpielHinzufügen();
            // Hier wird ein Objekt des 'NeuesSpielHinzuf�gen' Forms generiert.

            neuesSpielHinzufügen.TopLevel = false;
            // Hier wird festgelegt, dass das 'NeuesSpielHinzufügen' Form nicht als die vorderste Anwendung gezählt wird.
            // -> Das ist wichtig, damit das 'NeuesSpielHinzufügen' Form als eine Teilanwendung genutzt werden kann.

            content_panel.Controls.Add(neuesSpielHinzufügen);
            // Hier wird das 'NeuesSpielHinzufügen' Form dem Content-Panel hinzugefügt, sodass es angezeigt werden kann.

            neuesSpielHinzufügen.BringToFront();
            neuesSpielHinzufügen.BringToFront();
            // Hier wird die Sichtbarkeit des 'NeuesSpielHinzufügen' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.

            neuesSpielHinzufügen.Show();
            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'NeuesSpielHinzufügen') ermöglicht.
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void content_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void infobutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help");
        }
    }
}
