
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnTakeOff = new System.Windows.Forms.Button();
            this.lblThrottleControlValue = new System.Windows.Forms.Label();
            this.lblPitchControlValue = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lblVerticalSpeed = new System.Windows.Forms.Label();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.lblElevetorPitch = new System.Windows.Forms.Label();
            this.lblJsonSendDisplay = new System.Windows.Forms.Label();
            this.lblJsonRecivedDisplay = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbDataRecived = new System.Windows.Forms.GroupBox();
            this.grbConnection = new System.Windows.Forms.GroupBox();
            this.cmbIPAdress = new System.Windows.Forms.ComboBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.grbJsonSend = new System.Windows.Forms.GroupBox();
            this.grbJsonRecived = new System.Windows.Forms.GroupBox();
            this.grbControls = new System.Windows.Forms.GroupBox();
            this.trkElevetorPitch = new System.Windows.Forms.TrackBar();
            this.trkThrottle = new System.Windows.Forms.TrackBar();
            this.lblElevatorPitchControl = new System.Windows.Forms.Label();
            this.lblThtottleControl = new System.Windows.Forms.Label();
            this.lblWarningDisplay = new System.Windows.Forms.Label();
            this.grbWarnings = new System.Windows.Forms.GroupBox();
            this.Altitiude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerticalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Throttle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevetorPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrningCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbDataRecived.SuspendLayout();
            this.grbConnection.SuspendLayout();
            this.grbJsonSend.SuspendLayout();
            this.grbJsonRecived.SuspendLayout();
            this.grbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevetorPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).BeginInit();
            this.grbWarnings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1256, 545);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 97);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(90, 58);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(121, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "9999";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(6, 58);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(6, 93);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(166, 13);
            this.lblConnectionStatus.TabIndex = 4;
            this.lblConnectionStatus.Text = "Connection Status: Disconnected";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(41, 282);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnTakeOff
            // 
            this.btnTakeOff.Enabled = false;
            this.btnTakeOff.Location = new System.Drawing.Point(266, 282);
            this.btnTakeOff.Name = "btnTakeOff";
            this.btnTakeOff.Size = new System.Drawing.Size(75, 23);
            this.btnTakeOff.TabIndex = 6;
            this.btnTakeOff.Text = "Take OFF";
            this.btnTakeOff.UseVisualStyleBackColor = true;
            // 
            // lblThrottleControlValue
            // 
            this.lblThrottleControlValue.AutoSize = true;
            this.lblThrottleControlValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrottleControlValue.Location = new System.Drawing.Point(128, 141);
            this.lblThrottleControlValue.Name = "lblThrottleControlValue";
            this.lblThrottleControlValue.Size = new System.Drawing.Size(19, 20);
            this.lblThrottleControlValue.TabIndex = 7;
            this.lblThrottleControlValue.Text = "0";
            // 
            // lblPitchControlValue
            // 
            this.lblPitchControlValue.AutoSize = true;
            this.lblPitchControlValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitchControlValue.Location = new System.Drawing.Point(359, 141);
            this.lblPitchControlValue.Name = "lblPitchControlValue";
            this.lblPitchControlValue.Size = new System.Drawing.Size(19, 20);
            this.lblPitchControlValue.TabIndex = 8;
            this.lblPitchControlValue.Text = "0";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(249, 58);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitude.Location = new System.Drawing.Point(6, 24);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(52, 16);
            this.lblAltitude.TabIndex = 12;
            this.lblAltitude.Text = "Altitude";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(6, 50);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(49, 16);
            this.lblSpeed.TabIndex = 13;
            this.lblSpeed.Text = "Speed";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitch.Location = new System.Drawing.Point(6, 76);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(37, 16);
            this.lblPitch.TabIndex = 14;
            this.lblPitch.Text = "Pitch";
            // 
            // lblVerticalSpeed
            // 
            this.lblVerticalSpeed.AutoSize = true;
            this.lblVerticalSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerticalSpeed.Location = new System.Drawing.Point(196, 24);
            this.lblVerticalSpeed.Name = "lblVerticalSpeed";
            this.lblVerticalSpeed.Size = new System.Drawing.Size(97, 16);
            this.lblVerticalSpeed.TabIndex = 15;
            this.lblVerticalSpeed.Text = "Vertical Speed";
            // 
            // lblThrottle
            // 
            this.lblThrottle.AutoSize = true;
            this.lblThrottle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrottle.Location = new System.Drawing.Point(196, 50);
            this.lblThrottle.Name = "lblThrottle";
            this.lblThrottle.Size = new System.Drawing.Size(53, 16);
            this.lblThrottle.TabIndex = 16;
            this.lblThrottle.Text = "Throttle";
            // 
            // lblElevetorPitch
            // 
            this.lblElevetorPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevetorPitch.Location = new System.Drawing.Point(196, 76);
            this.lblElevetorPitch.Name = "lblElevetorPitch";
            this.lblElevetorPitch.Size = new System.Drawing.Size(101, 18);
            this.lblElevetorPitch.TabIndex = 17;
            this.lblElevetorPitch.Text = "Elevetor Pitch";
            // 
            // lblJsonSendDisplay
            // 
            this.lblJsonSendDisplay.AutoSize = true;
            this.lblJsonSendDisplay.Location = new System.Drawing.Point(6, 26);
            this.lblJsonSendDisplay.Name = "lblJsonSendDisplay";
            this.lblJsonSendDisplay.Size = new System.Drawing.Size(10, 13);
            this.lblJsonSendDisplay.TabIndex = 20;
            this.lblJsonSendDisplay.Text = "-";
            // 
            // lblJsonRecivedDisplay
            // 
            this.lblJsonRecivedDisplay.AutoSize = true;
            this.lblJsonRecivedDisplay.Location = new System.Drawing.Point(6, 28);
            this.lblJsonRecivedDisplay.Name = "lblJsonRecivedDisplay";
            this.lblJsonRecivedDisplay.Size = new System.Drawing.Size(10, 13);
            this.lblJsonRecivedDisplay.TabIndex = 21;
            this.lblJsonRecivedDisplay.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Altitiude,
            this.Speed,
            this.Pitch,
            this.VerticalSpeed,
            this.Throttle,
            this.ElevetorPitch,
            this.WarrningCode,
            this.TimeStamp});
            this.dataGridView1.Location = new System.Drawing.Point(455, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 479);
            this.dataGridView1.TabIndex = 22;
            // 
            // grbDataRecived
            // 
            this.grbDataRecived.Controls.Add(this.lblVerticalSpeed);
            this.grbDataRecived.Controls.Add(this.lblThrottle);
            this.grbDataRecived.Controls.Add(this.lblElevetorPitch);
            this.grbDataRecived.Controls.Add(this.lblAltitude);
            this.grbDataRecived.Controls.Add(this.lblSpeed);
            this.grbDataRecived.Controls.Add(this.lblPitch);
            this.grbDataRecived.Location = new System.Drawing.Point(12, 163);
            this.grbDataRecived.Name = "grbDataRecived";
            this.grbDataRecived.Size = new System.Drawing.Size(436, 108);
            this.grbDataRecived.TabIndex = 23;
            this.grbDataRecived.TabStop = false;
            this.grbDataRecived.Text = "Data Recived";
            // 
            // grbConnection
            // 
            this.grbConnection.Controls.Add(this.cmbIPAdress);
            this.grbConnection.Controls.Add(this.lblIP);
            this.grbConnection.Controls.Add(this.txtPort);
            this.grbConnection.Controls.Add(this.lblConnectionStatus);
            this.grbConnection.Controls.Add(this.lblPort);
            this.grbConnection.Controls.Add(this.btnConnect);
            this.grbConnection.Location = new System.Drawing.Point(12, 11);
            this.grbConnection.Name = "grbConnection";
            this.grbConnection.Size = new System.Drawing.Size(330, 126);
            this.grbConnection.TabIndex = 24;
            this.grbConnection.TabStop = false;
            this.grbConnection.Text = "Connection";
            // 
            // cmbIPAdress
            // 
            this.cmbIPAdress.FormattingEnabled = true;
            this.cmbIPAdress.Location = new System.Drawing.Point(90, 16);
            this.cmbIPAdress.Name = "cmbIPAdress";
            this.cmbIPAdress.Size = new System.Drawing.Size(121, 21);
            this.cmbIPAdress.TabIndex = 10;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(6, 24);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(52, 13);
            this.lblIP.TabIndex = 5;
            this.lblIP.Text = "IP Adress";
            // 
            // grbJsonSend
            // 
            this.grbJsonSend.Controls.Add(this.lblJsonSendDisplay);
            this.grbJsonSend.Location = new System.Drawing.Point(348, 81);
            this.grbJsonSend.Name = "grbJsonSend";
            this.grbJsonSend.Size = new System.Drawing.Size(863, 56);
            this.grbJsonSend.TabIndex = 25;
            this.grbJsonSend.TabStop = false;
            this.grbJsonSend.Text = "JSON Send";
            // 
            // grbJsonRecived
            // 
            this.grbJsonRecived.Controls.Add(this.lblJsonRecivedDisplay);
            this.grbJsonRecived.Location = new System.Drawing.Point(348, 19);
            this.grbJsonRecived.Name = "grbJsonRecived";
            this.grbJsonRecived.Size = new System.Drawing.Size(863, 56);
            this.grbJsonRecived.TabIndex = 26;
            this.grbJsonRecived.TabStop = false;
            this.grbJsonRecived.Text = "JSON Recived";
            // 
            // grbControls
            // 
            this.grbControls.Controls.Add(this.trkElevetorPitch);
            this.grbControls.Controls.Add(this.trkThrottle);
            this.grbControls.Controls.Add(this.lblElevatorPitchControl);
            this.grbControls.Controls.Add(this.lblThtottleControl);
            this.grbControls.Controls.Add(this.btnTakeOff);
            this.grbControls.Controls.Add(this.btnSend);
            this.grbControls.Controls.Add(this.lblThrottleControlValue);
            this.grbControls.Controls.Add(this.lblPitchControlValue);
            this.grbControls.Location = new System.Drawing.Point(12, 304);
            this.grbControls.Name = "grbControls";
            this.grbControls.Size = new System.Drawing.Size(436, 338);
            this.grbControls.TabIndex = 27;
            this.grbControls.TabStop = false;
            this.grbControls.Text = "Controls";
            // 
            // trkElevetorPitch
            // 
            this.trkElevetorPitch.Enabled = false;
            this.trkElevetorPitch.Location = new System.Drawing.Point(284, 52);
            this.trkElevetorPitch.Maximum = 50;
            this.trkElevetorPitch.Minimum = -50;
            this.trkElevetorPitch.Name = "trkElevetorPitch";
            this.trkElevetorPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkElevetorPitch.Size = new System.Drawing.Size(45, 214);
            this.trkElevetorPitch.TabIndex = 12;
            this.trkElevetorPitch.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkElevetorPitch.Scroll += new System.EventHandler(this.trkElevetorPitch_Scroll);
            // 
            // trkThrottle
            // 
            this.trkThrottle.Cursor = System.Windows.Forms.Cursors.Default;
            this.trkThrottle.Enabled = false;
            this.trkThrottle.LargeChange = 3;
            this.trkThrottle.Location = new System.Drawing.Point(57, 52);
            this.trkThrottle.Maximum = 100;
            this.trkThrottle.Name = "trkThrottle";
            this.trkThrottle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThrottle.Size = new System.Drawing.Size(45, 214);
            this.trkThrottle.TabIndex = 11;
            this.trkThrottle.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkThrottle.Scroll += new System.EventHandler(this.trkThrottle_Scroll);
            // 
            // lblElevatorPitchControl
            // 
            this.lblElevatorPitchControl.AutoSize = true;
            this.lblElevatorPitchControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevatorPitchControl.Location = new System.Drawing.Point(254, 29);
            this.lblElevatorPitchControl.Name = "lblElevatorPitchControl";
            this.lblElevatorPitchControl.Size = new System.Drawing.Size(106, 20);
            this.lblElevatorPitchControl.TabIndex = 10;
            this.lblElevatorPitchControl.Text = "Elevetor Pitch";
            // 
            // lblThtottleControl
            // 
            this.lblThtottleControl.AutoSize = true;
            this.lblThtottleControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThtottleControl.Location = new System.Drawing.Point(53, 29);
            this.lblThtottleControl.Name = "lblThtottleControl";
            this.lblThtottleControl.Size = new System.Drawing.Size(63, 20);
            this.lblThtottleControl.TabIndex = 9;
            this.lblThtottleControl.Text = "Throttle";
            // 
            // lblWarningDisplay
            // 
            this.lblWarningDisplay.AutoSize = true;
            this.lblWarningDisplay.Enabled = false;
            this.lblWarningDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblWarningDisplay.Location = new System.Drawing.Point(6, 41);
            this.lblWarningDisplay.Name = "lblWarningDisplay";
            this.lblWarningDisplay.Size = new System.Drawing.Size(0, 25);
            this.lblWarningDisplay.TabIndex = 28;
            // 
            // grbWarnings
            // 
            this.grbWarnings.Controls.Add(this.lblWarningDisplay);
            this.grbWarnings.Location = new System.Drawing.Point(1189, 163);
            this.grbWarnings.Name = "grbWarnings";
            this.grbWarnings.Size = new System.Drawing.Size(182, 100);
            this.grbWarnings.TabIndex = 29;
            this.grbWarnings.TabStop = false;
            this.grbWarnings.Text = "WARNINGS";
            // 
            // Altitiude
            // 
            this.Altitiude.HeaderText = "Altitiude";
            this.Altitiude.Name = "Altitiude";
            this.Altitiude.Width = 80;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            this.Speed.Width = 80;
            // 
            // Pitch
            // 
            this.Pitch.HeaderText = "Pitch";
            this.Pitch.Name = "Pitch";
            this.Pitch.Width = 80;
            // 
            // VerticalSpeed
            // 
            this.VerticalSpeed.HeaderText = "Vertical Speed";
            this.VerticalSpeed.Name = "VerticalSpeed";
            this.VerticalSpeed.Width = 80;
            // 
            // Throttle
            // 
            this.Throttle.HeaderText = "Throttle";
            this.Throttle.Name = "Throttle";
            this.Throttle.Width = 80;
            // 
            // ElevetorPitch
            // 
            this.ElevetorPitch.HeaderText = "Elevetor Pitch";
            this.ElevetorPitch.Name = "ElevetorPitch";
            this.ElevetorPitch.Width = 80;
            // 
            // WarrningCode
            // 
            this.WarrningCode.HeaderText = "Warrning Code";
            this.WarrningCode.Name = "WarrningCode";
            this.WarrningCode.Width = 80;
            // 
            // TimeStamp
            // 
            this.TimeStamp.HeaderText = "Time Stamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 647);
            this.ControlBox = false;
            this.Controls.Add(this.grbWarnings);
            this.Controls.Add(this.grbControls);
            this.Controls.Add(this.grbJsonRecived);
            this.Controls.Add(this.grbJsonSend);
            this.Controls.Add(this.grbConnection);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbDataRecived);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.trkElevetorPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).EndInit();
            this.grbWarnings.ResumeLayout(false);
            this.grbWarnings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnTakeOff;
        private System.Windows.Forms.Label lblThrottleControlValue;
        private System.Windows.Forms.Label lblPitchControlValue;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label lblVerticalSpeed;
        private System.Windows.Forms.Label lblThrottle;
        private System.Windows.Forms.Label lblElevetorPitch;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblJsonSendDisplay;
        private System.Windows.Forms.Label lblJsonRecivedDisplay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbDataRecived;
        private System.Windows.Forms.GroupBox grbConnection;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.GroupBox grbJsonSend;
        private System.Windows.Forms.GroupBox grbJsonRecived;
        private System.Windows.Forms.GroupBox grbControls;
        private System.Windows.Forms.Label lblElevatorPitchControl;
        private System.Windows.Forms.Label lblThtottleControl;
        private System.Windows.Forms.TrackBar trkElevetorPitch;
        private System.Windows.Forms.TrackBar trkThrottle;
        private System.Windows.Forms.ComboBox cmbIPAdress;
        private System.Windows.Forms.Label lblWarningDisplay;
        private System.Windows.Forms.GroupBox grbWarnings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitiude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerticalSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Throttle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevetorPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrningCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
    }
}

