using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTT_WinForms.DB.Objects
{
    public class Subscription : BaseObject
    {
        public string Topic { get; set; }

        public int QualityOfService { get; set; }

        public Connection Connection { get; set; }

        public bool IsActive { get; set; }
    }
}