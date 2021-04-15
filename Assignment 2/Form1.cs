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
            public double ElevatorPitch;
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
        delegate void AddSendMessageDelegate(string message, ControlsUpdate controlsUpdate);


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
  
            NetworkStream stream = client.GetStream();

            while (true)
            {

                byte[] buffer = new byte[256];
                int num_bytes = stream.Read(buffer, 0, 256);
                if (num_bytes > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, num_bytes);
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
            trkElevatorPitch.Enabled = true;
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
                //Updating current information labels with rounding to 2decimal places
                //
                lblJsonRecivedDisplay.Text = message;
                lblAltitudeVal.Text = Math.Round( recievedMessage.Altitude,2).ToString();
                lblSpeedVal.Text = Math.Round(recievedMessage.Speed, 2).ToString();
                lblPitchVal.Text = Math.Round(recievedMessage.Pitch,2).ToString();
                lblVerticalSpeedVal.Text = Math.Round(recievedMessage.VerticalSpeed,2).ToString();
                lblThrottleVal.Text = Math.Round(recievedMessage.Throttle,2).ToString();
                lblElevatorPitchVal.Text = Math.Round(recievedMessage.ElevatorPitch,2).ToString();
                //
                //Upadate data grid rounding 4decimal places 
                //warning code displayed as enum, data is current date and time
                //
                dgvRecived.Rows.Insert(0,new object[] { Math.Round(recievedMessage.Altitude,4), Math.Round(recievedMessage.Speed,4),
                    Math.Round(recievedMessage.Pitch,4), Math.Round(recievedMessage.VerticalSpeed,4), Math.Round(recievedMessage.Throttle,4),
                    Math.Round(recievedMessage.ElevatorPitch,4), recievedMessage.WarningCode, DateTime.Now.ToString() });
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
            displayElevatorPitchValue();
        }
        //
        //Updates elevetor pitch value
        //
        private void displayElevatorPitchValue()
        {
            double val = trkElevatorPitch.Value;
            val = val / 10;
            lblPitchControlValue.Text = val.ToString();
        }
        //
        // Adding Send messages to data grid and json
        //
        /// reciving string with JSON and struct to update fields
        //
        private void addSendMessage(string message, ControlsUpdate controlsUpdate) 
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AddSendMessageDelegate(addSendMessage), new object[] { message, controlsUpdate });
            }
            else
            {
                //
                //updating json lbl
                //
                lblJsonSendDisplay.Text = message;
                //
                // updating data grid
                //
                dgvSend.Rows.Insert(0, new object[] { controlsUpdate.Throttle, controlsUpdate.ElevatorPitch }); 
            }
        }
        //
        // Sending values from track bar to simulator
        //
        private void btnSend_Click(object sender, EventArgs e)
        {
            ControlsUpdate controlsUpdate = new ControlsUpdate();
            //
            // Assigning values from track bar to struck
            //
            controlsUpdate.Throttle = trkThrottle.Value;                
            controlsUpdate.ElevatorPitch = Convert.ToDouble(trkElevatorPitch.Value)/10 ;
            //
            //   geting stream and sending serialized data     
            //
            JavaScriptSerializer Serializer = new JavaScriptSerializer();                                                            
            string jsonString = Serializer.Serialize(controlsUpdate);
            NetworkStream stream = client.GetStream();                       
            byte[] rawData = Encoding.ASCII.GetBytes(jsonString);   // serializing data
            stream.Write(rawData, 0, rawData.Length);               // writting to stream
            //
            // passing json string and struct so no deserlizsation will be needed
            //
            addSendMessage(jsonString, controlsUpdate);                    
        }

    }
}



