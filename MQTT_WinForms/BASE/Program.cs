using Microsoft.EntityFrameworkCore;
using MQTT_WinForms.DB;

namespace MQTT_WinForms.BASE
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (DataBaseContext context = new())
            {
                context.Database.Migrate();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}