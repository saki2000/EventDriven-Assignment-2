
namespace Assignment_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnTakeOff = new System.Windows.Forms.Button();
            this.lblThrottleControlValue = new System.Windows.Forms.Label();
            this.lblPitchControlValue = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lblVerticalSpeed = new System.Windows.Forms.Label();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.lblElevatorPitch = new System.Windows.Forms.Label();
            this.lblJsonSendDisplay = new System.Windows.Forms.Label();
            this.lblJsonRecivedDisplay = new System.Windows.Forms.Label();
            this.dgvRecived = new System.Windows.Forms.DataGridView();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerticalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Throttle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevatorPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrningCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDataRecived = new System.Windows.Forms.GroupBox();
            this.lblElevatorPitchVal = new System.Windows.Forms.Label();
            this.lblThrottleVal = new System.Windows.Forms.Label();
            this.lblVerticalSpeedVal = new System.Windows.Forms.Label();
            this.lblPitchVal = new System.Windows.Forms.Label();
            this.lblAltitudeVal = new System.Windows.Forms.Label();
            this.lblSpeedVal = new System.Windows.Forms.Label();
            this.grbConnection = new System.Windows.Forms.GroupBox();
            this.cmbIPAdress = new System.Windows.Forms.ComboBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.grbJsonSend = new System.Windows.Forms.GroupBox();
            this.grbJsonRecived = new System.Windows.Forms.GroupBox();
            this.grbControls = new System.Windows.Forms.GroupBox();
            this.lbl05Elevator = new System.Windows.Forms.Label();
            this.lbl5Elevator = new System.Windows.Forms.Label();
            this.lbl0throttle = new System.Windows.Forms.Label();
            this.lbl100throtle = new System.Windows.Forms.Label();
            this.trkElevatorPitch = new System.Windows.Forms.TrackBar();
            this.trkThrottle = new System.Windows.Forms.TrackBar();
            this.lblElevatorPitchControl = new System.Windows.Forms.Label();
            this.lblThtottleControl = new System.Windows.Forms.Label();
            this.lblWarningDisplay = new System.Windows.Forms.Label();
            this.grbWarnings = new System.Windows.Forms.GroupBox();
            this.grbAutomaticControls = new System.Windows.Forms.GroupBox();
            this.lblAutoInfo = new System.Windows.Forms.Label();
            this.btnAutoPilot = new System.Windows.Forms.Button();
            this.lblAutoPilotAlt = new System.Windows.Forms.Label();
            this.lblAutoPilotSpeed = new System.Windows.Forms.Label();
            this.txtAltAutoPilot = new System.Windows.Forms.TextBox();
            this.txtSpeedAutoPilot = new System.Windows.Forms.TextBox();
            this.dgvSend = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecived)).BeginInit();
            this.grbDataRecived.SuspendLayout();
            this.grbConnection.SuspendLayout();
            this.grbJsonSend.SuspendLayout();
            this.grbJsonRecived.SuspendLayout();
            this.grbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevatorPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).BeginInit();
            this.grbWarnings.SuspendLayout();
            this.grbAutomaticControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSend)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPort
            // 
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.Name = "txtPort";
            // 
            // lblPort
            // 
            resources.ApplyResources(this.lblPort, "lblPort");
            this.lblPort.Name = "lblPort";
            // 
            // lblConnectionStatus
            // 
            resources.ApplyResources(this.lblConnectionStatus, "lblConnectionStatus");
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            // 
            // btnTakeOff
            // 
            resources.ApplyResources(this.btnTakeOff, "btnTakeOff");
            this.btnTakeOff.ForeColor = System.Drawing.Color.Blue;
            this.btnTakeOff.Name = "btnTakeOff";
            this.btnTakeOff.UseVisualStyleBackColor = true;
            this.btnTakeOff.Click += new System.EventHandler(this.btnTakeOff_Click);
            // 
            // lblThrottleControlValue
            // 
            resources.ApplyResources(this.lblThrottleControlValue, "lblThrottleControlValue");
            this.lblThrottleControlValue.Name = "lblThrottleControlValue";
            // 
            // lblPitchControlValue
            // 
            resources.ApplyResources(this.lblPitchControlValue, "lblPitchControlValue");
            this.lblPitchControlValue.Name = "lblPitchControlValue";
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblAltitude
            // 
            resources.ApplyResources(this.lblAltitude, "lblAltitude");
            this.lblAltitude.Name = "lblAltitude";
            // 
            // lblSpeed
            // 
            resources.ApplyResources(this.lblSpeed, "lblSpeed");
            this.lblSpeed.Name = "lblSpeed";
            // 
            // lblPitch
            // 
            resources.ApplyResources(this.lblPitch, "lblPitch");
            this.lblPitch.Name = "lblPitch";
            // 
            // lblVerticalSpeed
            // 
            resources.ApplyResources(this.lblVerticalSpeed, "lblVerticalSpeed");
            this.lblVerticalSpeed.Name = "lblVerticalSpeed";
            // 
            // lblThrottle
            // 
            resources.ApplyResources(this.lblThrottle, "lblThrottle");
            this.lblThrottle.Name = "lblThrottle";
            // 
            // lblElevatorPitch
            // 
            resources.ApplyResources(this.lblElevatorPitch, "lblElevatorPitch");
            this.lblElevatorPitch.Name = "lblElevatorPitch";
            // 
            // lblJsonSendDisplay
            // 
            resources.ApplyResources(this.lblJsonSendDisplay, "lblJsonSendDisplay");
            this.lblJsonSendDisplay.Name = "lblJsonSendDisplay";
            // 
            // lblJsonRecivedDisplay
            // 
            resources.ApplyResources(this.lblJsonRecivedDisplay, "lblJsonRecivedDisplay");
            this.lblJsonRecivedDisplay.Name = "lblJsonRecivedDisplay";
            // 
            // dgvRecived
            // 
            resources.ApplyResources(this.dgvRecived, "dgvRecived");
            this.dgvRecived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecived.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Altitude,
            this.Speed,
            this.Pitch,
            this.VerticalSpeed,
            this.Throttle,
            this.ElevatorPitch,
            this.WarrningCode,
            this.TimeStamp});
            this.dgvRecived.Name = "dgvRecived";
            // 
            // Altitude
            // 
            resources.ApplyResources(this.Altitude, "Altitude");
            this.Altitude.Name = "Altitude";
            // 
            // Speed
            // 
            resources.ApplyResources(this.Speed, "Speed");
            this.Speed.Name = "Speed";
            // 
            // Pitch
            // 
            resources.ApplyResources(this.Pitch, "Pitch");
            this.Pitch.Name = "Pitch";
            // 
            // VerticalSpeed
            // 
            resources.ApplyResources(this.VerticalSpeed, "VerticalSpeed");
            this.VerticalSpeed.Name = "VerticalSpeed";
            // 
            // Throttle
            // 
            resources.ApplyResources(this.Throttle, "Throttle");
            this.Throttle.Name = "Throttle";
            // 
            // ElevatorPitch
            // 
            resources.ApplyResources(this.ElevatorPitch, "ElevatorPitch");
            this.ElevatorPitch.Name = "ElevatorPitch";
            // 
            // WarrningCode
            // 
            resources.ApplyResources(this.WarrningCode, "WarrningCode");
            this.WarrningCode.Name = "WarrningCode";
            // 
            // TimeStamp
            // 
            resources.ApplyResources(this.TimeStamp, "TimeStamp");
            this.TimeStamp.Name = "TimeStamp";
            // 
            // grbDataRecived
            // 
            this.grbDataRecived.Controls.Add(this.lblElevatorPitchVal);
            this.grbDataRecived.Controls.Add(this.lblThrottleVal);
            this.grbDataRecived.Controls.Add(this.lblVerticalSpeedVal);
            this.grbDataRecived.Controls.Add(this.lblPitchVal);
            this.grbDataRecived.Controls.Add(this.lblAltitudeVal);
            this.grbDataRecived.Controls.Add(this.lblSpeedVal);
            this.grbDataRecived.Controls.Add(this.lblVerticalSpeed);
            this.grbDataRecived.Controls.Add(this.lblThrottle);
            this.grbDataRecived.Controls.Add(this.lblElevatorPitch);
            this.grbDataRecived.Controls.Add(this.lblAltitude);
            this.grbDataRecived.Controls.Add(this.lblSpeed);
            this.grbDataRecived.Controls.Add(this.lblPitch);
            resources.ApplyResources(this.grbDataRecived, "grbDataRecived");
            this.grbDataRecived.Name = "grbDataRecived";
            this.grbDataRecived.TabStop = false;
            // 
            // lblElevatorPitchVal
            // 
            resources.ApplyResources(this.lblElevatorPitchVal, "lblElevatorPitchVal");
            this.lblElevatorPitchVal.Name = "lblElevatorPitchVal";
            // 
            // lblThrottleVal
            // 
            resources.ApplyResources(this.lblThrottleVal, "lblThrottleVal");
            this.lblThrottleVal.Name = "lblThrottleVal";
            // 
            // lblVerticalSpeedVal
            // 
            resources.ApplyResources(this.lblVerticalSpeedVal, "lblVerticalSpeedVal");
            this.lblVerticalSpeedVal.Name = "lblVerticalSpeedVal";
            // 
            // lblPitchVal
            // 
            resources.ApplyResources(this.lblPitchVal, "lblPitchVal");
            this.lblPitchVal.Name = "lblPitchVal";
            // 
            // lblAltitudeVal
            // 
            resources.ApplyResources(this.lblAltitudeVal, "lblAltitudeVal");
            this.lblAltitudeVal.Name = "lblAltitudeVal";
            // 
            // lblSpeedVal
            // 
            resources.ApplyResources(this.lblSpeedVal, "lblSpeedVal");
            this.lblSpeedVal.Name = "lblSpeedVal";
            // 
            // grbConnection
            // 
            this.grbConnection.Controls.Add(this.cmbIPAdress);
            this.grbConnection.Controls.Add(this.lblIP);
            this.grbConnection.Controls.Add(this.txtPort);
            this.grbConnection.Controls.Add(this.lblConnectionStatus);
            this.grbConnection.Controls.Add(this.lblPort);
            this.grbConnection.Controls.Add(this.btnConnect);
            resources.ApplyResources(this.grbConnection, "grbConnection");
            this.grbConnection.Name = "grbConnection";
            this.grbConnection.TabStop = false;
            // 
            // cmbIPAdress
            // 
            this.cmbIPAdress.FormattingEnabled = true;
            resources.ApplyResources(this.cmbIPAdress, "cmbIPAdress");
            this.cmbIPAdress.Name = "cmbIPAdress";
            // 
            // lblIP
            // 
            resources.ApplyResources(this.lblIP, "lblIP");
            this.lblIP.Name = "lblIP";
            // 
            // grbJsonSend
            // 
            this.grbJsonSend.Controls.Add(this.lblJsonSendDisplay);
            resources.ApplyResources(this.grbJsonSend, "grbJsonSend");
            this.grbJsonSend.Name = "grbJsonSend";
            this.grbJsonSend.TabStop = false;
            // 
            // grbJsonRecived
            // 
            this.grbJsonRecived.Controls.Add(this.lblJsonRecivedDisplay);
            resources.ApplyResources(this.grbJsonRecived, "grbJsonRecived");
            this.grbJsonRecived.Name = "grbJsonRecived";
            this.grbJsonRecived.TabStop = false;
            // 
            // grbControls
            // 
            this.grbControls.Controls.Add(this.lbl05Elevator);
            this.grbControls.Controls.Add(this.lbl5Elevator);
            this.grbControls.Controls.Add(this.lbl0throttle);
            this.grbControls.Controls.Add(this.lbl100throtle);
            this.grbControls.Controls.Add(this.trkElevatorPitch);
            this.grbControls.Controls.Add(this.trkThrottle);
            this.grbControls.Controls.Add(this.lblElevatorPitchControl);
            this.grbControls.Controls.Add(this.lblThtottleControl);
            this.grbControls.Controls.Add(this.lblThrottleControlValue);
            this.grbControls.Controls.Add(this.lblPitchControlValue);
            resources.ApplyResources(this.grbControls, "grbControls");
            this.grbControls.Name = "grbControls";
            this.grbControls.TabStop = false;
            // 
            // lbl05Elevator
            // 
            resources.ApplyResources(this.lbl05Elevator, "lbl05Elevator");
            this.lbl05Elevator.Name = "lbl05Elevator";
            // 
            // lbl5Elevator
            // 
            resources.ApplyResources(this.lbl5Elevator, "lbl5Elevator");
            this.lbl5Elevator.Name = "lbl5Elevator";
            // 
            // lbl0throttle
            // 
            resources.ApplyResources(this.lbl0throttle, "lbl0throttle");
            this.lbl0throttle.Name = "lbl0throttle";
            // 
            // lbl100throtle
            // 
            resources.ApplyResources(this.lbl100throtle, "lbl100throtle");
            this.lbl100throtle.Name = "lbl100throtle";
            // 
            // trkElevatorPitch
            // 
            resources.ApplyResources(this.trkElevatorPitch, "trkElevatorPitch");
            this.trkElevatorPitch.Maximum = 50;
            this.trkElevatorPitch.Minimum = -50;
            this.trkElevatorPitch.Name = "trkElevatorPitch";
            this.trkElevatorPitch.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkElevatorPitch.Scroll += new System.EventHandler(this.trkElevetorPitch_Scroll);
            // 
            // trkThrottle
            // 
            this.trkThrottle.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.trkThrottle, "trkThrottle");
            this.trkThrottle.LargeChange = 3;
            this.trkThrottle.Maximum = 100;
            this.trkThrottle.Name = "trkThrottle";
            this.trkThrottle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkThrottle.Scroll += new System.EventHandler(this.trkThrottle_Scroll);
            // 
            // lblElevatorPitchControl
            // 
            resources.ApplyResources(this.lblElevatorPitchControl, "lblElevatorPitchControl");
            this.lblElevatorPitchControl.Name = "lblElevatorPitchControl";
            // 
            // lblThtottleControl
            // 
            resources.ApplyResources(this.lblThtottleControl, "lblThtottleControl");
            this.lblThtottleControl.Name = "lblThtottleControl";
            // 
            // lblWarningDisplay
            // 
            resources.ApplyResources(this.lblWarningDisplay, "lblWarningDisplay");
            this.lblWarningDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblWarningDisplay.Name = "lblWarningDisplay";
            // 
            // grbWarnings
            // 
            this.grbWarnings.Controls.Add(this.lblWarningDisplay);
            resources.ApplyResources(this.grbWarnings, "grbWarnings");
            this.grbWarnings.Name = "grbWarnings";
            this.grbWarnings.TabStop = false;
            // 
            // grbAutomaticControls
            // 
            this.grbAutomaticControls.Controls.Add(this.lblAutoInfo);
            this.grbAutomaticControls.Controls.Add(this.btnAutoPilot);
            this.grbAutomaticControls.Controls.Add(this.lblAutoPilotAlt);
            this.grbAutomaticControls.Controls.Add(this.lblAutoPilotSpeed);
            this.grbAutomaticControls.Controls.Add(this.txtAltAutoPilot);
            this.grbAutomaticControls.Controls.Add(this.txtSpeedAutoPilot);
            this.grbAutomaticControls.Controls.Add(this.btnTakeOff);
            resources.ApplyResources(this.grbAutomaticControls, "grbAutomaticControls");
            this.grbAutomaticControls.Name = "grbAutomaticControls";
            this.grbAutomaticControls.TabStop = false;
            // 
            // lblAutoInfo
            // 
            resources.ApplyResources(this.lblAutoInfo, "lblAutoInfo");
            this.lblAutoInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAutoInfo.Name = "lblAutoInfo";
            // 
            // btnAutoPilot
            // 
            resources.ApplyResources(this.btnAutoPilot, "btnAutoPilot");
            this.btnAutoPilot.ForeColor = System.Drawing.Color.Green;
            this.btnAutoPilot.Name = "btnAutoPilot";
            this.btnAutoPilot.UseVisualStyleBackColor = true;
            this.btnAutoPilot.Click += new System.EventHandler(this.btnAutoPilot_Click);
            // 
            // lblAutoPilotAlt
            // 
            resources.ApplyResources(this.lblAutoPilotAlt, "lblAutoPilotAlt");
            this.lblAutoPilotAlt.Name = "lblAutoPilotAlt";
            // 
            // lblAutoPilotSpeed
            // 
            resources.ApplyResources(this.lblAutoPilotSpeed, "lblAutoPilotSpeed");
            this.lblAutoPilotSpeed.Name = "lblAutoPilotSpeed";
            // 
            // txtAltAutoPilot
            // 
            resources.ApplyResources(this.txtAltAutoPilot, "txtAltAutoPilot");
            this.txtAltAutoPilot.Name = "txtAltAutoPilot";
            // 
            // txtSpeedAutoPilot
            // 
            resources.ApplyResources(this.txtSpeedAutoPilot, "txtSpeedAutoPilot");
            this.txtSpeedAutoPilot.Name = "txtSpeedAutoPilot";
            // 
            // dgvSend
            // 
            this.dgvSend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            resources.ApplyResources(this.dgvSend, "dgvSend");
            this.dgvSend.Name = "dgvSend";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 140F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 140F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSend);
            this.Controls.Add(this.grbWarnings);
            this.Controls.Add(this.grbAutomaticControls);
            this.Controls.Add(this.grbControls);
            this.Controls.Add(this.grbJsonRecived);
            this.Controls.Add(this.grbJsonSend);
            this.Controls.Add(this.grbConnection);
            this.Controls.Add(this.dgvRecived);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbDataRecived);
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecived)).EndInit();
            this.grbDataRecived.ResumeLayout(false);
            this.grbDataRecived.PerformLayout();
            this.grbConnection.ResumeLayout(false);
            this.grbConnection.PerformLayout();
            this.grbJsonSend.ResumeLayout(false);
            this.grbJsonSend.PerformLayout();
            this.grbJsonRecived.ResumeLayout(false);
            this.grbJsonRecived.PerformLayout();
            this.grbControls.ResumeLayout(false);
            this.grbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevatorPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).EndInit();
            this.grbWarnings.ResumeLayout(false);
            this.grbWarnings.PerformLayout();
            this.grbAutomaticControls.ResumeLayout(false);
            this.grbAutomaticControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnTakeOff;
        private System.Windows.Forms.Label lblThrottleControlValue;
        private System.Windows.Forms.Label lblPitchControlValue;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label lblVerticalSpeed;
        private System.Windows.Forms.Label lblThrottle;
        private System.Windows.Forms.Label lblElevatorPitch;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblJsonSendDisplay;
        private System.Windows.Forms.Label lblJsonRecivedDisplay;
        private System.Windows.Forms.DataGridView dgvRecived;
        private System.Windows.Forms.GroupBox grbDataRecived;
        private System.Windows.Forms.GroupBox grbConnection;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.GroupBox grbJsonSend;
        private System.Windows.Forms.GroupBox grbJsonRecived;
        private System.Windows.Forms.GroupBox grbControls;
        private System.Windows.Forms.Label lblElevatorPitchControl;
        private System.Windows.Forms.Label lblThtottleControl;
        private System.Windows.Forms.TrackBar trkElevatorPitch;
        private System.Windows.Forms.TrackBar trkThrottle;
        private System.Windows.Forms.ComboBox cmbIPAdress;
        private System.Windows.Forms.Label lblWarningDisplay;
        private System.Windows.Forms.GroupBox grbWarnings;
        private System.Windows.Forms.GroupBox grbAutomaticControls;
        private System.Windows.Forms.DataGridView dgvSend;
        private System.Windows.Forms.Label lblSpeedVal;
        private System.Windows.Forms.Label lblAltitudeVal;
        private System.Windows.Forms.Label lblPitchVal;
        private System.Windows.Forms.Label lblVerticalSpeedVal;
        private System.Windows.Forms.Label lblThrottleVal;
        private System.Windows.Forms.Label lblElevatorPitchVal;
        private System.Windows.Forms.Label lbl0throttle;
        private System.Windows.Forms.Label lbl100throtle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lbl05Elevator;
        private System.Windows.Forms.Label lbl5Elevator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerticalSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Throttle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevatorPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrningCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.Button btnAutoPilot;
        private System.Windows.Forms.Label lblAutoPilotAlt;
        private System.Windows.Forms.Label lblAutoPilotSpeed;
        private System.Windows.Forms.TextBox txtAltAutoPilot;
        private System.Windows.Forms.TextBox txtSpeedAutoPilot;
        private System.Windows.Forms.Label lblAutoInfo;
    }
}

