using System;
using System.Windows.Forms;

namespace SA46Team10ASportsFacilityBookingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        internal static SA46Team10aESNETProjectEntities ctx;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ctx = new SA46Team10aESNETProjectEntities();
            Application.ApplicationExit += (sender, e) => ctx?.Dispose();
            Application.Run(new Homepage());
        }
    }
}
