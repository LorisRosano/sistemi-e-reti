using _01_SocketUDP_Server.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_SocketUDP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsAddress.cercaIP();
            cmbIP.DataSource = ClsAddress.ipList;
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            btnSTART.Enabled = false;
            btnSTOP.Enabled = true;
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            btnSTART.Enabled = true;
            btnSTOP.Enabled = false;
        }
    }
}
