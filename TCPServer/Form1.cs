using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string hashString2;
        SimpleTcpServer server;

        //Server starting
        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            txtInfo.Text += $"Starting...{Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} :{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                hashString2 = Encoding.UTF8.GetString(e.Data);
            });
        }

        //Client disconnect
        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                lstClientIP.Items.Remove(e.IpPort);
            });
        }

        //Client connect
        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                lstClientIP.Items.Add(e.IpPort);
            });
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                //It works if the plain text entered is not blank and the user is selected.
                if (!string.IsNullOrEmpty(txtMessage.Text) && lstClientIP.SelectedItem != null)
                {
                    //string cipherValue;
                    if (chkSPN16.Checked == true)
                    {
                        if (txtMessage.Text.Length % 2 == 1)
                        {
                            txtMessage.Text += " ";
                        }
                        else
                        {
                            SPN spn = new SPN(txtMessage.Text, txtKey.Text);
                            txtHash.Text = spn.Encrypt();
                            server.Send(lstClientIP.SelectedItem.ToString(), txtHash.Text);

                            txtInfo.Text += $"Server: {txtHash.Text}{Environment.NewLine}";

                        }

                    }
                    else if (chkSHA256.Checked == true)
                    {
                        SHA sha = new SHA(txtMessage.Text);
                        txtHash.Text = sha.Encrypt();
                        server.Send(lstClientIP.SelectedItem.ToString(), txtHash.Text);

                        txtInfo.Text += $"Server: {txtHash.Text}{Environment.NewLine}";
                    }
                }
            }
        }

        //Method that works if chkSPN16 is true
        private void chkSPN16_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSPN16.Checked == true)
            {
                chkSHA256.Checked = false;
            }
        }
        //Method that works if chkSHA256 is true
        private void chkSHA256_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSHA256.Checked == true)
            {
                chkSPN16.Checked = false;
            }
        }

        private void lblEncryptedMessage_Click(object sender, EventArgs e)
        {

        }

        //Decryption method
        private void btnDecrypteMessage_Click(object sender, EventArgs e)
        {
            if (chkSPN16.Checked == true)
            {
                SPN spn = new SPN(txtKey.Text);
                txtEncryptedMessageSPN16.Text = hashString2;
                txtDecryptedMessage.Text = spn.Decrypt(txtEncryptedMessageSPN16.Text);
            }
            else if (chkSHA256.Checked == true)
            {
                MessageBox.Show("SHA cannot be decrypted. ");
            }
        }

     


        private void lstClientIP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

    }
}
