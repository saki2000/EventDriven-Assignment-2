using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        TcpClient client;
        Thread listeningThread = null;

        //
        //Enum for warning
        //
        enum WarningCode { None, TooLow, Stall};

        struct ControlsUpdate
        {
            public double Throttle;
            public double ElevetorPitch;
        }

        struct TelemetryUpdate
        {
            public double Altitude;
            public double Speed;
            public double Pitch;
            public double VerticalSpeed;
            public double Throttle;
            public double ElevatorPitch;
            public WarningCode WarningCode;
        }
        //
        //declering delegates
        //
        delegate void AddMessageDelegate(string message);       
        //
        //declering events
        //

        public Form1()
        {
            InitializeComponent();
            //
            //Populating IP combo box
            //
            string hostName = Dns.GetHostName();
            IPHostEntry ipInfo = Dns.GetHostEntry(hostName);
            foreach (IPAddress ip in ipInfo.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    cmbIPAdress.Items.Add(ip);
                }
            }

            if (cmbIPAdress.Items.Count > 0)
            {
                cmbIPAdress.SelectedIndex = 0;
            }
            else
            {
                throw new Exception("No valid IP Addresses Located.");
            }
        }

        //Button terminating program
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are You Sure?", "EXIT PROGRAM", MessageBoxButtons.YesNo);
            if (DialogResult  == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (DialogResult  == DialogResult.No)
            {
                return;
            }
        }

        //Button connecting to simulator
        private void btnConnect_Click(object sender, EventArgs e)
        {
  
            client = new TcpClient();
            //
            //Parsing text from textboxes to int for IP and Port connection
            //
            IPAddress ip = IPAddress.Parse(cmbIPAdress.Text);
            int port = int.Parse(txtPort.Text);
            client.Connect(ip, port);
            //
            //Display information about connection and enables buttons
            //
            MessageBox.Show("Connected to: " + cmbIPAdress.Text);
            activatingButtons();

            listeningThread = new Thread(new ThreadStart(Listen));
            listeningThread.Start();
        }
        //
        //Thread that listen for input from simulator
        //
        private void Listen()
        {
            //////////////
            //////////////  SOLUTION HAD TO USE AS MY PC WAS TO SLOW TO RECIVE STREAM
            //////////////
            NetworkStream stream = client.GetStream();
            //byte[] next_byte = new byte[1];
            //while (true)
            //{
            //    string message = "";
            //    do
            //    {
            //        int num_bytes = stream.Read(next_byte, 0, 1);
            //        message += Encoding.ASCII.GetString(next_byte, 0, num_bytes);
            //    } while (next_byte[0] != '}');
            //    addMessage(message);
            //}

            //////////////
            ////////////// CORRECT SOLUTION
            /////////////

            while (true)
            {

                byte[] buffer = new byte[256];
                int num_bytes = stream.Read(buffer, 0, 256);
                if (num_bytes > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, num_bytes);
                    //
                    //contructing lambda inplace delegetor and calling to update lbl
                    //
                    Invoke(new Action(() => { lblJsonRecivedDisplay.Text = message; }));
                    //
                    //passing messege to deserialisiation and updating grid
                    //
                    addMessage(message);
                }
            }


        }
        //
        //Enabling Button and updating connection status
        //
        private void activatingButtons()
        {
            btnConnect.Enabled = false;
            cmbIPAdress.Enabled = false;
            txtPort.Enabled = false;
            btnSend.Enabled = true;
            btnTakeOff.Enabled = true;
            trkThrottle.Enabled = true;
            trkElevetorPitch.Enabled = true;
            lblConnectionStatus.Text = "Connection Status: Connected";
            lblConnectionStatus.ForeColor = Color.Green;
        }
        //
        //Adding messege recived from simulator
        //
        
        private void addMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AddMessageDelegate(addMessage), new object[] { message });
            }
            else
            {
                //
                //Deserialize data
                //
                JavaScriptSerializer Serializer = new JavaScriptSerializer();
                TelemetryUpdate recievedMessage = Serializer.Deserialize<TelemetryUpdate>(message);
                //
                //Updating current information labels
                //
                lblAltitude.Text = "Altitude: " + recievedMessage.Altitude;
                lblSpeed.Text = "Speed: " + recievedMessage.Speed;
                lblPitch.Text = "Pitch: " + recievedMessage.Pitch;
                lblVerticalSpeed.Text = "Vertical Speed: " + recievedMessage.VerticalSpeed;
                lblThrottle.Text = "Throttle: " + recievedMessage.Throttle;
                lblElevetorPitch.Text = "Elevetor Pitch: " + recievedMessage.ElevatorPitch;
                //
                //Upadate data grid
                //
                dataGridView1.Rows.Insert(0,new object[] { recievedMessage.Altitude, recievedMessage.Speed,
                    recievedMessage.Pitch, recievedMessage.VerticalSpeed, recievedMessage.Throttle,
                    recievedMessage.ElevatorPitch, recievedMessage.WarningCode, DateTime.Now.ToString() });
                //
                // Updating Warning info label
                //
                if (recievedMessage.WarningCode == WarningCode.TooLow)
                {
                    lblWarningDisplay.Enabled = true;
                    lblWarningDisplay.Text = "Plane Too Low !";
                }
                else if (recievedMessage.WarningCode == WarningCode.Stall)
                {
                    lblWarningDisplay.Enabled = true;
                    lblWarningDisplay.Text = "Stall danger !";
                }
                else
                {
                    lblWarningDisplay.Enabled = false;
                    lblWarningDisplay.Text = "";
                }

            }
        }

        private void trkThrottle_Scroll(object sender, EventArgs e)
        {
            displayThrottleValue();
        }
        //
        //Updates throttle value
        //
        private void displayThrottleValue()
        {
            int val = trkThrottle.Value;
            lblThrottleControlValue.Text = val.ToString();
        }

        private void trkElevetorPitch_Scroll(object sender, EventArgs e)
        {
            displayElevetorPitchValue();
        }
        //
        //Updates elevetor pitch value
        //
        private void displayElevetorPitchValue()
        {
            double val = trkElevetorPitch.Value;
            val = val / 10;
            lblPitchControlValue.Text = val.ToString();
        }
    }
}
