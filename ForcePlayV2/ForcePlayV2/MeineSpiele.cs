using System.Data;
using System.Diagnostics;

namespace ForcePlayV2
{
    public partial class MeineSpiele : Form
    {
        static List<Spiele> spieleList = new List<Spiele>();

        BindingSource spieleBindingSource = new BindingSource();

        string zuletztGespielt;

        public MeineSpiele()
        {
            InitializeComponent();
            spieleListBox.DisplayMember = "ListBoxAusgabe";
        }

        internal void ReceiveData(Spiele meinSpiel)
        {
            // Spiel aus NeuesSpielHinzufügen-Form wird spieleList-Liste hinzugefügt
            spieleList.Add(meinSpiel);

            // StreamWriter der Text an die daten.txt Datei anhängt
            using (StreamWriter sw = File.AppendText("daten.txt"))
            {
                sw.WriteLine(meinSpiel.Titel + ";" + meinSpiel.Publisher + ";" + meinSpiel.Kategorie + ";" + meinSpiel.Usk + ";" + meinSpiel.Zuletzt + ";" + meinSpiel.Installationsdatum + ";" + meinSpiel.Installationspfad + ";");
            }
        }

        private void MeineSpiele_Load(object sender, EventArgs e)
        {
            // Datenquelle von der BindingSource
            spieleBindingSource.DataSource = spieleList;

            // Datenquelle der ListBox
            spieleListBox.DataSource = spieleBindingSource;

            // spieleBindingSource bezieht seine Spiele aus der Liste,
            // die zuvor ein Objekt aus NeuesSpielHinzufügen-Form bekommen hat.
            // spieleListBox bezieht Daten aus der BindingSource
        }

        private void MeineSpiele_Activated(object sender, EventArgs e)
        {
            // Wenn MeineSpiele-Form aktiviert wird, das heißt wieder in den Vordergrund kommt,
            // werden die Daten aktualisiert und neu eingelesen
            spieleBindingSource.ResetBindings(false);
        }

        private void SpieleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nur wenn man auf ein Objekt drückt (also nicht in die Leere), dann
            // werden die Attribute aus dem spiele-Objekt in die TextBoxen eingegeben
            if (spieleListBox.SelectedIndex != -1)
            {
                Spiele spiele = spieleListBox.SelectedItem as Spiele;

                titel.Text = spiele.Titel;
                publisher.Text = spiele.Publisher;
                genres.Text = spiele.Kategorie;
                zuletztGesp.Text = spiele.Zuletzt;
                usk.Text = spiele.Usk;
                instDatum.Text = spiele.Installationsdatum;
                instPfad.Text = spiele.Installationspfad;
            }
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            int i = spieleListBox.SelectedIndex;
            if (i != -1)
            {
                // Objekt das man ausgewählt hat wird gelöscht

                string titelText = (spieleListBox.SelectedItem as Spiele).Titel;
                string publisherText = (spieleListBox.SelectedItem as Spiele).Publisher;
                string genresText = (spieleListBox.SelectedItem as Spiele).Kategorie;
                string uskText = (spieleListBox.SelectedItem as Spiele).Usk;
                string zuletztGespText = (spieleListBox.SelectedItem as Spiele).Zuletzt;
                string instDatumText = (spieleListBox.SelectedItem as Spiele).Installationsdatum;
                string instPfadText = (spieleListBox.SelectedItem as Spiele).Installationspfad;



                // Das was in der .txt Datei gelöscht werden soll
                var selText = titelText + ";" + publisherText + ";" + genresText + ";" + uskText + ";" + zuletztGespText + ";" + instDatumText + ";" + instPfadText + ";";

                // Das was erhalten bleiben soll, also alle Zeilen außer die ausgewählte
                var unselText = from line in File.ReadAllLines("daten.txt").Where(l => l != selText) select line;

                // Alles wird neu geschrieben, nur ohne selText
                File.WriteAllLines("daten.txt", unselText);

                spieleList.RemoveAt(i);
                Text_Clear();
                zuletztGesp.Text = "";
                spieleBindingSource.ResetBindings(false);
            }
        }

        // Methode um TextBoxen zu leeren
        private void Text_Clear()
        {
            titel.Clear();
            publisher.Clear();
            genres.Clear();
            usk.Text = null;
            instDatum.Clear();
            instPfad.Clear();
        }

