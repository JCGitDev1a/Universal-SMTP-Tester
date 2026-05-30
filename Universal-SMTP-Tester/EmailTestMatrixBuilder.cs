namespace Universal_SMTP_Tester;

public static class EmailTestMatrixBuilder
{
    public static List<EmailTestCase> Build(
        IReadOnlyCollection<string> transferEncodings,
        IReadOnlyCollection<string> mimeBodyEncodings,
        IReadOnlyCollection<string> characterEncodings,
        IReadOnlyCollection<string> headerEncodings)
    {
        var transfers = NormalizeSelections(transferEncodings, nameof(MimeTransferEncodingOption.None));
        var bodies = NormalizeSelections(mimeBodyEncodings, nameof(MimeBodyTypeOption.None));
        var characters = NormalizeSelections(characterEncodings, nameof(CharacterEncodingOption.None));
        var headers = NormalizeSelections(headerEncodings, nameof(HeaderEncodingOption.None));

        var testCases = new List<EmailTestCase>();
        var testNumber = 1;

        foreach (var transfer in transfers)
        foreach (var body in bodies)
        foreach (var character in characters)
        foreach (var header in headers)
        {
            testCases.Add(new EmailTestCase
            {
                TestNumber = testNumber++,
                TransferEncoding = transfer,
                MimeBodyEncoding = body,
                CharacterEncoding = character,
                HeaderEncoding = header
            });
        }

        return testCases;
    }

    private static IReadOnlyList<string> NormalizeSelections(IReadOnlyCollection<string> selectedValues, string fallbackValue)
    {
        if (selectedValues.Count == 0)
        {
            return [fallbackValue];
        }

        return selectedValues.ToList();
    }
}
