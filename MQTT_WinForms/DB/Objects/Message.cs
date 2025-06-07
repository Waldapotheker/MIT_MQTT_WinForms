
using MQTT_WinForms.DB.Enums;

namespace MQTT_WinForms.DB.Objects
{
    public class Message : BaseObject
    {
		public DateTime Timestamp { get; set; } = DateTime.Now;
		public string Topic { get; set; } = "default";
		public string MessageText { get; set; } = "";
        public MessageDirection Direction { get; set; } = MessageDirection.Unknown;
        public int QoSLevel { get; set; } = 0;
        public string ClientID { get; set; } = "anonymous";
    }
}
