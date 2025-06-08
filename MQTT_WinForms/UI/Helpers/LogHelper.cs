using Message = MQTT_WinForms.DB.Objects.Message;

namespace MQTT_WinForms.UI.Helpers
{
    public interface ILogSink
    {
        void LogMessage(Message message);
    }

    public static class LogHelper
    {
        public static void SafeLog(this ILogSink sink, Message message)
        {
            if (sink is Control { InvokeRequired: true } control)
            {
                control.Invoke(() => sink.LogMessage(message));
            }
            else
            {
                sink.LogMessage(message);
            }
        }
    }
}