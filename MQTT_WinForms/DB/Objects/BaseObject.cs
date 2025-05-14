using System.ComponentModel.DataAnnotations;

namespace MQTT_WinForms.DB.Objects
{
    public abstract class BaseObject
    {
        public BaseObject()
        {
            ID = Guid.NewGuid();
        }

        [Key]
        public Guid ID { get; private set; }
    }
}
