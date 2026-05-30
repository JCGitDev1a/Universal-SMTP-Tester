namespace Universal_SMTP_Tester;

public sealed class EmailTestCase
{
    public int TestNumber { get; init; }
    public string TransferEncoding { get; init; } = string.Empty;
    public string MimeBodyEncoding { get; init; } = string.Empty;
    public string CharacterEncoding { get; init; } = string.Empty;
    public string HeaderEncoding { get; init; } = string.Empty;
}
