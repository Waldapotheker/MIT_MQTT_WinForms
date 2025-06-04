
namespace MQTT_WinForms.DB.Objects
{
    public class Message : BaseObject
    {
		private DateTime timestamp;
		public DateTime Timestamp { get; set; }
		public string Topic { get; set; }
		public string MessageText { get; set; }
		public Connection Connection { get; set; }
	}
}
