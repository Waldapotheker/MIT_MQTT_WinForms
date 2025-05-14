using Microsoft.EntityFrameworkCore.Diagnostics;
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
using MQTT_WinForms.BASE;

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
            ConnectionData connectionData = new ConnectionData()
            {
                Address = tbAdresse.Text,
                Port = Convert.ToInt32(nudPort.Value),
                ClientID = tbClientId.Text,
                Username = tbUsername.Text,
                Password = tbPasswort.Text,
            };
        }

        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            if (!richTextBoxAusgabe.Visible)
                richTextBoxAusgabe.Visible = true;
            else
                richTextBoxAusgabe.Visible = false;


        }
    }
}
