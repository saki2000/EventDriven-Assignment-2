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

        TcpClient client;
        Thread listeningThread = null;
        ControlsUpdate controlsUpdate;
        TelemetryUpdate telemetryUpdate;
        bool autoPilotOn = false;


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
            //
            //exception when no ip adresses found
            //
            if (cmbIPAdress.Items.Count > 0)
            {
                cmbIPAdress.SelectedIndex = 0;
            }
            else
            {
                throw new Exception("No valid IP Addresses Located.");
            }
        }
        //
        //declering delegates
        //
        delegate void AddMessageDelegate(string message);

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
            btnTakeOff.Enabled = true;
            trkThrottle.Enabled = true;
            trkElevatorPitch.Enabled = true;
            btnTakeOff.Enabled = true;
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
                //Setting up telemetry update struct
                //
                lblJsonRecivedDisplay.Text = message;
                telemetryUpdate.Altitude = recievedMessage.Altitude;
                telemetryUpdate.Speed = recievedMessage.Speed;
                telemetryUpdate.Pitch = recievedMessage.Pitch;
                telemetryUpdate.VerticalSpeed = recievedMessage.VerticalSpeed;
                telemetryUpdate.Throttle = recievedMessage.Throttle;
                telemetryUpdate.ElevatorPitch = recievedMessage.ElevatorPitch;
                telemetryUpdate.WarningCode = recievedMessage.WarningCode;

                //
                //Updating current information labels with rounding to 2decimal places
                // refreshing labels manually as not always been updated before
                //

                lblAltitudeVal.Text = Math.Round(telemetryUpdate.Altitude, 2).ToString();
                lblAltitudeVal.Refresh();
                lblSpeedVal.Text = Math.Round(telemetryUpdate.Speed, 2).ToString();
                lblSpeedVal.Refresh();
                lblPitchVal.Text = Math.Round(telemetryUpdate.Pitch, 2).ToString();
                lblPitchVal.Refresh();
                lblVerticalSpeedVal.Text = Math.Round(telemetryUpdate.VerticalSpeed, 2).ToString();
                lblVerticalSpeedVal.Refresh();
                lblThrottleVal.Text = Math.Round(telemetryUpdate.Throttle, 2).ToString();
                lblThrottleVal.Refresh();
                lblElevatorPitchVal.Text = Math.Round(telemetryUpdate.ElevatorPitch, 2).ToString();
                lblElevatorPitchVal.Refresh();
                //
                //Upadate data grid rounding 4decimal places 
                //warning code displayed as enum, data is current date and time
                //
                dgvRecived.Rows.Insert(0,new object[] { Math.Round(telemetryUpdate.Altitude,4), Math.Round(telemetryUpdate.Speed,4),
                    Math.Round(telemetryUpdate.Pitch,4), Math.Round(telemetryUpdate.VerticalSpeed,4), Math.Round(telemetryUpdate.Throttle,4),
                    Math.Round(telemetryUpdate.ElevatorPitch,4), telemetryUpdate.WarningCode, DateTime.Now.ToString() });
                //
                // Updating Warning info label
                //
                if (telemetryUpdate.WarningCode == WarningCode.TooLow)
                {
                    lblWarningDisplay.Enabled = true;
                    lblWarningDisplay.Text = "Plane Too Low !";
                }
                else if (telemetryUpdate.WarningCode == WarningCode.Stall)
                {
                    lblWarningDisplay.Enabled = true;
                    lblWarningDisplay.Text = "Stall danger !";
                }
                else
                {
                    lblWarningDisplay.Enabled = false;
                    lblWarningDisplay.Text = "";
                }
                //
                //Switching off autotakeoff button
                //
                if(telemetryUpdate.Speed > 40)
                {
                    btnTakeOff.Enabled = false;
                }
                //
                //Enabling autoPilot
                //
                if (telemetryUpdate.Altitude > 2000 && telemetryUpdate.WarningCode == 0  )
                {
                    enableAutoPilot();
                }

            }
        }

        private void trkThrottle_Scroll(object sender, EventArgs e)
        {
            controlsUpdate.Throttle = trkThrottle.Value;
            displayThrottleValue();
            sendTrackbarValues();
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
            controlsUpdate.ElevatorPitch = trkElevatorPitch.Value;
            displayElevatorPitchValue();
            sendTrackbarValues();
        }
        //
        //Sending values to simulator from trackbars
        //
        private void sendTrackbarValues()
        {
            ControlsUpdate controlsUpdate = new ControlsUpdate();
            //
            // Assigning values from track bar to struck
            //
            controlsUpdate.Throttle = trkThrottle.Value;
            controlsUpdate.ElevatorPitch = Convert.ToDouble(trkElevatorPitch.Value) / 10;
            //
            //   geting stream and sending serialized data     
            //
            JavaScriptSerializer Serializer = new JavaScriptSerializer();
            string jsonString = Serializer.Serialize(controlsUpdate);
            NetworkStream stream = client.GetStream();
            byte[] rawData = Encoding.ASCII.GetBytes(jsonString);   // serializing data
            stream.Write(rawData, 0, rawData.Length);               // writting to stream
            //
            // passing json string 
            //
            addSendMessage(jsonString);
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
        private void addSendMessage(string message) 
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AddMessageDelegate(addSendMessage), new object[] { message });
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
                dgvSend.Rows.Insert(0, new object[] { controlsUpdate.Throttle, controlsUpdate.ElevatorPitch/10 }); 
            }
        }
        //
        //Button starting auto take off
        //
        private void btnTakeOff_Click(object sender, EventArgs e)
        {
            Thread autoTakeOffThread= new Thread(autoTakeOff);
            autoTakeOffThread.Start();
            btnTakeOff.Enabled = false;
            lblAutoInfo.Text = "AUTO TAKO OFF COMMENCE";
            lblAutoInfo.Enabled = true;
            trkElevatorPitch.Enabled = false;
            trkThrottle.Enabled = false;
        }
        //
        //starting auto takeoff thread
        //and controling steady rise untill optimum altitude and speed
        //
        private void autoTakeOff()
        {
            bool liftOff = true;
            bool values = false;
            while (liftOff)
            {
                if (!values) 
                {
                    Invoke(new Action(() =>
                    {
                        trkElevatorPitch.Value = 20;
                        trkThrottle.Value = 100;
                        trkElevetorPitch_Scroll(null, null);
                        trkThrottle_Scroll(null, null);
                    }));
                    values = true;
                }

                if (telemetryUpdate.Altitude < 2000)
                {
                    liftOff = true;
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        trkElevatorPitch.Value = 10;
                        trkThrottle.Value = 80;
                        trkElevetorPitch_Scroll(null, null);
                        trkThrottle_Scroll(null, null);
                    }));
                    liftOff = false;
                }
                Thread.Sleep(500);
            }
            //
            //Enabling scrolls back on and hidding info
            //
            Invoke(new Action(() =>
            {
                trkElevatorPitch.Enabled = true;
                trkThrottle.Enabled = true;
                lblAutoInfo.Text = "";
                lblAutoInfo.Enabled = false;
            }));
        }
        //
        //Enebling AutoPilot
        //
        private void enableAutoPilot()
        {
            txtAltAutoPilot.Enabled = true;
            txtSpeedAutoPilot.Enabled = true;
            btnAutoPilot.Enabled = true;
        }
        //
        //Autopilot activiation button and setting labels
        //
        private void btnAutoPilot_Click(object sender, EventArgs e)
        {
            if(!autoPilotOn )
            {
                if(entryValidation() == true)
                {
                    autoPilotOn = true;
                    Thread autoPilotThread = new Thread(autoPilot);
                    autoPilotThread.Start();
                    btnTakeOff.Enabled = false;
                    lblAutoInfo.Text = "AUTO PILOT ON";
                    lblAutoInfo.Enabled = true;
                    btnAutoPilot.ForeColor = Color.Red;
                    trkElevatorPitch.Enabled = false;
                    trkThrottle.Enabled = false;
                }
                else
                {
                    txtSpeedAutoPilot.Text = "";
                    txtAltAutoPilot.Text = "";
                    lblAutoInfo.ForeColor = Color.Red;
                    lblAutoInfo.Text = "INNCORRECT INPUT";
                    lblAutoInfo.Enabled = true;
                }
            }
            //
            //when autopilot is on this will be triggerd and
            // change labels and info as well as enables scrolls
            //
            else
            {
                autoPilotOn = false;
                trkElevatorPitch.Enabled = true;
                trkThrottle.Enabled = true;
                btnAutoPilot.ForeColor = Color.Green;
                lblAutoInfo.Text = "";
                lblAutoInfo.Enabled = false;
            }
        }
        //
        //autoPilot control and adjusting values
        //
        private void autoPilot()
        {
            while(autoPilotOn)
            {
                //
                //incresse speed if too low
                //
                if(telemetryUpdate.Speed < Int32.Parse(txtSpeedAutoPilot.Text))
                Invoke(new Action(() =>
                {
                    trkThrottle.Value = 90;
                    trkThrottle_Scroll(null, null);
                }));
                //
                //decresse speed if too fast
                //
                if (telemetryUpdate.Speed > Int32.Parse(txtSpeedAutoPilot.Text))
                    Invoke(new Action(() =>
                    {
                        trkThrottle.Value = 60;
                        trkThrottle_Scroll(null, null);
                    }));
                //
                //go up if altitude too low
                //
                if (telemetryUpdate.Altitude < Int32.Parse(txtAltAutoPilot.Text))
                    Invoke(new Action(() =>
                    {
                        trkElevatorPitch.Value = 10;
                        trkElevetorPitch_Scroll(null, null);
                    }));
                //
                //go down if altitude to high
                //
                if (telemetryUpdate.Altitude > Int32.Parse(txtAltAutoPilot.Text))
                    Invoke(new Action(() =>
                    {
                        trkElevatorPitch.Value = -2;
                        trkElevetorPitch_Scroll(null, null);
                    }));
                Thread.Sleep(500);
            }
        }
        //
        //autopilot input validation
        //
        private bool entryValidation()
        {
            //
            //checking if correct data inputed
            //
            if (txtAltAutoPilot.Text == "")
                return false;
            if (txtSpeedAutoPilot.Text == "")
                return false;

            foreach (char c in txtAltAutoPilot.Text)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            foreach (char c in txtSpeedAutoPilot.Text)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            //
            //validatin if autopilt within range
            //
            if (Int32.Parse(txtAltAutoPilot.Text) < 6000 || Int32.Parse(txtAltAutoPilot.Text) > 18000)
                return false;
            if (Int32.Parse(txtSpeedAutoPilot.Text) < 200 || Int32.Parse(txtSpeedAutoPilot.Text) > 500)
                return false;

            return true;
        }


    }
}


