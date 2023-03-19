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

            // Ordner wird erstellt
            MeineSpiele meineSpiele = new MeineSpiele();

            // Daten aus der daten.txt Datei werden gelesen und sind somit in der ListBox vorhanden
            meineSpiele.DatenLesen();

            // .txt Datei wird automatisch angelegt fall diese noch nicht vorhanden ist
            if (!File.Exists("daten.txt"))
            {
                File.Create("daten.txt");
            }

            Application.Run(new Menue());
        }
    }
}
