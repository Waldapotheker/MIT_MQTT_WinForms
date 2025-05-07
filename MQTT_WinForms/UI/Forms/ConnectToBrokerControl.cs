using MQTT_WinForms.UI.MQTT;
using MQTTnet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTT_WinForms.Forms
{
    public partial class ConnectToBrokerControl : UserControl
    {
        public ConnectToBrokerControl()
        {
            InitializeComponent();
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            MqttClientOptionsBuilder clientConnection = MQTTConnectionHelper.NewClientObjectsBuilder(tbAdresse.Text, Convert.ToInt32(nudPort.Value), tbClientId.Text);  
        }
    }
}
