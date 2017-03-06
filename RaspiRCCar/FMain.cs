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
using Media.Rtp;
using Media.Rtsp.Server.MediaTypes;
using XInputDotNetPure;

namespace RaspiRCCar
{
    public partial class FMain : Form
    {
        public TcpClient Client;
        private NetworkStream stream;
        private bool LastControllerState = false;
        private float[] LastTiggerValues = new float[2];
        private GamePadThumbSticks.StickValue[] LastStickValues = new GamePadThumbSticks.StickValue[2];
        private string LastDataValues;

        public FMain()
        {
            InitializeComponent();
        }

        private void Timer_Controller_Tick(object sender, EventArgs e)
        {
            GamePadState state = GamePad.GetState(PlayerIndex.One);
            if (state.IsConnected)
            {
                if (state.IsConnected != LastControllerState)
                {
                    textBox1.AppendText("Controller Connected\n");
                }
                if (state.Triggers.Left != LastTiggerValues[0])
                {
                    textBox1.AppendText("Read Trigger Left " + state.Triggers.Left + "\n");
                }
                if (state.Triggers.Right != LastTiggerValues[1])
                {
                    textBox1.AppendText("Read Trigger Right " + state.Triggers.Right + "\n");
                }
                if (!state.ThumbSticks.Left.Equals(LastStickValues[0]))
                {
                    textBox1.AppendText("Read Pad Left (" + state.ThumbSticks.Left.X + "|" + state.ThumbSticks.Left.Y + ")" + "\n");
                }
                if (!state.ThumbSticks.Right.Equals(LastStickValues[1]))
                {
                    textBox1.AppendText("Read Pad Left (" + state.ThumbSticks.Right.X + "|" + state.ThumbSticks.Right.Y + ")" + "\n");
                }
                PBTriggerL.SetProgressNoAnimation((int) (state.Triggers.Left * 100));
                PBTriggerR.SetProgressNoAnimation((int) (state.Triggers.Right * 100));

                PBPadLX.SetProgressNoAnimation((int) (state.ThumbSticks.Left.X * 100) + 100);
                PBPadLY.SetProgressNoAnimation((int)(state.ThumbSticks.Left.Y * 100) + 100);
                PLeftDot.Location = new Point(50 + (int)(state.ThumbSticks.Left.X * 50) - 3, 50 - (int)(state.ThumbSticks.Left.Y * 50) - 3);
                
                PBPadRX.SetProgressNoAnimation((int) (state.ThumbSticks.Right.X * 100) + 100);
                PBPadRY.SetProgressNoAnimation((int)(state.ThumbSticks.Right.Y * 100) + 100);
                PRightDot.Location = new Point(50 + (int)(state.ThumbSticks.Right.X * 50) - 3, 50 - (int)(state.ThumbSticks.Right.Y * 50) - 3);
            }
            else
            {
                if (state.IsConnected != LastControllerState)
                {
                    textBox1.AppendText("Controller Disconnected\n");
                }
            }
            LastControllerState = state.IsConnected;
            LastTiggerValues[0] = state.Triggers.Left;
            LastTiggerValues[1] = state.Triggers.Right;
            LastStickValues[0] = state.ThumbSticks.Left;
            LastStickValues[1] = state.ThumbSticks.Right;
        }

        private void Timer_Network_Tick(object sender, EventArgs e)
        {
            try
            {
                string values = (PBTriggerR.Value - PBTriggerL.Value) + ";" + (PBPadRX.Value - 100);
                Byte[] data = Encoding.ASCII.GetBytes(values);
                if (values != LastDataValues)
                {
                    stream.Write(data, 0, data.Length);
                }
                LastDataValues = values;
            }
            catch (Exception error)
            {
                Timer_Network.Stop();
                MessageBox.Show(error.Message, "Network Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            stream = Client.GetStream();        
            
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer_Controller.Stop();
            Timer_Network.Stop();
            stream.Close();
            Client.Close();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
