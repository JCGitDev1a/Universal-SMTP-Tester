using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Universal_SMTP_Tester
{
    public class EmailOptions
    {
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; } = 587;
        public bool EnableSsl { get; set; } = true;
        public string Username { get; set; }
        public string Password { get; set; }

        public string From { get; set; }
        public string To { get; set; }

        public string Subject { get; set; }
        public string Body { get; set; }
        public string MimeType { get; set; } = "text/plain"; // or "text/html"
        public Encoding BodyEncoding { get; set; } = Encoding.UTF8;
        public Encoding SubjectEncoding { get; set; } = Encoding.UTF8;

        public string[] AttachmentPaths { get; set; } = Array.Empty<string>();
    }

    public class EmailSender
    {
        public static void SendEmail(EmailOptions options)
        {
            using (var message = BuildMailMessage(options))
            using (var client = new SmtpClient(options.SmtpHost, options.SmtpPort))
            {
                client.EnableSsl = options.EnableSsl;
                client.Credentials = new NetworkCredential(options.Username, options.Password);
                client.Send(message);
            }
        }

        public static async Task SendEmailAsync(EmailOptions options)
        {
            using (var message = BuildMailMessage(options))
            using (var client = new SmtpClient(options.SmtpHost, options.SmtpPort))
            {
                client.EnableSsl = options.EnableSsl;
                client.Credentials = new NetworkCredential(options.Username, options.Password);
                await client.SendMailAsync(message);
            }
        }

        private static MailMessage BuildMailMessage(EmailOptions options)
        {
            if (string.IsNullOrWhiteSpace(options.From) || string.IsNullOrWhiteSpace(options.To))
                throw new ArgumentException("Sender and recipient must be specified.");

            var message = new MailMessage(options.From, options.To)
            {
                Subject = options.Subject ?? string.Empty,
                SubjectEncoding = options.SubjectEncoding,
                BodyEncoding = options.BodyEncoding,
                IsBodyHtml = options.MimeType.Equals("text/html", StringComparison.OrdinalIgnoreCase)
            };

            var view = AlternateView.CreateAlternateViewFromString(
                options.Body ?? string.Empty,
                options.BodyEncoding,
                options.MimeType
            );
            message.AlternateViews.Add(view);

            foreach (var filePath in options.AttachmentPaths)
            {
                if (File.Exists(filePath))
                {
                    message.Attachments.Add(new Attachment(filePath));
                }
            }

            return message;
        }
    }
}
