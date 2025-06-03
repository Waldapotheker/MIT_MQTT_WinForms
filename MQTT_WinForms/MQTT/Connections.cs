using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTT_WinForms.MQTT
{
    public static class Connections
    {
        public static List<Task>ActiveConnections = new();
    }
}
