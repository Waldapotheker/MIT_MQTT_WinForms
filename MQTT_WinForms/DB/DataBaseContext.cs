using Microsoft.EntityFrameworkCore;
using Message = MQTT_WinForms.DB.Objects.Message;

namespace MQTT_WinForms.DB
{
    public class DataBaseContext : DbContext
    {
        private string path;
        public string SavePath
        {
            get { return path; }
            private set { path = value; }
        }

        public DbSet<Message> Messages { get; set; }

        public DataBaseContext()
        {
            string path = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MQTTUI");
            if(!Path.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            SavePath = Path.Combine(path, "database.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {      
            options.UseSqlite($"Data Source={SavePath}");
        }
    }
}
