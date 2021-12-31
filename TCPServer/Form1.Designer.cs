
namespace TCPServer
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lstClientIP = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHash = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.lblHashAlgorithm = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblEncryptedMessage = new System.Windows.Forms.Label();
            this.txtEncryptedMessage = new System.Windows.Forms.TextBox();
            this.btnDecrypteMessage = new System.Windows.Forms.Button();
            this.chkSHA256 = new System.Windows.Forms.CheckBox();
            this.chkSPN16 = new System.Windows.Forms.CheckBox();
            this.lblEncryptedMessageSPN16 = new System.Windows.Forms.Label();
            this.txtEncryptedMessageSPN16 = new System.Windows.Forms.TextBox();
            this.txtDecryptedMessage = new System.Windows.Forms.TextBox();
            this.lblDecryptedMessage = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(807, 337);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 57);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(927, 337);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 57);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(129, 134);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(369, 56);
            this.txtMessage.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Message:";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(526, 36);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(263, 261);
            this.txtInfo.TabIndex = 9;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(129, 36);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(369, 22);
            this.txtIP.TabIndex = 8;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(38, 36);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(54, 17);
            this.lblServer.TabIndex = 7;
            this.lblServer.Text = "Server:";
            // 
            // lstClientIP
            // 
            this.lstClientIP.FormattingEnabled = true;
            this.lstClientIP.IntegralHeight = false;
            this.lstClientIP.ItemHeight = 16;
            this.lstClientIP.Location = new System.Drawing.Point(807, 54);
            this.lstClientIP.Name = "lstClientIP";
            this.lstClientIP.Size = new System.Drawing.Size(233, 243);
            this.lstClientIP.TabIndex = 14;
            this.lstClientIP.SelectedIndexChanged += new System.EventHandler(this.lstClientIP_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Client IP:";
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(38, 212);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(45, 17);
            this.lblHash.TabIndex = 17;
            this.lblHash.Text = "Hash:";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(129, 209);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(369, 89);
            this.txtHash.TabIndex = 16;
            // 
            // lblHashAlgorithm
            // 
            this.lblHashAlgorithm.AutoSize = true;
            this.lblHashAlgorithm.Location = new System.Drawing.Point(38, 337);
            this.lblHashAlgorithm.Name = "lblHashAlgorithm";
            this.lblHashAlgorithm.Size = new System.Drawing.Size(108, 17);
            this.lblHashAlgorithm.TabIndex = 18;
            this.lblHashAlgorithm.Text = "Hash Algorithm:";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(38, 81);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(36, 17);
            this.lblKey.TabIndex = 21;
            this.lblKey.Text = "Key:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(129, 81);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(369, 22);
            this.txtKey.TabIndex = 20;
            this.txtKey.Text = "password";
            // 
            // lblEncryptedMessage
            // 
            this.lblEncryptedMessage.AutoSize = true;
            this.lblEncryptedMessage.Location = new System.Drawing.Point(305, 337);
            this.lblEncryptedMessage.Name = "lblEncryptedMessage";
            this.lblEncryptedMessage.Size = new System.Drawing.Size(193, 17);
            this.lblEncryptedMessage.TabIndex = 22;
            this.lblEncryptedMessage.Text = "Encrypted Message SHA256:";
            this.lblEncryptedMessage.Click += new System.EventHandler(this.lblEncryptedMessage_Click);
            // 
            // txtEncryptedMessage
            // 
            this.txtEncryptedMessage.Location = new System.Drawing.Point(526, 337);
            this.txtEncryptedMessage.Name = "txtEncryptedMessage";
            this.txtEncryptedMessage.Size = new System.Drawing.Size(263, 22);
            this.txtEncryptedMessage.TabIndex = 23;
            // 
            // btnDecrypteMessage
            // 
            this.btnDecrypteMessage.Location = new System.Drawing.Point(807, 400);
            this.btnDecrypteMessage.Name = "btnDecrypteMessage";
            this.btnDecrypteMessage.Size = new System.Drawing.Size(233, 31);
            this.btnDecrypteMessage.TabIndex = 24;
            this.btnDecrypteMessage.Text = "Decrypte Message";
            this.btnDecrypteMessage.UseVisualStyleBackColor = true;
            this.btnDecrypteMessage.Click += new System.EventHandler(this.btnDecrypteMessage_Click);
            // 
            // chkSHA256
            // 
            this.chkSHA256.AutoSize = true;
            this.chkSHA256.Location = new System.Drawing.Point(173, 337);
            this.chkSHA256.Name = "chkSHA256";
            this.chkSHA256.Size = new System.Drawing.Size(87, 21);
            this.chkSHA256.TabIndex = 25;
            this.chkSHA256.Text = "SHA-256";
            this.chkSHA256.UseVisualStyleBackColor = true;
            this.chkSHA256.CheckedChanged += new System.EventHandler(this.chkSHA256_CheckedChanged);
            // 
            // chkSPN16
            // 
            this.chkSPN16.AutoSize = true;
            this.chkSPN16.Location = new System.Drawing.Point(173, 371);
            this.chkSPN16.Name = "chkSPN16";
            this.chkSPN16.Size = new System.Drawing.Size(79, 21);
            this.chkSPN16.TabIndex = 26;
            this.chkSPN16.Text = "SPN-16";
            this.chkSPN16.UseVisualStyleBackColor = true;
            this.chkSPN16.CheckedChanged += new System.EventHandler(this.chkSPN16_CheckedChanged);
            // 
            // lblEncryptedMessageSPN16
            // 
            this.lblEncryptedMessageSPN16.AutoSize = true;
            this.lblEncryptedMessageSPN16.Location = new System.Drawing.Point(305, 372);
            this.lblEncryptedMessageSPN16.Name = "lblEncryptedMessageSPN16";
            this.lblEncryptedMessageSPN16.Size = new System.Drawing.Size(185, 17);
            this.lblEncryptedMessageSPN16.TabIndex = 27;
            this.lblEncryptedMessageSPN16.Text = "Encrypted Message SPN16:";
            // 
            // txtEncryptedMessageSPN16
            // 
            this.txtEncryptedMessageSPN16.Location = new System.Drawing.Point(526, 372);
            this.txtEncryptedMessageSPN16.Name = "txtEncryptedMessageSPN16";
            this.txtEncryptedMessageSPN16.Size = new System.Drawing.Size(263, 22);
            this.txtEncryptedMessageSPN16.TabIndex = 28;
            // 
            // txtDecryptedMessage
            // 
            this.txtDecryptedMessage.Location = new System.Drawing.Point(526, 409);
            this.txtDecryptedMessage.Name = "txtDecryptedMessage";
            this.txtDecryptedMessage.Size = new System.Drawing.Size(263, 22);
            this.txtDecryptedMessage.TabIndex = 39;
            // 
            // lblDecryptedMessage
            // 
            this.lblDecryptedMessage.AutoSize = true;
            this.lblDecryptedMessage.Location = new System.Drawing.Point(305, 409);
            this.lblDecryptedMessage.Name = "lblDecryptedMessage";
            this.lblDecryptedMessage.Size = new System.Drawing.Size(138, 17);
            this.lblDecryptedMessage.TabIndex = 38;
            this.lblDecryptedMessage.Text = "Decrypted Message:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 465);
            this.Controls.Add(this.txtDecryptedMessage);
            this.Controls.Add(this.lblDecryptedMessage);
            this.Controls.Add(this.txtEncryptedMessageSPN16);
            this.Controls.Add(this.lblEncryptedMessageSPN16);
            this.Controls.Add(this.chkSPN16);
            this.Controls.Add(this.chkSHA256);
            this.Controls.Add(this.btnDecrypteMessage);
            this.Controls.Add(this.txtEncryptedMessage);
            this.Controls.Add(this.lblEncryptedMessage);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblHashAlgorithm);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstClientIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblServer);
            this.Name = "Form1";
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ListBox lstClientIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label lblHashAlgorithm;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblEncryptedMessage;
        private System.Windows.Forms.TextBox txtEncryptedMessage;
        private System.Windows.Forms.Button btnDecrypteMessage;
        private System.Windows.Forms.CheckBox chkSHA256;
        private System.Windows.Forms.CheckBox chkSPN16;
        private System.Windows.Forms.Label lblEncryptedMessageSPN16;
        private System.Windows.Forms.TextBox txtEncryptedMessageSPN16;
        private System.Windows.Forms.TextBox txtDecryptedMessage;
        private System.Windows.Forms.Label lblDecryptedMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