        private void SfChanges_button_Click(object sender, EventArgs e)
        {
            // Fehlerprüfung, ob man alle Felder ausgefüllt hat.
            if (titel.Text == "" || publisher.Text == "" || genres.Text == "" || usk.Text == "" || instPfad.Text == "")
            {
                // Überprüfung, ob ein Objekt der Klasse 'Spiele' vorhanden ist.
                if (spieleList.Count <= 0)
                {
                    // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                    using Transparenzschicht transparenzschicht = new Transparenzschicht();

                    // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                    // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                    transparenzschicht.Show();

                    // Hier wird ein Objekt des 'Fehlermeldung4' Forms generiert.
                    Fehlermeldung4 fehlermeldung = new Fehlermeldung4();

                    // Hier wird festgelegt, dass das 'Fehlermeldung4' Form als die vorderste Anwendung gezählt wird.
                    fehlermeldung.TopLevel = true;

                    // Hier wird die Sichtbarkeit des 'Fehlermeldung4' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                    fehlermeldung.BringToFront();

                    // Hier poppt das Form 'Fehlermeldung4' auf.
                    fehlermeldung.ShowDialog();

                    // Alle eingegebene Werte werden verworfen.
                    Text_Clear();
                }

                else
                {
                    // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                    using Transparenzschicht transparenzschicht = new Transparenzschicht();

                    // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                    // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                    transparenzschicht.Show();

                    // Hier wird ein Objekt des 'Fehlermeldung3' Forms generiert.
                    Fehlermeldung3 fehlermeldung = new Fehlermeldung3();

                    // Hier wird festgelegt, dass das 'Fehlermeldung3' Form als die vorderste Anwendung gezählt wird.
                    fehlermeldung.TopLevel = true;

                    // Hier wird die Sichtbarkeit des 'Fehlermeldung3' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                    fehlermeldung.BringToFront();

                    // Hier poppt das Form 'Fehlermeldung3' auf.
                    fehlermeldung.ShowDialog();

                    // Das was in der ListBox steht wird null gesetzt und dann neu aufgefüllt
                    spieleListBox.DisplayMember = null;
                    spieleListBox.DisplayMember = "ListBoxAusgabe";
                }
            }

            if (titel.Text != "" || publisher.Text != "" || genres.Text != "" || usk.Text != "" || instPfad.Text != "")
            {
                // Überprüfung, ob ein Objekt der Klasse 'Spiele' vorhanden ist.
                if (spieleList.Count <= 0)
                {
                    // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                    using Transparenzschicht transparenzschicht = new Transparenzschicht();

                    // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                    // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                    transparenzschicht.Show();

                    // Hier wird ein Objekt des 'Fehlermeldung4' Forms generiert.
                    Fehlermeldung4 fehlermeldung = new Fehlermeldung4();

                    // Hier wird festgelegt, dass das 'Fehlermeldung4' Form als die vorderste Anwendung gezählt wird.
                    fehlermeldung.TopLevel = true;

                    // Hier wird die Sichtbarkeit des 'Fehlermeldung4' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                    fehlermeldung.BringToFront();

                    // Hier poppt das Form 'Fehlermeldung4' auf.
                    fehlermeldung.ShowDialog();

                    // Alle eingegebene Werte werden verworfen.
                    Text_Clear();
                }

                else
                {
                    // string für derzeitige Werte des Objekts festlegen, welches man ausgewählt hat, um diese um Code verlauf nutzen zu können
                    string titelText = (spieleListBox.SelectedItem as Spiele).Titel;
                    string publisherText = (spieleListBox.SelectedItem as Spiele).Publisher;
                    string genresText = (spieleListBox.SelectedItem as Spiele).Kategorie;
                    string uskText = (spieleListBox.SelectedItem as Spiele).Usk;
                    string zuletztGespText = (spieleListBox.SelectedItem as Spiele).Zuletzt;
                    string instDatumText = (spieleListBox.SelectedItem as Spiele).Installationsdatum;
                    string instPfadText = (spieleListBox.SelectedItem as Spiele).Installationspfad;

                    string line = titelText + ";" + publisherText + ";" + genresText + ";" + uskText + ";" + zuletztGespText + ";" + instDatumText + ";" + instPfadText + ";";

                    // überprüfen ob es das ausgewählte Objekt in der .txt Datei gibt
                    if (File.ReadAllText("daten.txt").Contains(line))
                    {
                        // string für derzeitigen Inhalt der .txt Datei festlegen
                        string text = File.ReadAllText("daten.txt");

                        // im derzeitigem Inhalt wird "line" mit aktuellen werten ersetzt
                        text = text.Replace(line, titel.Text + ";" + publisher.Text + ";" + genres.Text + ";" + usk.Text + ";" + zuletztGesp.Text + ";" + instDatum.Text + ";" + instPfad.Text + ";");

                        // Derzeitiger Inhalt der .txt Datei wird überschrieben mit aktuellen Daten
                        File.WriteAllText("daten.txt", text);
                    }

                    // Überschreibung der Daten
                    (spieleListBox.SelectedItem as Spiele).Titel = titel.Text;
                    (spieleListBox.SelectedItem as Spiele).Publisher = publisher.Text;
                    (spieleListBox.SelectedItem as Spiele).Kategorie = genres.Text;
                    (spieleListBox.SelectedItem as Spiele).Usk = usk.Text;
                    (spieleListBox.SelectedItem as Spiele).Installationsdatum = instDatum.Text;
                    (spieleListBox.SelectedItem as Spiele).Installationspfad = instPfad.Text;

                    spieleListBox.DisplayMember = null;
                    spieleListBox.DisplayMember = "ListBoxAusgabe";
                }
            }
        }

