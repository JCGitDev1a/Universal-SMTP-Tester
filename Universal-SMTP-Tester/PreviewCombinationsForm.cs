namespace Universal_SMTP_Tester;

public sealed class PreviewCombinationsForm : Form
{
    private readonly DataGridView gridCombinations;
    private readonly Button btnClose;

    public PreviewCombinationsForm(IReadOnlyCollection<EmailTestCase> testCases)
    {
        Text = "Preview Generated Test Combinations";
        StartPosition = FormStartPosition.CenterParent;
        MinimumSize = new Size(760, 420);
        Size = new Size(900, 520);

        gridCombinations = new DataGridView
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            AllowUserToResizeRows = false,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false,
            RowHeadersVisible = false,
            DataSource = testCases
                .OrderBy(testCase => testCase.TestNumber)
                .Select(testCase => new
                {
                    Number = testCase.TestNumber,
                    TransferEncoding = testCase.TransferEncoding,
                    MimeBodyEncoding = testCase.MimeBodyEncoding,
                    CharacterEncoding = testCase.CharacterEncoding,
                    HeaderEncoding = testCase.HeaderEncoding
                })
                .ToList()
        };

        btnClose = new Button
        {
            Text = "Close",
            DialogResult = DialogResult.OK,
            Dock = DockStyle.Right,
            Width = 100
        };

        var bottomPanel = new Panel
        {
            Dock = DockStyle.Bottom,
            Height = 44,
            Padding = new Padding(8)
        };
        bottomPanel.Controls.Add(btnClose);

        Controls.Add(gridCombinations);
        Controls.Add(bottomPanel);

        AcceptButton = btnClose;
        CancelButton = btnClose;
    }
}
