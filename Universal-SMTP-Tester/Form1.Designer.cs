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
            chkIgnoreSslCertificateErrors = new CheckBox();
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
            groupMessageFormat = new GroupBox();
            tableMessageFormat = new TableLayoutPanel();
            lblTransferEncoding = new Label();
            clbTransferEncoding = new CheckedListBox();
            lblMimeBodyEncoding = new Label();
            clbMimeBodyEncoding = new CheckedListBox();
            lblCharacterEncoding = new Label();
            clbCharacterEncoding = new CheckedListBox();
            lblHeaderEncoding = new Label();
            clbHeaderEncoding = new CheckedListBox();
            lblGeneratedTestEmails = new Label();
            btnPreviewCombinations = new Button();
            boxProtocol.SuspendLayout();
            groupMessageFormat.SuspendLayout();
            tableMessageFormat.SuspendLayout();
            SuspendLayout();
            // 
            // txtSmtpHost
            // 
            txtSmtpHost.Location = new Point(113, 152);
            txtSmtpHost.Name = "txtSmtpHost";
            txtSmtpHost.Size = new Size(123, 27);
            txtSmtpHost.TabIndex = 5;
            txtSmtpHost.Text = "SMTP Host";
            // 
            // intSmtpPort
            // 
            intSmtpPort.Location = new Point(515, 112);
            intSmtpPort.Name = "intSmtpPort";
            intSmtpPort.Size = new Size(53, 27);
            intSmtpPort.TabIndex = 3;
            intSmtpPort.Text = "25";
            // 
            // sendEmail
            // 
            sendEmail.Location = new Point(557, 498);
            sendEmail.Name = "sendEmail";
            sendEmail.Size = new Size(87, 28);
            sendEmail.TabIndex = 15;
            sendEmail.Text = "&Send Email";
            sendEmail.UseVisualStyleBackColor = true;
            sendEmail.Click += sendEmail_Click;
            // 
            // txtFriendlyName
            // 
            txtFriendlyName.Location = new Point(133, 14);
            txtFriendlyName.Name = "txtFriendlyName";
            txtFriendlyName.Size = new Size(125, 27);
            txtFriendlyName.TabIndex = 0;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(417, 14);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(125, 27);
            txtFrom.TabIndex = 1;
            // 
            // lblFriendlyName
            // 
            lblFriendlyName.AutoSize = true;
            lblFriendlyName.Location = new Point(12, 17);
            lblFriendlyName.Name = "lblFriendlyName";
            lblFriendlyName.Size = new Size(105, 20);
            lblFriendlyName.TabIndex = 23;
            lblFriendlyName.Text = "Friendly Name";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(308, 17);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(103, 20);
            lblEmailAddress.TabIndex = 22;
            lblEmailAddress.Text = "Email Address";
            // 
            // lblHost
            // 
            lblHost.AutoSize = true;
            lblHost.Location = new Point(21, 156);
            lblHost.Name = "lblHost";
            lblHost.Size = new Size(40, 20);
            lblHost.TabIndex = 21;
            lblHost.Text = "Host";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(453, 115);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(35, 20);
            lblPort.TabIndex = 20;
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
            boxProtocol.TabIndex = 2;
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
            chkSMTPAUTH.Location = new Point(392, 155);
            chkSMTPAUTH.Name = "chkSMTPAUTH";
            chkSMTPAUTH.Size = new Size(110, 24);
            chkSMTPAUTH.TabIndex = 6;
            chkSMTPAUTH.Text = "SMTP Auth?";
            chkSMTPAUTH.UseVisualStyleBackColor = true;
            chkSMTPAUTH.CheckedChanged += chkSMTPAUTH_CheckedChanged;
            // 
            // chkIgnoreSslCertificateErrors
            // 
            chkIgnoreSslCertificateErrors.AutoSize = true;
            chkIgnoreSslCertificateErrors.Location = new Point(592, 115);
            chkIgnoreSslCertificateErrors.Name = "chkIgnoreSslCertificateErrors";
            chkIgnoreSslCertificateErrors.Size = new Size(172, 24);
            chkIgnoreSslCertificateErrors.TabIndex = 4;
            chkIgnoreSslCertificateErrors.Text = "Ignore SSL cert errors";
            chkIgnoreSslCertificateErrors.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(113, 186);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(21, 193);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 19;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(289, 189);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(379, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(32, 315);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(470, 146);
            txtBody.TabIndex = 14;
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
            lblSubject.TabIndex = 16;
            lblSubject.Text = "Subject";
            // 
            // lblCC
            // 
            lblCC.AutoSize = true;
            lblCC.Location = new Point(317, 226);
            lblCC.Name = "lblCC";
            lblCC.Size = new Size(27, 20);
            lblCC.TabIndex = 15;
            lblCC.Text = "CC";
            // 
            // lblBCC
            // 
            lblBCC.AutoSize = true;
            lblBCC.Location = new Point(315, 261);
            lblBCC.Name = "lblBCC";
            lblBCC.Size = new Size(36, 20);
            lblBCC.TabIndex = 14;
            lblBCC.Text = "BCC";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(51, 222);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(151, 27);
            txtTo.TabIndex = 9;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(83, 257);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(213, 27);
            txtSubject.TabIndex = 10;
            // 
            // txtCC
            // 
            txtCC.Location = new Point(362, 224);
            txtCC.Name = "txtCC";
            txtCC.Size = new Size(220, 27);
            txtCC.TabIndex = 11;
            // 
            // txtBCC
            // 
            txtBCC.Location = new Point(360, 260);
            txtBCC.Name = "txtBCC";
            txtBCC.Size = new Size(226, 27);
            txtBCC.TabIndex = 12;
            // 
            // groupMessageFormat
            // 
            groupMessageFormat.Controls.Add(tableMessageFormat);
            groupMessageFormat.Controls.Add(lblGeneratedTestEmails);
            groupMessageFormat.Controls.Add(btnPreviewCombinations);
            groupMessageFormat.Location = new Point(633, 156);
            groupMessageFormat.Name = "groupMessageFormat";
            groupMessageFormat.Size = new Size(360, 309);
            groupMessageFormat.TabIndex = 13;
            groupMessageFormat.TabStop = false;
            groupMessageFormat.Text = "Message Format";
            // 
            // tableMessageFormat
            // 
            tableMessageFormat.ColumnCount = 2;
            tableMessageFormat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableMessageFormat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableMessageFormat.Controls.Add(lblTransferEncoding, 0, 0);
            tableMessageFormat.Controls.Add(clbTransferEncoding, 0, 1);
            tableMessageFormat.Controls.Add(lblMimeBodyEncoding, 1, 0);
            tableMessageFormat.Controls.Add(clbMimeBodyEncoding, 1, 1);
            tableMessageFormat.Controls.Add(lblCharacterEncoding, 0, 2);
            tableMessageFormat.Controls.Add(clbCharacterEncoding, 0, 3);
            tableMessageFormat.Controls.Add(lblHeaderEncoding, 1, 2);
            tableMessageFormat.Controls.Add(clbHeaderEncoding, 1, 3);
            tableMessageFormat.Location = new Point(12, 26);
            tableMessageFormat.Name = "tableMessageFormat";
            tableMessageFormat.RowCount = 4;
            tableMessageFormat.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableMessageFormat.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableMessageFormat.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableMessageFormat.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableMessageFormat.Size = new Size(336, 256);
            tableMessageFormat.TabIndex = 0;
            // 
            // lblTransferEncoding
            // 
            lblTransferEncoding.AutoSize = true;
            lblTransferEncoding.Location = new Point(3, 0);
            lblTransferEncoding.Name = "lblTransferEncoding";
            lblTransferEncoding.Size = new Size(127, 20);
            lblTransferEncoding.TabIndex = 0;
            lblTransferEncoding.Text = "Transfer Encoding";
            // 
            // clbTransferEncoding
            // 
            clbTransferEncoding.CheckOnClick = true;
            clbTransferEncoding.FormattingEnabled = true;
            clbTransferEncoding.IntegralHeight = false;
            clbTransferEncoding.Location = new Point(3, 27);
            clbTransferEncoding.Name = "clbTransferEncoding";
            clbTransferEncoding.Size = new Size(162, 98);
            clbTransferEncoding.TabIndex = 1;
            clbTransferEncoding.ItemCheck += MessageFormat_ItemCheck;
            // 
            // lblMimeBodyEncoding
            // 
            lblMimeBodyEncoding.AutoSize = true;
            lblMimeBodyEncoding.Location = new Point(171, 0);
            lblMimeBodyEncoding.Name = "lblMimeBodyEncoding";
            lblMimeBodyEncoding.Size = new Size(151, 20);
            lblMimeBodyEncoding.TabIndex = 2;
            lblMimeBodyEncoding.Text = "MIME Body Encoding";
            // 
            // clbMimeBodyEncoding
            // 
            clbMimeBodyEncoding.CheckOnClick = true;
            clbMimeBodyEncoding.FormattingEnabled = true;
            clbMimeBodyEncoding.IntegralHeight = false;
            clbMimeBodyEncoding.Location = new Point(171, 27);
            clbMimeBodyEncoding.Name = "clbMimeBodyEncoding";
            clbMimeBodyEncoding.Size = new Size(162, 98);
            clbMimeBodyEncoding.TabIndex = 3;
            clbMimeBodyEncoding.ItemCheck += MessageFormat_ItemCheck;
            // 
            // lblCharacterEncoding
            // 
            lblCharacterEncoding.AutoSize = true;
            lblCharacterEncoding.Location = new Point(3, 128);
            lblCharacterEncoding.Name = "lblCharacterEncoding";
            lblCharacterEncoding.Size = new Size(138, 20);
            lblCharacterEncoding.TabIndex = 4;
            lblCharacterEncoding.Text = "Character Encoding";
            // 
            // clbCharacterEncoding
            // 
            clbCharacterEncoding.CheckOnClick = true;
            clbCharacterEncoding.FormattingEnabled = true;
            clbCharacterEncoding.IntegralHeight = false;
            clbCharacterEncoding.Location = new Point(3, 155);
            clbCharacterEncoding.Name = "clbCharacterEncoding";
            clbCharacterEncoding.Size = new Size(162, 98);
            clbCharacterEncoding.TabIndex = 5;
            clbCharacterEncoding.ItemCheck += MessageFormat_ItemCheck;
            // 
            // lblHeaderEncoding
            // 
            lblHeaderEncoding.AutoSize = true;
            lblHeaderEncoding.Location = new Point(171, 128);
            lblHeaderEncoding.Name = "lblHeaderEncoding";
            lblHeaderEncoding.Size = new Size(124, 20);
            lblHeaderEncoding.TabIndex = 6;
            lblHeaderEncoding.Text = "Header Encoding";
            // 
            // clbHeaderEncoding
            // 
            clbHeaderEncoding.CheckOnClick = true;
            clbHeaderEncoding.FormattingEnabled = true;
            clbHeaderEncoding.IntegralHeight = false;
            clbHeaderEncoding.Location = new Point(171, 155);
            clbHeaderEncoding.Name = "clbHeaderEncoding";
            clbHeaderEncoding.Size = new Size(162, 98);
            clbHeaderEncoding.TabIndex = 7;
            clbHeaderEncoding.ItemCheck += MessageFormat_ItemCheck;
            // 
            // lblGeneratedTestEmails
            // 
            lblGeneratedTestEmails.AutoSize = true;
            lblGeneratedTestEmails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGeneratedTestEmails.Location = new Point(12, 285);
            lblGeneratedTestEmails.Name = "lblGeneratedTestEmails";
            lblGeneratedTestEmails.Size = new Size(178, 20);
            lblGeneratedTestEmails.TabIndex = 1;
            lblGeneratedTestEmails.Text = "Estimated Test Emails: 1";
            // 
            // btnPreviewCombinations
            // 
            btnPreviewCombinations.Location = new Point(204, 282);
            btnPreviewCombinations.Name = "btnPreviewCombinations";
            btnPreviewCombinations.Size = new Size(144, 27);
            btnPreviewCombinations.TabIndex = 2;
            btnPreviewCombinations.Text = "&Preview Combinations";
            btnPreviewCombinations.UseVisualStyleBackColor = true;
            btnPreviewCombinations.Click += btnPreviewCombinations_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 538);
            Controls.Add(groupMessageFormat);
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
            Controls.Add(chkIgnoreSslCertificateErrors);
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
            groupMessageFormat.ResumeLayout(false);
            groupMessageFormat.PerformLayout();
            tableMessageFormat.ResumeLayout(false);
            tableMessageFormat.PerformLayout();
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
        private CheckBox chkIgnoreSslCertificateErrors;
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
        private GroupBox groupMessageFormat;
        private TableLayoutPanel tableMessageFormat;
        private Label lblTransferEncoding;
        private CheckedListBox clbTransferEncoding;
        private Label lblMimeBodyEncoding;
        private CheckedListBox clbMimeBodyEncoding;
        private Label lblCharacterEncoding;
        private CheckedListBox clbCharacterEncoding;
        private Label lblHeaderEncoding;
        private CheckedListBox clbHeaderEncoding;
        private Label lblGeneratedTestEmails;
        private Button btnPreviewCombinations;
    }
}
