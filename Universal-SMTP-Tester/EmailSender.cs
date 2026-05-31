using System.Text;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace Universal_SMTP_Tester
{
    public enum SmtpSecurityMode
    {
        Plain,
        SslOnConnect,
        StartTls
    }

    public class EmailOptions
    {
        public string SmtpHost { get; set; } = string.Empty;
        public int SmtpPort { get; set; } = 587;
        public SmtpSecurityMode SecurityMode { get; set; } = SmtpSecurityMode.StartTls;
        public bool IgnoreSslCertificateErrors { get; set; }

        public bool UseAuthentication { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string FriendlyName { get; set; } = string.Empty;
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public string Cc { get; set; } = string.Empty;
        public string Bcc { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string MimeType { get; set; } = "text/plain";
        public Encoding BodyEncoding { get; set; } = Encoding.UTF8;
        public Encoding SubjectEncoding { get; set; } = Encoding.UTF8;

        public string[] AttachmentPaths { get; set; } = Array.Empty<string>();

        public int TestNumber { get; set; }
        public int TotalTestCount { get; set; }
        public string TransferEncodingOption { get; set; } = string.Empty;
        public string MimeBodyEncodingOption { get; set; } = string.Empty;
        public string CharacterEncodingOption { get; set; } = string.Empty;
        public string HeaderEncodingOption { get; set; } = string.Empty;
    }

    public class EmailSender
    {
        public static void SendEmail(EmailOptions options)
        {
            SendEmailAsync(options).GetAwaiter().GetResult();
        }

        public static async Task SendEmailAsync(EmailOptions options)
        {
            ValidateOptions(options);

            using var message = BuildMimeMessage(options);
            using var client = new SmtpClient();

            if (options.IgnoreSslCertificateErrors)
            {
                // Testing-only option for lab/self-signed/mismatched certificate scenarios.
                // Do not enable this for normal production SMTP testing.
                client.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            }

            await client.ConnectAsync(
                options.SmtpHost,
                options.SmtpPort,
                GetSecureSocketOptions(options.SecurityMode));

            if (options.UseAuthentication)
            {
                await client.AuthenticateAsync(options.Username, options.Password);
            }

            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }

        private static MimeMessage BuildMimeMessage(EmailOptions options)
        {
            var message = new MimeMessage();

            message.From.Add(BuildMailboxAddress(options.FriendlyName, options.From));
            AddAddresses(message.To, options.To);
            AddAddresses(message.Cc, options.Cc);
            AddAddresses(message.Bcc, options.Bcc);

            message.Subject = options.Subject ?? string.Empty;

            message.Headers.Add("X-SMTP-Tester-Security-Mode", options.SecurityMode.ToString());
            message.Headers.Add("X-SMTP-Tester-Ignore-SSL-Certificate-Errors", options.IgnoreSslCertificateErrors.ToString());
            message.Headers.Add("X-SMTP-Tester-Body-Mime-Type", options.MimeType);
            message.Headers.Add("X-SMTP-Tester-Body-Encoding", options.BodyEncoding.WebName);
            message.Headers.Add("X-SMTP-Tester-Subject-Encoding", options.SubjectEncoding.WebName);

            if (options.TestNumber > 0 && options.TotalTestCount > 0)
            {
                message.Headers.Add("X-SMTP-Tester-Test-Number", options.TestNumber.ToString());
                message.Headers.Add("X-SMTP-Tester-Test-Total", options.TotalTestCount.ToString());
                message.Headers.Add("X-SMTP-Tester-Transfer-Encoding-Option", options.TransferEncodingOption);
                message.Headers.Add("X-SMTP-Tester-Mime-Body-Encoding-Option", options.MimeBodyEncodingOption);
                message.Headers.Add("X-SMTP-Tester-Character-Encoding-Option", options.CharacterEncodingOption);
                message.Headers.Add("X-SMTP-Tester-Header-Encoding-Option", options.HeaderEncodingOption);
            }

            var bodyPart = new TextPart(GetTextPartSubtype(options.MimeType))
            {
                Text = options.Body ?? string.Empty,
                ContentTransferEncoding = GetContentTransferEncoding(options.TransferEncodingOption)
            };

            message.Headers.Add("X-SMTP-Tester-Applied-Transfer-Encoding", bodyPart.ContentTransferEncoding.ToString());

            if (options.AttachmentPaths.Length == 0)
            {
                message.Body = bodyPart;
            }
            else
            {
                var multipart = new Multipart("mixed") { bodyPart };

                foreach (var filePath in options.AttachmentPaths)
                {
                    if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath))
                    {
                        multipart.Add(CreateAttachmentPart(filePath));
                    }
                }

                message.Body = multipart;
            }

            return message;
        }

        private static void ValidateOptions(EmailOptions options)
        {
            if (string.IsNullOrWhiteSpace(options.SmtpHost))
                throw new ArgumentException("SMTP host is required.");

            if (options.SmtpPort <= 0 || options.SmtpPort > 65535)
                throw new ArgumentException("SMTP port must be between 1 and 65535.");

            if (string.IsNullOrWhiteSpace(options.From))
                throw new ArgumentException("Sender address is required.");

            if (string.IsNullOrWhiteSpace(options.To))
                throw new ArgumentException("At least one recipient address is required.");

            if (options.UseAuthentication && string.IsNullOrWhiteSpace(options.Username))
                throw new ArgumentException("SMTP username is required when authentication is enabled.");
        }

        private static MailboxAddress BuildMailboxAddress(string displayName, string emailAddress)
        {
            return string.IsNullOrWhiteSpace(displayName)
                ? MailboxAddress.Parse(emailAddress)
                : new MailboxAddress(displayName, emailAddress);
        }

        private static void AddAddresses(InternetAddressList addressList, string addresses)
        {
            if (string.IsNullOrWhiteSpace(addresses))
                return;

            foreach (var address in addresses.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            {
                addressList.Add(MailboxAddress.Parse(address));
            }
        }

        private static SecureSocketOptions GetSecureSocketOptions(SmtpSecurityMode securityMode)
        {
            return securityMode switch
            {
                SmtpSecurityMode.Plain => SecureSocketOptions.None,
                SmtpSecurityMode.SslOnConnect => SecureSocketOptions.SslOnConnect,
                SmtpSecurityMode.StartTls => SecureSocketOptions.StartTls,
                _ => SecureSocketOptions.Auto
            };
        }

        private static ContentEncoding GetContentTransferEncoding(string transferEncodingOption)
        {
            if (!Enum.TryParse<MimeTransferEncodingOption>(transferEncodingOption, ignoreCase: true, out var selectedEncoding))
            {
                return ContentEncoding.Default;
            }

            return selectedEncoding switch
            {
                MimeTransferEncodingOption.Base64 => ContentEncoding.Base64,
                MimeTransferEncodingOption.QuotedPrintable => ContentEncoding.QuotedPrintable,
                MimeTransferEncodingOption.SevenBit => ContentEncoding.SevenBit,
                MimeTransferEncodingOption.EightBit => ContentEncoding.EightBit,
                MimeTransferEncodingOption.Binary => ContentEncoding.Binary,
                _ => ContentEncoding.Default
            };
        }

        private static MimePart CreateAttachmentPart(string filePath)
        {
            var attachment = new MimePart(MimeTypes.GetMimeType(filePath))
            {
                Content = new MimeContent(File.OpenRead(filePath)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(filePath)
            };

            return attachment;
        }

        private static string GetTextPartSubtype(string mimeType)
        {
            return mimeType.Equals("text/html", StringComparison.OrdinalIgnoreCase)
                ? "html"
                : "plain";
        }
    }
}
