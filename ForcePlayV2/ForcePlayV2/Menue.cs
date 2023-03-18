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
            // Hier werden nach offenen Forms gesucht und unter der Variable 'form' initialisiert.
            // -> Die Schleifenanweisung 'foreach' sorgt dafuer, dass jedes Formular durchlaufen bzw. geprueft wird.
            // -> Der Opperator 'in' prueft, ob das aktuelle Element der Sammlung 'offenen Forms' zugehoert.
            foreach (Form form in Application.OpenForms)
            {
                // Falls ein Form der Klasse 'MeineSpiele' geoeffnet ist, wird es geschlossen.
                if (form is MeineSpiele)
                {
                    form.Close();
                    break;
                }

                // Falls ein Form der Klasse 'NeuesSpielHinzufuegen' geoeffnet ist, wird es geschlossen.
                if (form is NeuesSpielHinzufuegen)
                {
                    form.Close();
                    break;
                }
            }

            // Hier wird ein Objekt des 'MeineSpiele' Forms generiert.
            MeineSpiele meineSpiele = new MeineSpiele();

            // Hier wird festgelegt, dass das 'MeineSpiele' Form nicht als die vorderste Anwendung gezählt wird.
            // -> Das ist wichtig, damit das 'MeineSpiele' Form als eine Teilanwendung genutzt werden kann.
            meineSpiele.TopLevel = false;

            // Hier wird das 'MeineSpiele' Form dem Content-Panel hinzugefügt, sodass es angezeigt werden kann.
            content_panel.Controls.Add(meineSpiele);

            // Hier wird die Sichtbarkeit des 'MeineSpiele' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
            meineSpiele.BringToFront();

            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'MeineSpiele') ermoeglicht.
            meineSpiele.Show();
        }

        private void NeuesSpielHinzufügen_button_Click(object sender, EventArgs e)
        {
            // Hier werden nach offenen Forms gesucht und unter der Variable 'form' initialisiert.
            // -> Die Schleifenanweisung 'foreach' sorgt dafuer, dass jedes Formular durchlaufen bzw. geprueft wird.
            // -> Der Opperator 'in' prueft, ob das aktuelle Element der Sammlung 'offenen Forms' zugehoert.
            foreach (Form form in Application.OpenForms)
            {
                // Falls ein Form der Klasse 'MeineSpiele' geoeffnet ist, wird es geschlossen.
                if (form is MeineSpiele)
                {
                    form.Close();
                    break;
                }

                // Falls ein Form der Klasse 'NeuesSpielHinzufuegen' geoeffnet ist, wird es geschlossen.
                if (form is NeuesSpielHinzufuegen)

                {
                    form.Close();
                    break;
                }
            }

            // Hier wird ein Objekt des 'NeuesSpielHinzufuegen' Forms generiert.
            NeuesSpielHinzufuegen neuesSpielHinzufügen = new NeuesSpielHinzufuegen();

            // Hier wird festgelegt, dass das 'NeuesSpielHinzufuegen' Form nicht als die vorderste Anwendung gezählt wird.
            // -> Das ist wichtig, damit das 'NeuesSpielHinzufuegen' Form als eine Teilanwendung genutzt werden kann.
            neuesSpielHinzufügen.TopLevel = false;

            // Hier wird das 'NeuesSpielHinzufuegen' Form dem Content-Panel hinzugefügt, sodass es angezeigt werden kann.
            content_panel.Controls.Add(neuesSpielHinzufügen);

            // Hier wird die Sichtbarkeit des 'NeuesSpielHinzufuegen' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
            neuesSpielHinzufügen.BringToFront();

            // Hier wird die Interaktion mit dem angezeigten Form (in diesem Fall 'NeuesSpielHinzufuegen') ermoeglicht.
            neuesSpielHinzufügen.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            // Das Menue (und zugleich das ganze Programm) wird geschlossen.
            Close();
        }

        private void content_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Infobutton_Click(object sender, EventArgs e)
        {
            // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
            using Transparenzschicht transparenzschicht = new Transparenzschicht();

            // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
            // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
            transparenzschicht.Show();

            // Hier wird ein Objekt des 'Informationsanzeige' Forms generiert.
            Informationsanzeige informationsanzeige = new Informationsanzeige();

            // Hier wird festgelegt, dass das 'Informationsanzeige' Form als die vorderste Anwendung gezählt wird.
            informationsanzeige.TopLevel = true;

            // Hier wird die Sichtbarkeit des 'Informationsanzeige' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
            informationsanzeige.BringToFront();

            // Hier poppt das Form 'Informationsanzeige' auf.
            informationsanzeige.ShowDialog();
        }
        /// <summary>
        /// EasterEgg Button funktion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void easterEgg_Click(object sender, EventArgs e)
        {
            // Objekt des BreakOut Spiels wird erzeugt
            BreakOut breakout = new BreakOut();

            // Easter Egg wird geöffnet
            breakout.ShowDialog();
        }
    }
}
