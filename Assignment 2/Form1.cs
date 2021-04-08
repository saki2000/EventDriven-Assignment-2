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

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        TcpClient client;
        Thread listeningThread = null;

        public Form1()
        {
            InitializeComponent();
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
            IPAddress ip = IPAddress.Parse(txtIpAdress.Text);
            int port = int.Parse(txtPort.Text);
            client.Connect(ip, port);
            //
            //Display information about connection and enables buttons
            //
            MessageBox.Show("Connected to: " + txtIpAdress.Text);

            listeningThread = new Thread(new ThreadStart(Listen));
            listeningThread.Start();
        }
        private void Listen()
        {

        }
    }
}
