using _01_SocketUDP.Classi;
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

namespace _01_SocketUDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            clsUDPClient clsUDPClient;
            ClsMessage clsMsg;

            clsUDPClient = new clsUDPClient(IPAddress.Parse(txtIP.Text), Convert.ToInt32(numPort.Value));

            clsMsg = new ClsMessage();

            clsMsg.Message = txtMSG.Text;

            clsUDPClient.invia(clsMsg);

        }
    }
}
