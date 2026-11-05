namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 2: Fonts
// ---------------------------------------------------------------------
// Lecture flow:
//  1. The Font class changes the appearance of printed text.
//  2. Font has MANY overloaded constructors. The two most common:
//        Font(string familyName, float emSize)
//        Font(string familyName, float emSize, FontStyle style)
//     - family name FIRST, in quotes (string)
//     - size SECOND, with the f suffix (float)
//     - style LAST, as a FontStyle value (not a string like "Bold")
//  3. Guide example:  new Font("Calibri", 14.5f)
//     Test example:   new Font("Arial", 10.5f)
//  4. Serif fonts have small end lines (Times New Roman); sans serif
//     fonts do not (Arial, Calibri).
//  5. Accessibility: Helvetica, Courier, Arial, Verdana are recommended
//     for messages to the user; avoid decorative fonts.
// =====================================================================
public partial class Example02FontsForm : Form
{
    // Font objects hold Windows resources, so we dispose old ones we created.
    private Font? currentPreviewFont;

    public Example02FontsForm()
    {
        InitializeComponent();
    }

    // ----- Overloaded constructors -----------------------------------

    private void twoArgButton_Click(object sender, EventArgs e)
    {
        // Two arguments: family name (string), point size (float)
        Font smallPlain = new Font("Arial", 10.5f);
        ApplyPreviewFont(smallPlain, "Font smallPlain = new Font(\"Arial\", 10.5f);");
    }

    private void calibriButton_Click(object sender, EventArgs e)
    {
        // The example from Guide 12
        Font headingFont = new Font("Calibri", 14.5f);
        ApplyPreviewFont(headingFont, "Font headingFont = new Font(\"Calibri\", 14.5f);");
    }

    private void threeArgButton_Click(object sender, EventArgs e)
    {
        // Three arguments: the LAST one is a FontStyle
        Font bigBold = new Font("Arial", 16f, FontStyle.Bold);
        ApplyPreviewFont(bigBold, "Font bigBold = new Font(\"Arial\", 16f, FontStyle.Bold);");
    }

    private void boldItalicButton_Click(object sender, EventArgs e)
    {
        // FontStyle values can be combined with the | (bitwise OR) operator
        Font boldItalic = new Font("Verdana", 14f, FontStyle.Bold | FontStyle.Italic);
        ApplyPreviewFont(boldItalic, "new Font(\"Verdana\", 14f, FontStyle.Bold | FontStyle.Italic);");
    }

    // ----- Accessibility ----------------------------------------------

    // One handler is shared by four buttons. Each button's Tag (set in the
    // Properties window) holds the font family name to use.
    private void AccessibleFontButton_Click(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;
        string familyName = (string)clickedButton.Tag!;

        Font accessibleFont = new Font(familyName, 14f);
        ApplyPreviewFont(accessibleFont, $"new Font(\"{familyName}\", 14f);   // plain and easy to read");
    }

    private void decorativeButton_Click(object sender, EventArgs e)
    {
        Font fancyFont = new Font("Segoe Script", 14f, FontStyle.Italic);
        ApplyPreviewFont(fancyFont, "new Font(\"Segoe Script\", 14f, FontStyle.Italic);   // AVOID: hard to read");
    }

    // ----- Helpers ---------------------------------------------------

    private void ApplyPreviewFont(Font newFont, string code)
    {
        previewLabel.Font = newFont;

        // Dispose the previous font we created (never the designer's font).
        currentPreviewFont?.Dispose();
        currentPreviewFont = newFont;

        codeLabel.Text = code;
        fontInfoLabel.Text =
            $"Result:  Name = {newFont.Name}   |   Size = {newFont.SizeInPoints} pt   |   Style = {newFont.Style}";
    }

    private void Example02FontsForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        currentPreviewFont?.Dispose();
    }
}
