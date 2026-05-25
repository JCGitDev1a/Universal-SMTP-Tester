namespace Universal_SMTP_Tester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSmtpHost = new TextBox();
            intSmtpPort = new TextBox();
            sendEmail = new Button();
            txtFriendlyName = new TextBox();
            txtFrom = new TextBox();
            lblFriendlyName = new Label();
            lblEmailAddress = new Label();
            lblHost = new Label();
            lblPort = new Label();
            boxProtocol = new GroupBox();
            btnStartTLS = new RadioButton();
            btnSSLDirect = new RadioButton();
            btnPlain = new RadioButton();
            chkSMTPAUTH = new CheckBox();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtBody = new RichTextBox();
            lblTo = new Label();
            lblSubject = new Label();
            lblCC = new Label();
            lblBCC = new Label();
            txtTo = new TextBox();
            txtSubject = new TextBox();
            txtCC = new TextBox();
            txtBCC = new TextBox();
            boxProtocol.SuspendLayout();
            SuspendLayout();
            // 
            // txtSmtpHost
            // 
            txtSmtpHost.Location = new Point(113, 152);
            txtSmtpHost.Name = "txtSmtpHost";
            txtSmtpHost.Size = new Size(123, 27);
            txtSmtpHost.TabIndex = 0;
            txtSmtpHost.Text = "SMTP Host";
            // 
            // intSmtpPort
            // 
            intSmtpPort.Location = new Point(515, 112);
            intSmtpPort.Name = "intSmtpPort";
            intSmtpPort.Size = new Size(53, 27);
            intSmtpPort.TabIndex = 1;
            intSmtpPort.Text = "25";
            // 
            // sendEmail
            // 
            sendEmail.Location = new Point(564, 302);
            sendEmail.Name = "sendEmail";
            sendEmail.Size = new Size(87, 28);
            sendEmail.TabIndex = 2;
            sendEmail.Text = "Send Email";
            sendEmail.UseVisualStyleBackColor = true;
            sendEmail.Click += sendEmail_Click;
            // 
            // txtFriendlyName
            // 
            txtFriendlyName.Location = new Point(133, 14);
            txtFriendlyName.Name = "txtFriendlyName";
            txtFriendlyName.Size = new Size(125, 27);
            txtFriendlyName.TabIndex = 3;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(417, 14);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(125, 27);
            txtFrom.TabIndex = 4;
            // 
            // lblFriendlyName
            // 
            lblFriendlyName.AutoSize = true;
            lblFriendlyName.Location = new Point(12, 17);
            lblFriendlyName.Name = "lblFriendlyName";
            lblFriendlyName.Size = new Size(105, 20);
            lblFriendlyName.TabIndex = 5;
            lblFriendlyName.Text = "Friendly Name";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(308, 17);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(103, 20);
            lblEmailAddress.TabIndex = 6;
            lblEmailAddress.Text = "Email Address";
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(21, 156);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(40, 20);
            lblHost.TabIndex = 7;
            lblHost.Text = "Host";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(453, 115);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(35, 20);
            lblPort.TabIndex = 8;
            lblPort.Text = "Port";
            // 
            // boxProtocol
            // 
            boxProtocol.Controls.Add(btnStartTLS);
            boxProtocol.Controls.Add(btnSSLDirect);
            boxProtocol.Controls.Add(btnPlain);
            boxProtocol.Location = new Point(32, 91);
            boxProtocol.Name = "boxProtocol";
            boxProtocol.Size = new Size(393, 48);
            boxProtocol.TabIndex = 9;
            boxProtocol.TabStop = false;
            boxProtocol.Text = "Protocol";
            // 
            // btnStartTLS
            // 
            btnStartTLS.AutoSize = true;
            btnStartTLS.Location = new Point(257, 15);
            btnStartTLS.Name = "btnStartTLS";
            btnStartTLS.Size = new Size(84, 24);
            btnStartTLS.TabIndex = 2;
            btnStartTLS.TabStop = true;
            btnStartTLS.Text = "StartTLS";
            btnStartTLS.UseVisualStyleBackColor = true;
            btnStartTLS.CheckedChanged += btnStartTLS_CheckedChanged;
            // 
            // btnSSLDirect
            // 
            btnSSLDirect.AutoSize = true;
            btnSSLDirect.Location = new Point(129, 18);
            btnSSLDirect.Name = "btnSSLDirect";
            btnSSLDirect.Size = new Size(97, 24);
            btnSSLDirect.TabIndex = 1;
            btnSSLDirect.TabStop = true;
            btnSSLDirect.Text = "SSL Direct";
            btnSSLDirect.UseVisualStyleBackColor = true;
            btnSSLDirect.CheckedChanged += btnSSLDirect_CheckedChanged;
            // 
            // btnPlain
            // 
            btnPlain.AutoSize = true;
            btnPlain.Checked = true;
            btnPlain.Location = new Point(6, 18);
            btnPlain.Name = "btnPlain";
            btnPlain.Size = new Size(93, 24);
            btnPlain.TabIndex = 0;
            btnPlain.TabStop = true;
            btnPlain.Text = "Plain Text";
            btnPlain.UseVisualStyleBackColor = true;
            btnPlain.CheckedChanged += btnPlain_CheckedChanged;
            // 
            // chkSMTPAUTH
            // 
            chkSMTPAUTH.AutoSize = true;
            chkSMTPAUTH.Location = new Point(394, 159);
            chkSMTPAUTH.Name = "chkSMTPAUTH";
            chkSMTPAUTH.Size = new Size(110, 24);
            chkSMTPAUTH.TabIndex = 10;
            chkSMTPAUTH.Text = "SMTP Auth?";
            chkSMTPAUTH.UseVisualStyleBackColor = true;
            chkSMTPAUTH.CheckedChanged += chkSMTPAUTH_CheckedChanged;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(113, 186);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 12;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(21, 193);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(289, 189);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(379, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 15;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(32, 315);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(470, 146);
            txtBody.TabIndex = 16;
            txtBody.Text = "";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(14, 226);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(25, 20);
            lblTo.TabIndex = 17;
            lblTo.Text = "To";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(19, 260);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(58, 20);
            lblSubject.TabIndex = 18;
            lblSubject.Text = "Subject";
            // 
            // lblCC
            // 
            lblCC.AutoSize = true;
            lblCC.Location = new Point(317, 226);
            lblCC.Name = "lblCC";
            lblCC.Size = new Size(27, 20);
            lblCC.TabIndex = 19;
            lblCC.Text = "CC";
            // 
            // lblBCC
            // 
            lblBCC.AutoSize = true;
            lblBCC.Location = new Point(315, 261);
            lblBCC.Name = "lblBCC";
            lblBCC.Size = new Size(36, 20);
            lblBCC.TabIndex = 20;
            lblBCC.Text = "BCC";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(51, 222);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(151, 27);
            txtTo.TabIndex = 21;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(83, 257);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(213, 27);
            txtSubject.TabIndex = 22;
            // 
            // txtCC
            // 
            txtCC.Location = new Point(362, 224);
            txtCC.Name = "txtCC";
            txtCC.Size = new Size(220, 27);
            txtCC.TabIndex = 23;
            // 
            // txtBCC
            // 
            txtBCC.Location = new Point(360, 260);
            txtBCC.Name = "txtBCC";
            txtBCC.Size = new Size(226, 27);
            txtBCC.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(txtBCC);
            Controls.Add(txtCC);
            Controls.Add(txtSubject);
            Controls.Add(txtTo);
            Controls.Add(lblBCC);
            Controls.Add(lblCC);
            Controls.Add(lblSubject);
            Controls.Add(lblTo);
            Controls.Add(txtBody);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(chkSMTPAUTH);
            Controls.Add(boxProtocol);
            Controls.Add(lblPort);
            Controls.Add(lblHost);
            Controls.Add(lblEmailAddress);
            Controls.Add(lblFriendlyName);
            Controls.Add(txtFrom);
            Controls.Add(txtFriendlyName);
            Controls.Add(sendEmail);
            Controls.Add(intSmtpPort);
            Controls.Add(txtSmtpHost);
            Name = "Form1";
            Text = "Universal SMTP Tester";
            boxProtocol.ResumeLayout(false);
            boxProtocol.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSmtpHost;
        private TextBox intSmtpPort;
        private Button sendEmail;
        private TextBox txtFriendlyName;
        private TextBox txtFrom;
        private Label lblFriendlyName;
        private Label lblEmailAddress;
        private Label lblHost;
        private Label lblPort;
        private GroupBox boxProtocol;
        private RadioButton btnStartTLS;
        private RadioButton btnSSLDirect;
        private RadioButton btnPlain;
        private CheckBox chkSMTPAUTH;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private RichTextBox txtBody;
        private Label lblTo;
        private Label lblSubject;
        private Label lblCC;
        private Label lblBCC;
        private TextBox txtTo;
        private TextBox txtSubject;
        private TextBox txtCC;
        private TextBox txtBCC;
    }
}
