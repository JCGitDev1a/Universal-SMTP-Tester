using System.Text;

namespace Universal_SMTP_Tester
{
    public partial class Form1 : Form
    {
        private bool _isInitializingMessageFormatOptions;

        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            _isInitializingMessageFormatOptions = true;
            InitializeMessageFormatOptions();
            _isInitializingMessageFormatOptions = false;
            UpdateGeneratedTestEmailCount();
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

                var testCases = BuildEmailTestCasesFromSelections();

                if (testCases.Count == 0)
                {
                    MessageBox.Show("No test combinations were generated.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedTestCases = chkSendAllGeneratedCombinations.Checked
                    ? testCases
                    : testCases.Take(1).ToList();

                var totalGeneratedTests = testCases.Count;
                var sentCount = 0;

                sendEmail.Enabled = false;
                sendEmail.Text = "Sending...";

                try
                {
                    foreach (var testCase in selectedTestCases)
                    {
                        var options = BuildEmailOptionsFromForm(smtpPort);
                        ApplyTestCase(options, testCase, totalGeneratedTests);

                        await EmailSender.SendEmailAsync(options);
                        sentCount++;
                    }
                }
                finally
                {
                    sendEmail.Enabled = true;
                    sendEmail.Text = "&Send Email";
                }

                MessageBox.Show($"Sent {sentCount} email(s) successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email:{Environment.NewLine}{ex}", "Send Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EmailOptions BuildEmailOptionsFromForm(int smtpPort)
        {
            return new EmailOptions
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
        }

        private static void ApplyTestCase(EmailOptions options, EmailTestCase testCase, int totalGeneratedTests)
        {
            options.TestNumber = testCase.TestNumber;
            options.TotalTestCount = totalGeneratedTests;
            options.TransferEncodingOption = testCase.TransferEncoding;
            options.MimeBodyEncodingOption = testCase.MimeBodyEncoding;
            options.CharacterEncodingOption = testCase.CharacterEncoding;
            options.HeaderEncodingOption = testCase.HeaderEncoding;
            options.Subject = $"[Test {testCase.TestNumber} of {totalGeneratedTests}] {options.Subject}";
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


        private void InitializeMessageFormatOptions()
        {
            AddCheckedListBoxItems(clbTransferEncoding, Enum.GetNames<MimeTransferEncodingOption>());
            AddCheckedListBoxItems(clbMimeBodyEncoding, Enum.GetNames<MimeBodyTypeOption>());
            AddCheckedListBoxItems(clbCharacterEncoding, Enum.GetNames<CharacterEncodingOption>());
            AddCheckedListBoxItems(clbHeaderEncoding, Enum.GetNames<HeaderEncodingOption>());

            CheckFirstItem(clbTransferEncoding);
            CheckFirstItem(clbMimeBodyEncoding);
            CheckFirstItem(clbCharacterEncoding);
            CheckFirstItem(clbHeaderEncoding);
        }

        private static void AddCheckedListBoxItems(CheckedListBox checkedListBox, IEnumerable<string> items)
        {
            checkedListBox.Items.Clear();

            foreach (var item in items)
            {
                checkedListBox.Items.Add(item);
            }
        }

        private static void CheckFirstItem(CheckedListBox checkedListBox)
        {
            if (checkedListBox.Items.Count > 0)
            {
                checkedListBox.SetItemChecked(0, true);
            }
        }

        private void MessageFormat_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isInitializingMessageFormatOptions || !IsHandleCreated)
            {
                return;
            }

            BeginInvoke(new MethodInvoker(UpdateGeneratedTestEmailCount));
        }

        private void UpdateGeneratedTestEmailCount()
        {
            var transferEncodingCount = GetCheckedItemCount(clbTransferEncoding);
            var mimeBodyEncodingCount = GetCheckedItemCount(clbMimeBodyEncoding);
            var characterEncodingCount = GetCheckedItemCount(clbCharacterEncoding);
            var headerEncodingCount = GetCheckedItemCount(clbHeaderEncoding);

            var generatedEmailCount =
                transferEncodingCount *
                mimeBodyEncodingCount *
                characterEncodingCount *
                headerEncodingCount;

            lblGeneratedTestEmails.Text = $"Generated Test Emails: {generatedEmailCount}";
        }

        private static int GetCheckedItemCount(CheckedListBox checkedListBox)
        {
            return Math.Max(1, checkedListBox.CheckedItems.Count);
        }



        private void btnPreviewCombinations_Click(object sender, EventArgs e)
        {
            var testCases = BuildEmailTestCasesFromSelections();

            using var previewForm = new PreviewCombinationsForm(testCases);
            previewForm.ShowDialog(this);
        }

        private List<EmailTestCase> BuildEmailTestCasesFromSelections()
        {
            return EmailTestMatrixBuilder.Build(
                GetCheckedItemText(clbTransferEncoding),
                GetCheckedItemText(clbMimeBodyEncoding),
                GetCheckedItemText(clbCharacterEncoding),
                GetCheckedItemText(clbHeaderEncoding));
        }

        private static List<string> GetCheckedItemText(CheckedListBox checkedListBox)
        {
            return checkedListBox.CheckedItems
                .Cast<object>()
                .Select(item => item.ToString() ?? string.Empty)
                .Where(item => !string.IsNullOrWhiteSpace(item))
                .ToList();
        }

    }
}
