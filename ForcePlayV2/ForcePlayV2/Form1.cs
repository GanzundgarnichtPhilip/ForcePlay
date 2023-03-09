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

                if (form is NeuesSpielHinzuf�gen)
                // Falls ein Form der Klasse 'NeuesSpielHinzuf�gen' ge�ffnet ist, wird es geschlossen.
                {
                    form.Close();
                    break;
                }
            }

            MeineSpiele meineSpiele = new MeineSpiele();
            // Hier wird ein Objekt des 'MeineSpiele' Forms generiert.

            meineSpiele.TopLevel = false;
            // Hier wird festgelegt, dass das 'MeineSpiele' Form nicht als die vorderste Anwendung gez�hlt wird.
            // -> Das ist wichtig, damit das 'MeineSpiele' Form als eine Teilanwendung genutzt werden kann.

            content_panel.Controls.Add(meineSpiele);
            // Hier wird das 'MeineSpiele' Form dem Content-Panel hinzugef�gt, sodass es angezeigt werden kann.

            meineSpiele.BringToFront();
            // Hier wird die Sichtbarkeit des 'MeineSpiele' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.

            meineSpiele.Show();
            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'MeineSpiele') erm�glicht.
        }

        private void neuesSpielHinzuf�gen_button_Click(object sender, EventArgs e)
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

                if (form is NeuesSpielHinzuf�gen)
                // Falls ein Form der Klasse 'NeuesSpielHinzuf�gen' ge�ffnet ist, wird es geschlossen.
                {
                    form.Close();
                    break;
                }
            }

            NeuesSpielHinzuf�gen neuesSpielHinzuf�gen = new NeuesSpielHinzuf�gen();
            // Hier wird ein Objekt des 'NeuesSpielHinzuf�gen' Forms generiert.

            neuesSpielHinzuf�gen.TopLevel = false;
            // Hier wird festgelegt, dass das 'NeuesSpielHinzuf�gen' Form nicht als die vorderste Anwendung gez�hlt wird.
            // -> Das ist wichtig, damit das 'NeuesSpielHinzuf�gen' Form als eine Teilanwendung genutzt werden kann.

            content_panel.Controls.Add(neuesSpielHinzuf�gen);
            // Hier wird das 'NeuesSpielHinzuf�gen' Form dem Content-Panel hinzugef�gt, sodass es angezeigt werden kann.

            neuesSpielHinzuf�gen.BringToFront();
            // Hier wird die Sichtbarkeit des 'NeuesSpielHinzuf�gen' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.

            neuesSpielHinzuf�gen.Show();
            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'NeuesSpielHinzuf�gen') erm�glicht.
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
