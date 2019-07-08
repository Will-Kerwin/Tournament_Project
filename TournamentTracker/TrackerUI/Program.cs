using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database connections if jsut one enum means other turned off
            // TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);
            Application.Run(new CreatePrizeForm());

            // test local move
            // \/  run this doing the test bit
            //Application.Run(new TournamentDashboardForm());
        }
    }
}