        private void StartGame_button_Click(object sender, EventArgs e)
        {
            // Hier wird ein Objekt der Process-Klasse erstellt.
            // -> Die Process-Klasse ermöglicht es eine Anwendung zu starten.
            Process spielStart = new Process();

            // Hier wird der auszuführende Pfad erfasst.
            spielStart.StartInfo.FileName = instPfad.Text;

            // Hier wird geprüft, ob das angegebene Verzeichnis vorhanden ist
            if (File.Exists(spielStart.StartInfo.FileName))
            {
                // Hier wird die Anwendung gestartet.
                spielStart.Start();

                // Hier wird eine Schreibweise festgelegt, wie das Datum ausgegeben werden soll.
                string datumFormat = "dd.MM.yyyy HH:mm";

                // Hier wird der 'zuletztGespielt' Variable das heutige Datum als Wert initialsiert.
                // Außerdem wird festgelegt, dass die Ausgabe über die (zuvor) festegelgte Schreibweise ausgegeben wird.
                zuletztGespielt = DateTime.Now.ToString(datumFormat);

                // Hier wird dem Steuerelement (welch das "Zuletzt gespielt" Attribut vertritt) der Wert der 'zuletztGespielt' Variable zugewiesen.
                zuletztGesp.Text = Convert.ToString(zuletztGespielt);

                // Hier wird dem Attribut 'Zuletzt' der 'Spiele' Klasse der Wert der 'zuletztGespielt' Variable zugewiesen (- prinzipiel -).
                (spieleListBox.SelectedItem as Spiele).Zuletzt = zuletztGesp.Text;
            }

            // Falls das angegeben Verzeichnis nicht existiert, poppt eine Fehlermeldung auf.
            else
            {
                // Überprüfung, ob ein Objekt der Klasse 'Spiele' vorhanden ist.
                if (spieleList.Count <= 0)
                {
                    // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                    using Transparenzschicht transparenzschicht = new Transparenzschicht();

                    // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                    // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                    transparenzschicht.Show();

                    // Hier wird ein Objekt des 'Fehlermeldung5' Forms generiert.
                    Fehlermeldung5 fehlermeldung = new Fehlermeldung5();

                    // Hier wird festgelegt, dass das 'Fehlermeldung4' Form als die vorderste Anwendung gezählt wird.
                    fehlermeldung.TopLevel = true;

                    // Hier wird die Sichtbarkeit des 'Fehlermeldung4' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                    fehlermeldung.BringToFront();

                    // Hier poppt das Form 'Fehlermeldung4' auf.
                    fehlermeldung.ShowDialog();

                    // Alle eingegebene Werte werden verworfen.
                    Text_Clear();
                }

                else
                {
                    // Hier wird ein Objekt des 'Transparenzschicht' Forms generiert.
                    using Transparenzschicht transparenzschicht = new Transparenzschicht();

                    // Hier erscheint das Form 'Transparenzschicht' im Hintergrund.
                    // -> Diese Funktion ist nötig, damit der Benutzer seinen Fokus möglichst auf die Fehlermeldung setzt.
                    transparenzschicht.Show();

                    // Hier wird ein Objekt des 'Fehlermeldung2' Forms generiert.
                    Fehlermeldung2 fehlermeldung = new Fehlermeldung2();

                    // Hier wird festgelegt, dass das 'Fehlermeldung2' Form als die vorderste Anwendung gezählt wird.
                    fehlermeldung.TopLevel = true;

                    // Hier wird die Sichtbarkeit des 'Fehlermeldung2' Forms sichergestellt, indem es an die Vorderseite vor allen Steuerelementen gesetzt wird.
                    fehlermeldung.BringToFront();

                    // Hier poppt das Form 'Fehlermeldung2' auf.
                    fehlermeldung.ShowDialog();
                }
            }
        }

        private void Explorer_Button_Click(object sender, EventArgs e)
        {
            // Hier wird das Arbeitsverzeichnis ausgeführt.
            Process.Start("explorer.exe");
        }

        public void DatenLesen()
        {
            if (File.Exists("daten.txt"))
            {
                // StreamReader der aus der daten.txt Datei liest
                StreamReader sr = new StreamReader("daten.txt");
                string dateiZeile;

                // Solange man nicht am ende der .txt Datei ist
                while (!sr.EndOfStream)
                {
                    Spiele diesesSpiel = new Spiele();
                    dateiZeile = sr.ReadLine();

                    // Array für die Daten, die vor den ";" stehen um unterscheiden zu können, z.B. was in der Zeile der Titel ist
                    string[] teilString = dateiZeile.Split(';');

                    // Liest Daten aus der .txt Datei
                    diesesSpiel.Titel = teilString[0];
                    diesesSpiel.Publisher = teilString[1];
                    diesesSpiel.Kategorie = teilString[2];
                    diesesSpiel.Usk = teilString[3];
                    diesesSpiel.Zuletzt = teilString[4];
                    diesesSpiel.Installationsdatum = teilString[5];
                    diesesSpiel.Installationspfad = teilString[6];

                    //Spiel wird der Liste und somit der ListBox hinzugefügt
                    spieleList.Add(diesesSpiel);
                }
                sr.Close();
            }
        }
    }
}
