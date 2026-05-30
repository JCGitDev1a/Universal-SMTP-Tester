namespace Universal_SMTP_Tester;

public enum MimeTransferEncodingOption
{
    None,
    Base64,
    QuotedPrintable,
    SevenBit,
    EightBit,
    Binary
}

public enum MimeBodyTypeOption
{
    None,
    TextPlain,
    TextHtml,
    MultipartMixed,
    MultipartAlternative
}

public enum CharacterEncodingOption
{
    None,
    US_ASCII,
    UTF8,
    UTF16,
    ISO_8859_1,
    ISO_8859_15
}

public enum HeaderEncodingOption
{
    None,
    QuotedPrintableUtf8
}
