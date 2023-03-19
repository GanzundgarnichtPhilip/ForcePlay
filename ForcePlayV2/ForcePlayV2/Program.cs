namespace ForcePlayV2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            MeineSpiele meineSpiele = new MeineSpiele();

            // .txt Datei wird automatisch angelegt (falls diese noch nicht vorhanden ist)
            if (!File.Exists("daten.txt"))
            {
                // Ordner wird erstellt
                File.Create("daten.txt");

                Application.Run(new Menue());
            }

            else
            {
                // Daten aus der daten.txt Datei werden gelesen und sind somit in der ListBox vorhanden
                meineSpiele.DatenLesen();

                Application.Run(new Menue());
            }
        }
    }
}
