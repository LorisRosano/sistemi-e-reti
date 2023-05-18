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

namespace UDP_Tris
{
    public partial class Form1 : Form
    {
        ClsUDPServer server;
        clsUDPClient client;
        ClsMessage clsMSG;
        public Form1()
        {
            InitializeComponent();
            ClsAddress.cercaIP();
            cmbIP.DataSource = ClsAddress.ipList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new ClsUDPServer((IPAddress)cmbIP.SelectedItem, Convert.ToInt32(numPort.Value));
            server.datiRicevutiEvent += posizionaMossaAvversario;
            server.avvia();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void posizionaMossaAvversario(ClsMessage infoAvv)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                int i, j;

                i = Convert.ToInt32(infoAvv.Message.Substring(0, 1));
                j = Convert.ToInt32(infoAvv.Message.Substring(1, 1));

                Controls["btn" + i.ToString() + j.ToString()].Text = "O";
                Controls["btn" + i.ToString() + j.ToString()].BackColor = Color.Red;
            });
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.chiudi();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnTrasmettiMossa_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int i, j;

            i = Convert.ToInt32(btn.Name.Substring(3, 1));
            j = Convert.ToInt32(btn.Name.Substring(4));

            clsMSG = new ClsMessage();
            clsMSG.Message = i.ToString() + j.ToString()+"LORIS";

            client = new clsUDPClient(IPAddress.Parse(avvIP.Text), Convert.ToInt32(numAvvPort.Value));
            client.invia(clsMSG);

            btn.Text = "X";
            btn.BackColor = Color.Green;
        }
    }
}
