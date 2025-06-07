using System.ComponentModel.DataAnnotations;

namespace MQTT_WinForms.DB.Objects
{
    public abstract class BaseObject
    {
        protected BaseObject()
        {
            ID = Guid.NewGuid();
            CreationTime = DateTime.Now;
        }

        [Key]
        public Guid ID { get; private set; }

        public DateTime CreationTime { get; private set; }
    }
}
