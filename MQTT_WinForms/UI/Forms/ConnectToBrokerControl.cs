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

        }

        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
        }
    }
}
