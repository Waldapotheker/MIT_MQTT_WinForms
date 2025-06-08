using System.ComponentModel.DataAnnotations;
using MQTT_WinForms.DB.Enums;

namespace MQTT_WinForms.DB.Objects
{
    public class Message : BaseObject
    {
        [Required]
        public DateTime Timestamp { get; set; } = DateTime.Now;

        [Required]
        public string Topic { get; set; } = "default";

        [Required]
        public string MessageText { get; set; } = "";

        public MessageDirection Direction { get; set; } = MessageDirection.Unknown;

        [Required]
        public int QoSLevel { get; set; } = 0;

        public string ClientID { get; set; } = "anonymous";

        [Required]
        public Connection Connection { get; set; }
    }
}