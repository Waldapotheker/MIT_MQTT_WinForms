using MQTTnet.Protocol;
using System.Windows.Forms;

namespace MQTT_WinForms.UI.Forms
{
    public partial class UserInput : Form
    {
        public UserInput()
        {
            InitializeComponent();
        }

        public struct InputResult
        {
            public MqttQualityOfServiceLevel QualityOfService { get; set; }

            public string Topic { get; set; }
        }

        public static InputResult? QueryUser(string currentTopic = null, MqttQualityOfServiceLevel currentQOS = 0)
        {
            UserInput input = new UserInput();

            if (currentTopic != null)
            {
                input.tbTopic.Text = currentTopic;
                input.tbQOS.Value = (int)currentQOS;
            }

            input.btOK.DialogResult = DialogResult.OK;
            input.btCanel.DialogResult = DialogResult.Cancel;
            input.AcceptButton = input.btOK;
            input.CancelButton = input.btCanel;

            DialogResult result = input.ShowDialog();

            if (result == DialogResult.OK)
            {
                return new InputResult
                {
                    QualityOfService = (MqttQualityOfServiceLevel)input.tbQOS.Value,
                    Topic = input.tbTopic.Text
                };
            }

            return null;
        }
    }
}