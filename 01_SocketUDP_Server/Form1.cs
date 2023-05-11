using _01_SocketUDP.Classi;
using _01_SocketUDP_Server.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_SocketUDP_Server
{
    public partial class Form1 : Form
    {
        ClsUDPServer clsServer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsAddress.cercaIP();
            cmbIP.DataSource = ClsAddress.ipList;

            dgv.ColumnCount = 3;
            dgv.Columns[0].HeaderText = "IP";
            dgv.Columns[1].HeaderText = "PORT";
            dgv.Columns[2].HeaderText = "MESSAGGIO";
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            btnSTART.Enabled = false;
            btnSTOP.Enabled = true;

            clsServer = new ClsUDPServer((IPAddress)cmbIP.SelectedItem, Convert.ToInt32(numPort.Value));
            clsServer.datiRicevutiEvent += stampaDatiRicevuti;
            clsServer.avvia();
        }
        private void stampaDatiRicevuti(ClsMessage msg)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                dgv.Rows.Add(msg.toArray());
            });
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            btnSTART.Enabled = true;
            btnSTOP.Enabled = false;

            clsServer.chiudi();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnSTART.Enabled)
            {
                btnSTOP_Click(sender, e);
            }
        }
    }
}
