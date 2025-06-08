using System.Text;
using MQTT_WinForms.DB.Enums;
using Message = MQTT_WinForms.DB.Objects.Message;

namespace MQTT_WinForms.UI.Forms
{
    public partial class MessageLogControl : UserControl
    {
        public MessageLogControl()
        {
            InitializeComponent();
        }

        public void AddEntry(Message message)
        {
            string status = message.Direction == MessageDirection.Received ? "Receive" : "Send";
            dataGrid.Rows.Add(status, message.Topic, message.QoSLevel, message.Timestamp, message.MessageText);
        }

        public void AddLogEntry(Log log)
        {
            dataGrid.Rows.Add(log.Status, log.Topic, log.QOS, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), log.Message);
        }

        public void Clear()
        {
            dataGrid.Rows.Clear();
        }

        public string ToCSV(string path)
        {
            const char SEPERATOR = ';';

            StringBuilder csv = new();

            for (int i = 0; i < dataGrid.ColumnCount; i++)
            {
                csv.Append(dataGrid.Columns[i].HeaderText);
                if (i < dataGrid.ColumnCount - 1)
                    csv.Append(SEPERATOR);
            }

            csv.AppendLine();

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.IsNewRow)
                {
                    continue; // Neue leere Zeile ignorieren
                }

                for (int i = 0; i < dataGrid.ColumnCount; i++)
                {
                    string val = row.Cells[i].Value?.ToString() ?? "";
                    val = val.Replace("\"", "\"\""); // Escape quotes
                    if (val.Contains(SEPERATOR) || val.Contains($"\"") || val.Contains($"\n"))
                    {
                        val = $"\"{val}\"";
                    }

                    csv.Append(val);
                    if (i < dataGrid.ColumnCount - 1)
                    {
                        csv.Append(SEPERATOR);
                    }
                }

                csv.AppendLine();
            }

            return csv.ToString();
        }

        public struct Log
        {
            public string Status { get; set; }

            public string Message { get; set; }

            public string Topic { get; set; }

            public int QOS { get; set; }
        }
    }
}