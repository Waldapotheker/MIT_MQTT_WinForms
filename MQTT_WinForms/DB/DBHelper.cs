
namespace MQTT_WinForms.DB
{
    public static class DBHelper
    {
        public static DataBaseContext? Context { get; private set; }

        public static void SetContext(DataBaseContext context) => Context = context;
    }
}
