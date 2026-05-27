using System.Text;

namespace Universal_SMTP_Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private async void sendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(intSmtpPort.Text, out var smtpPort))
                {
                    MessageBox.Show("SMTP port must be a valid number.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var options = new EmailOptions
                {
                    SmtpHost = txtSmtpHost.Text.Trim(),
                    SmtpPort = smtpPort,
                    SecurityMode = GetSelectedSecurityMode(),
                    IgnoreSslCertificateErrors = chkIgnoreSslCertificateErrors.Checked,
                    UseAuthentication = chkSMTPAUTH.Checked,
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text,
                    FriendlyName = txtFriendlyName.Text.Trim(),
                    From = txtFrom.Text.Trim(),
                    To = txtTo.Text.Trim(),
                    Cc = txtCC.Text.Trim(),
                    Bcc = txtBCC.Text.Trim(),
                    Subject = txtSubject.Text,
                    Body = txtBody.Text,
                    MimeType = "text/plain",
                    BodyEncoding = Encoding.UTF8,
                    SubjectEncoding = Encoding.UTF8,
                    AttachmentPaths = Array.Empty<string>()
                };

                await EmailSender.SendEmailAsync(options);
                MessageBox.Show("Email sent successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email:{Environment.NewLine}{ex}", "Send Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SmtpSecurityMode GetSelectedSecurityMode()
        {
            if (btnSSLDirect.Checked)
                return SmtpSecurityMode.SslOnConnect;

            if (btnStartTLS.Checked)
                return SmtpSecurityMode.StartTls;

            return SmtpSecurityMode.Plain;
        }

        private void btnPlain_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPlain.Checked)
                intSmtpPort.Text = "25";
        }

        private void btnSSLDirect_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSSLDirect.Checked)
                intSmtpPort.Text = "465";
        }

        private void btnStartTLS_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStartTLS.Checked)
                intSmtpPort.Text = "587";
        }

        private void chkSMTPAUTH_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = chkSMTPAUTH.Checked;
            txtPassword.Enabled = chkSMTPAUTH.Checked;
        }
    }
}
