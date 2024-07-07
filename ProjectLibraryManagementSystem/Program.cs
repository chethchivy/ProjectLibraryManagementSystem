using Microsoft.Data.SqlClient;

namespace ProjectLibraryManagementSystem
{
    internal static class Program
    {
        private static SqlConnection conn = null!;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Initialize();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormBorrow());
        }
        static void Initialize()
        {
            Helper.ConnectionStringKey = "ConnectionString";
            try
            {
                Helper.LoadConfiguration("appsettings.json");
                conn = Helper.OpenConnection();
                //int n = Helper.CreateProcedures();
                //Helper.GenerateRequiredCommands();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}