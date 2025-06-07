using Microsoft.EntityFrameworkCore;
using MQTT_WinForms.DB.Objects;
using Message = MQTT_WinForms.DB.Objects.Message;

namespace MQTT_WinForms.DB
{
    public class DataBaseContext : DbContext
    {
        public string SavePath { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Connection> Connections { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DataBaseContext()
        {
            string path = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MQTTUI");
            if (!Path.Exists(path))
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