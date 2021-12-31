using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SimpleTcp;
using System.Net;
using System.IO;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string hashString;
        string hashString2;
        SimpleTcpClient client;
      
        //Connection
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(txtIP.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            btnSend.Enabled = false;
        }

        //Server disconnected
        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server disconnected.{Environment.NewLine}";
            });
       
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                hashString2 = Encoding.UTF8.GetString(e.Data);
            });


          
        }

        //Server connected
        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server connected.{Environment.NewLine}";
            });
        }
        private void txtEncryptedMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        //Method that works if chkSHA256 is true
        private void chkSHA256_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSHA256.Checked == true)
            {
                chkSPN16.Checked = false;
            }
        }

        private void lblEncryptedMessageSHA256_Click(object sender, EventArgs e)
        {

        }

        private void txtEncryptedMessageSPN16_TextChanged(object sender, EventArgs e)
        {

        }
        //Method that works if chkSPN16 is true
        private void chkSPN16_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSPN16.Checked == true)
            {
                chkSHA256.Checked = false;
            }
        }
        //Decryption Method
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

        //Message and file sending method
        private void btnSend_Click(object sender, EventArgs e)
        {

            if (client.IsConnected)
            {
                //It works if the plain text entered is not empty and the key is entered.
                if (!string.IsNullOrEmpty(txtMessage.Text) && txtKey.Text == "password")
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
                            client.Send(txtHash.Text);

                            txtInfo.Text += $"Client: {txtHash.Text}{Environment.NewLine}";

                        }
                    }
                    else if (chkSHA256.Checked == true)
                    {
                        SHA sha = new SHA(txtMessage.Text);
                        txtHash.Text = sha.Encrypt();
                        client.Send(txtHash.Text);

                        txtInfo.Text += $"Client: {txtHash.Text}{Environment.NewLine}";
                    }
 
                }
          
            }
        }
    }
}
