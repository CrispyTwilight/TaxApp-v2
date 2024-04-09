using Microsoft.Data.SqlClient;

namespace TaxApp_v2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create an instance of the DatabaseManager class and create the tables.
            DatabaseManager dbManager = new DatabaseManager();
            dbManager.CreateTables();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }
    }
}