
namespace MQTT_WinForms.DB.Objects
{
    public class Message : BaseObject
    {
		private DateTime timestamp;

		public DateTime Timestamp
		{
			get { return timestamp; }
			set { timestamp = value; }
		}

	}
}
