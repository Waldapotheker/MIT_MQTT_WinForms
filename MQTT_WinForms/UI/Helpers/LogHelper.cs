using MQTT_WinForms.DB.Objects;
using MQTT_WinForms.MQTT;
using MQTTnet.Protocol;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTT_WinForms.UI.Helpers
{
    public interface ILogSink
    {
        void LogMessage(string message);
    }

    public static class LogHelper
    {
        public static void SafeLog(this ILogSink sink, string message)
        {
            if (sink is Control control && control.InvokeRequired)
            {
                control.Invoke(new Action(() => sink.LogMessage(message)));
            }
            else
            {
                sink.LogMessage(message);
            }
        }
    }
}
