# Universal-SMTP-Tester

This program is designed to assist in testing and troubleshooting email delivery.
It allows you to select a variety of message formats based on Character Encoding, MIME Encoding, SMTP Sending Encoding, and Header MIME encoding.

## Build
To build this project, you will need the following:
```
BouncyCastle.Cryptography.2.6.2
MailKit.4.16.0
MimeKit.4.16.0
System.Formats.Asn1.8.0.1
System.Security.Cryptography.Pkcs.8.0.1
```
However, when you use Nuget, you can simply install MailKit and it will automatically load it's dependencies of MimeKit, BouncyCastle.Cryptography, System.Formats.Asn1, and System.Security.Cryptography.Pkcs.
