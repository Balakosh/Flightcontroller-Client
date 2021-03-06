using System.Net.Sockets;

namespace Flightcontroller_Client
{
    public partial class Form1 : Form
    {
        private TcpClient tcpClient;
        private bool conneceted = false;
        private Thread tcpReadThread;
        private readonly FlightControllerParser parser = new();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (!conneceted)
            {
                tcpClient = new TcpClient();

                btnConnect.Text = "Connecting";
                btnConnect.Enabled = false;

                try
                {
                    var result = tcpClient.ConnectAsync(txtIP.Text, 1337);

                    await result.WaitAsync(TimeSpan.FromSeconds(1));

                }
                catch (Exception)
                {

                }

                btnConnect.Enabled = true;

                if (tcpClient.Connected)
                {
                    conneceted = true;

                    tcpReadThread = new Thread(new ThreadStart(tcpReadFxn));
                    tcpReadThread.IsBackground = true;
                    tcpReadThread.Start();
                    btnConnect.Text = "Disconnect";
                }
                else
                {
                    btnConnect.Text = "Connect";
                }
            }
            else
            {
                tcpClient.Close();
                conneceted = false;
                btnConnect.Text = "Connect";
            }
        }

        private void tcpReadFxn()
        {
            NetworkStream stream = tcpClient.GetStream();

            while (true)
            {
                try
                {
                    int rxData = stream.ReadByte();

                    if (parser.Parse((byte)rxData) == FlightControllerParser.ParseResult.done)
                    {
                        byte[] msg = parser.GetMessage();

                        lblFrameCounter.Invoke((MethodInvoker)delegate
                        {
                            lblFrameCounter.Text = String.Format("FrameCounter = {0}", msg[1]);
                        });

                        int offset = 6;
                        double accX = BitConverter.ToDouble(msg, offset);
                        double accY = BitConverter.ToDouble(msg, offset + 8);
                        double accZ = BitConverter.ToDouble(msg, offset + 16);

                        double temp = BitConverter.ToDouble(msg, offset + 24);

                        double omgX = BitConverter.ToDouble(msg, offset + 32);
                        double omgY = BitConverter.ToDouble(msg, offset + 40);
                        double omgZ = BitConverter.ToDouble(msg, offset + 48);

                        double roll = BitConverter.ToDouble(msg, offset + 57);
                        double pitch = BitConverter.ToDouble(msg, offset + 65);
                        double yaw = BitConverter.ToDouble(msg, offset + 73);

                        gbAcc.Invoke((MethodInvoker)delegate
                        {
                            lblAccX.Text = String.Format("AccX = {0:0.00} g", accX);
                            lblAccY.Text = String.Format("AccY = {0:0.00} g", accY);
                            lblAccZ.Text = String.Format("AccZ = {0:0.00} g", accZ);
                        });

                        gbOmg.Invoke((MethodInvoker)delegate
                        {
                            lblOmgX.Text = String.Format("OmgX = {0:0.00} ?/s", omgX);
                            lblOmgY.Text = String.Format("OmgY = {0:0.00} ?/s", omgY);
                            lblOmgZ.Text = String.Format("OmgZ = {0:0.00} ?/s", omgZ);
                        });

                        lblTemperature.Invoke((MethodInvoker)delegate
                        {
                            lblTemperature.Text = String.Format("Temperature = {0:0.00} ?C", temp);
                        });

                        gbRPY.Invoke((MethodInvoker)delegate
                        {
                            lblRoll.Text = String.Format("Roll = {0:0.00} ?", roll * 180.0 / Math.PI);
                            lblPitch.Text = String.Format("Pitch = {0:0.00} ?", pitch * 180.0 / Math.PI);
                            lblYaw.Text = String.Format("Yaw = {0:0.00} ?", yaw * 180.0 / Math.PI);
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void sendPropellerPercentageMsg(byte percentage)
        {
            byte frameCounter = 0;
            NetworkStream stream = tcpClient.GetStream();

            byte[] msg = new byte[7];

            msg[0] = 0x7e;
            msg[1] = 2;
            msg[2] = frameCounter++;
            msg[3] = 0;
            msg[4] = (byte)msg.Length;
            msg[5] = 0;
            msg[6] = percentage;

            stream.Write(msg, 0, msg.Length);
        }

        private void btnSetPWM_Click(object sender, EventArgs e)
        {
            sendPropellerPercentageMsg((byte)0);
        }

        private void tbPWM_ValueChanged(object sender, EventArgs e)
        {
            lblPropellerPercentage.Text = String.Format("PWM = {0} %", tbPWM.Value);

            sendPropellerPercentageMsg((byte)tbPWM.Value);
        }
    }
}