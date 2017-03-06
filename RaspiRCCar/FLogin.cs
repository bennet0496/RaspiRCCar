using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaspiRCCar
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BConnect_Click(object sender, EventArgs e)
        {
            var main = new FMain();
            try
            {
                main.Client = new TcpClient(TBAddress.Text, Convert.ToInt32(TBRemotePort.Text));

                main.textBox1.AppendText($"Connected to {TBAddress.Text}:{TBRemotePort.Text}\n");
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            catch(Exception errException)
            {
                MessageBox.Show(errException.Message, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
