using System.Text;

namespace Universal_SMTP_Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void sendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                int optEnableSSL = 0;
                if (btnSSLDirect.Checked == true)
                {
                    optEnableSSL = 1;
                }
                else if (btnStartTLS.Checked == true)
                {
                    optEnableSSL = 2;
                }
                var options = new EmailOptions
                {
                    SmtpHost = txtSmtpHost.Text,
                    SmtpPort = int.Parse(intSmtpPort.Text),
                    //EnableSsl = chkSsl.Checked,
                    //EnableSsl = optEnableSSL,
                    EnableSsl = false,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    From = txtFrom.Text,
                    To = txtTo.Text,
                    Subject = txtSubject.Text,
                    Body = txtBody.Text,
                    //MimeType = rdoHtml.Checked ? "text/html" : "text/plain",
                    MimeType = "text/plain",
                    BodyEncoding = Encoding.UTF8, // or Encoding.ASCII
                    SubjectEncoding = Encoding.UTF8,
                    AttachmentPaths = new[] { @"C:\example\file.txt" } // get from OpenFileDialog
                };

                await EmailSender.SendEmailAsync(options);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}");
            }
        }

        private void btnPlain_CheckedChanged(object sender, EventArgs e)
        {
            intSmtpPort.Text = "25";
        }

        private void btnSSLDirect_CheckedChanged(object sender, EventArgs e)
        {
            intSmtpPort.Text = "465";
        }

        private void btnStartTLS_CheckedChanged(object sender, EventArgs e)
        {
            intSmtpPort.Text = "587";
        }

        private void chkSMTPAUTH_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
        }
    }
}
