# Universal-SMTP-Tester

This program is designed to assist in testing and troubleshooting email delivery.
It allows you to select a variety of message formats based on Character Encoding, MIME Encoding, SMTP Sending Encoding, and Header MIME encoding.

## Build
To build this project, you will need the following:
```
BouncyCastle.Cryptography.2.6.2
MailKit.4.16.0+
MimeKit.4.16.0+
System.Formats.Asn1.8.0.1
System.Security.Cryptography.Pkcs.8.0.1
```
However, when you use Nuget, you can simply install MailKit and it will automatically load it's dependencies of MimeKit, BouncyCastle.Cryptography, System.Formats.Asn1, and System.Security.Cryptography.Pkcs.

## About
In the world of email you often come across odd formatting or encoding types.  This program is designed to assist email admins, developers, and quality assurance to ensure a mail server is handling email correctly.  This is especially useful when you are applying mail flow policies or DLP type actions.

The most common usage is to test options that Microsoft Outlook and Mozilla Thunderbird hide from you or that Google Workspace and Microsoft 365 do not allow you to modify.

## Encoding Types
An SMTP message can use several different types of character encoding.
More detailed information can be found via https://en.wikipedia.org/wiki/Simple_Mail_Transfer_Protocol

### Header Encoding
None
Quoted Printable UTF-8

### Character Encoding
None,
US_ASCII,
UTF8,
UTF16,
ISO_8859_1,
ISO_8859_15

### MIME Body Encoding
None,
TextPlain,
TextHtml,
MultipartMixed,
MultipartAlternative

### MIME Transfer Encoding
None,
Base64,
QuotedPrintable,
SevenBit,
EightBit,
Binary





