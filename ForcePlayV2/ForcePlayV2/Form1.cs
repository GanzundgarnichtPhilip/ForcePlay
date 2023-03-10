namespace ForcePlayV2
{
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
        }

        private void MeineSpiele_button_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            // Hier werden nach offenen Forms gesucht und unter der Variable 'form' initialisiert.
            // -> Die Schleifenanweisung 'foreach' sorgt dafuer, dass jedes Formular durchlaufen bzw. geprueft wird.
            // -> Der Opperator 'in' prueft, ob das aktuelle Element der Sammlung 'offenen Forms' zugehoert.
            {
                if (form is MeineSpiele)
                // Falls ein Form der Klasse 'MeineSpiele' geoeffnet ist, wird es geschlossen.
                {
                    form.Close();
                    break;
                }

                if (form is NeuesSpielHinzufuegen)
                // Falls ein Form der Klasse 'NeuesSpielHinzufuegen' geoeffnet ist, wird es geschlossen.
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
            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'MeineSpiele') ermoeglicht.
        }
        private void NeuesSpielHinzufügen_button_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            // Hier werden nach offenen Forms gesucht und unter der Variable 'form' initialisiert.
            // -> Die Schleifenanweisung 'foreach' sorgt dafuer, dass jedes Formular durchlaufen bzw. geprueft wird.
            // -> Der Opperator 'in' prueft, ob das aktuelle Element der Sammlung 'offenen Forms' zugehoert.
            {
                if (form is MeineSpiele)
                // Falls ein Form der Klasse 'MeineSpiele' geoeffnet ist, wird es geschlossen.
                {
                    form.Close();
                    break;
                }

                if (form is NeuesSpielHinzufuegen)
                // Falls ein Form der Klasse 'NeuesSpielHinzufuegen' geoeffnet ist, wird es geschlossen.
                {
                    form.Close();
                    break;
                }
            }

            NeuesSpielHinzufuegen neuesSpielHinzufügen = new NeuesSpielHinzufuegen();
            // Hier wird ein Objekt des 'NeuesSpielHinzufuegen' Forms generiert.

            neuesSpielHinzufügen.TopLevel = false;
            // Hier wird festgelegt, dass das 'NeuesSpielHinzufuegen' Form nicht als die vorderste Anwendung gezählt wird.
            // -> Das ist wichtig, damit das 'NeuesSpielHinzufuegen' Form als eine Teilanwendung genutzt werden kann.

            content_panel.Controls.Add(neuesSpielHinzufügen);
            // Hier wird das 'NeuesSpielHinzufuegen' Form dem Content-Panel hinzugefügt, sodass es angezeigt werden kann.

            neuesSpielHinzufügen.BringToFront();
            // Hier wird die Sichtbarkeit des 'NeuesSpielHinzufuegen' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.

            neuesSpielHinzufügen.Show();
            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'NeuesSpielHinzufuegen') ermoeglicht.
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
            // Das Menue (und zugleich das ganze Programm) wird geschlossen.
        }
    }
}
