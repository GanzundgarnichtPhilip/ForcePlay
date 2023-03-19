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

            Application.Run(new Menue());

            // .txt Datei wird automatisch angelegt (falls diese noch nicht vorhanden ist)
            File.Create("daten.txt");
            // Ordner wird erstellt

            // Daten aus der daten.txt Datei werden gelesen und sind somit in der ListBox vorhanden
            meineSpiele.DatenLesen();

        }
    }
}
