
namespace TCPClient
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
            this.lblServer = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.lblHashAlgorithm = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnDecrypteMessage = new System.Windows.Forms.Button();
            this.chkSPN16 = new System.Windows.Forms.CheckBox();
            this.chkSHA256 = new System.Windows.Forms.CheckBox();
            this.txtEncryptedMessageSPN16 = new System.Windows.Forms.TextBox();
            this.lblEncryptedMessageSPN16 = new System.Windows.Forms.Label();
            this.txtEncryptedMessageSHA256 = new System.Windows.Forms.TextBox();
            this.lblEncryptedMessageSHA256 = new System.Windows.Forms.Label();
            this.lblDecryptedMessage = new System.Windows.Forms.Label();
            this.txtDecryptedMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(32, 31);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(54, 17);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(123, 31);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(419, 22);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(567, 28);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(448, 216);
            this.txtInfo.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(123, 129);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(419, 49);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(32, 129);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(69, 17);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(902, 278);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(113, 69);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(771, 278);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 69);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(123, 198);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(419, 49);
            this.txtHash.TabIndex = 7;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(32, 198);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(45, 17);
            this.lblHash.TabIndex = 8;
            this.lblHash.Text = "Hash:";
            // 
            // lblHashAlgorithm
            // 
            this.lblHashAlgorithm.AutoSize = true;
            this.lblHashAlgorithm.Location = new System.Drawing.Point(32, 281);
            this.lblHashAlgorithm.Name = "lblHashAlgorithm";
            this.lblHashAlgorithm.Size = new System.Drawing.Size(108, 17);
            this.lblHashAlgorithm.TabIndex = 9;
            this.lblHashAlgorithm.Text = "Hash Algorithm:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(123, 78);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(419, 22);
            this.txtKey.TabIndex = 11;
            this.txtKey.Text = "password";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(35, 78);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(36, 17);
            this.lblKey.TabIndex = 12;
            this.lblKey.Text = "Key:";
            // 
            // btnDecrypteMessage
            // 
            this.btnDecrypteMessage.Location = new System.Drawing.Point(771, 360);
            this.btnDecrypteMessage.Name = "btnDecrypteMessage";
            this.btnDecrypteMessage.Size = new System.Drawing.Size(244, 33);
            this.btnDecrypteMessage.TabIndex = 27;
            this.btnDecrypteMessage.Text = "Decrypte Message";
            this.btnDecrypteMessage.UseVisualStyleBackColor = true;
            this.btnDecrypteMessage.Click += new System.EventHandler(this.btnDecrypteMessage_Click);
            // 
            // chkSPN16
            // 
            this.chkSPN16.AutoSize = true;
            this.chkSPN16.Location = new System.Drawing.Point(159, 326);
            this.chkSPN16.Name = "chkSPN16";
            this.chkSPN16.Size = new System.Drawing.Size(79, 21);
            this.chkSPN16.TabIndex = 29;
            this.chkSPN16.Text = "SPN-16";
            this.chkSPN16.UseVisualStyleBackColor = true;
            this.chkSPN16.CheckedChanged += new System.EventHandler(this.chkSPN16_CheckedChanged);
            // 
            // chkSHA256
            // 
            this.chkSHA256.AutoSize = true;
            this.chkSHA256.Location = new System.Drawing.Point(159, 281);
            this.chkSHA256.Name = "chkSHA256";
            this.chkSHA256.Size = new System.Drawing.Size(87, 21);
            this.chkSHA256.TabIndex = 28;
            this.chkSHA256.Text = "SHA-256";
            this.chkSHA256.UseVisualStyleBackColor = true;
            this.chkSHA256.CheckedChanged += new System.EventHandler(this.chkSHA256_CheckedChanged);
            // 
            // txtEncryptedMessageSPN16
            // 
            this.txtEncryptedMessageSPN16.Location = new System.Drawing.Point(488, 324);
            this.txtEncryptedMessageSPN16.Name = "txtEncryptedMessageSPN16";
            this.txtEncryptedMessageSPN16.Size = new System.Drawing.Size(263, 22);
            this.txtEncryptedMessageSPN16.TabIndex = 35;
            this.txtEncryptedMessageSPN16.TextChanged += new System.EventHandler(this.txtEncryptedMessageSPN16_TextChanged);
            // 
            // lblEncryptedMessageSPN16
            // 
            this.lblEncryptedMessageSPN16.AutoSize = true;
            this.lblEncryptedMessageSPN16.Location = new System.Drawing.Point(275, 327);
            this.lblEncryptedMessageSPN16.Name = "lblEncryptedMessageSPN16";
            this.lblEncryptedMessageSPN16.Size = new System.Drawing.Size(185, 17);
            this.lblEncryptedMessageSPN16.TabIndex = 34;
            this.lblEncryptedMessageSPN16.Text = "Encrypted Message SPN16:";
            // 
            // txtEncryptedMessageSHA256
            // 
            this.txtEncryptedMessageSHA256.Location = new System.Drawing.Point(488, 279);
            this.txtEncryptedMessageSHA256.Name = "txtEncryptedMessageSHA256";
            this.txtEncryptedMessageSHA256.Size = new System.Drawing.Size(263, 22);
            this.txtEncryptedMessageSHA256.TabIndex = 33;
            // 
            // lblEncryptedMessageSHA256
            // 
            this.lblEncryptedMessageSHA256.AutoSize = true;
            this.lblEncryptedMessageSHA256.Location = new System.Drawing.Point(275, 282);
            this.lblEncryptedMessageSHA256.Name = "lblEncryptedMessageSHA256";
            this.lblEncryptedMessageSHA256.Size = new System.Drawing.Size(193, 17);
            this.lblEncryptedMessageSHA256.TabIndex = 32;
            this.lblEncryptedMessageSHA256.Text = "Encrypted Message SHA256:";
            this.lblEncryptedMessageSHA256.Click += new System.EventHandler(this.lblEncryptedMessageSHA256_Click);
            // 
            // lblDecryptedMessage
            // 
            this.lblDecryptedMessage.AutoSize = true;
            this.lblDecryptedMessage.Location = new System.Drawing.Point(275, 374);
            this.lblDecryptedMessage.Name = "lblDecryptedMessage";
            this.lblDecryptedMessage.Size = new System.Drawing.Size(138, 17);
            this.lblDecryptedMessage.TabIndex = 36;
            this.lblDecryptedMessage.Text = "Decrypted Message:";
            // 
            // txtDecryptedMessage
            // 
            this.txtDecryptedMessage.Location = new System.Drawing.Point(488, 371);
            this.txtDecryptedMessage.Name = "txtDecryptedMessage";
            this.txtDecryptedMessage.Size = new System.Drawing.Size(263, 22);
            this.txtDecryptedMessage.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 413);
            this.Controls.Add(this.txtDecryptedMessage);
            this.Controls.Add(this.lblDecryptedMessage);
            this.Controls.Add(this.txtEncryptedMessageSPN16);
            this.Controls.Add(this.lblEncryptedMessageSPN16);
            this.Controls.Add(this.txtEncryptedMessageSHA256);
            this.Controls.Add(this.lblEncryptedMessageSHA256);
            this.Controls.Add(this.chkSPN16);
            this.Controls.Add(this.chkSHA256);
            this.Controls.Add(this.btnDecrypteMessage);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblHashAlgorithm);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblServer);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.Label lblHashAlgorithm;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnDecrypteMessage;
        private System.Windows.Forms.CheckBox chkSPN16;
        private System.Windows.Forms.CheckBox chkSHA256;
        private System.Windows.Forms.TextBox txtEncryptedMessageSPN16;
        private System.Windows.Forms.Label lblEncryptedMessageSPN16;
        private System.Windows.Forms.TextBox txtEncryptedMessageSHA256;
        private System.Windows.Forms.Label lblEncryptedMessageSHA256;
        private System.Windows.Forms.Label lblDecryptedMessage;
        private System.Windows.Forms.TextBox txtDecryptedMessage;
    }
}

