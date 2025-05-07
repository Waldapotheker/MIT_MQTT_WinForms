using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
