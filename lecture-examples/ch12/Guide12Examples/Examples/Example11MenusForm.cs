namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 11: Menus
// ---------------------------------------------------------------------
// Lecture flow:
//  1. MenuStrip = horizontal list of general options under the title bar.
//     In the designer: drag a MenuStrip onto the form, then type each
//     menu item directly on the strip ("Type Here").
//  2. & before a unique letter makes an access key: Alt+F opens File,
//     Alt+H opens Help, and so on (same idea as ButtonBase Text).
//  3. Double-clicking a menu item in the designer generates its Click()
//     method, e.g. exitToolStripMenuItem_Click below.
//  4. Conventional menu order: File, Edit, View, ..., and Help LAST
//     (the far-right position on the menu bar).
//  5. ShortcutKeys (Ctrl+N, Ctrl+O, ...) are set in the Properties window.
// =====================================================================
public partial class Example11MenusForm : Form
{
    private const float MinimumTextSize = 8f;
    private const float MaximumTextSize = 28f;

    private Font? currentDocumentFont;

    public Example11MenusForm()
    {
        InitializeComponent();
    }

    private void Example11MenusForm_Load(object sender, EventArgs e)
    {
        documentTextBox.Text = WelcomeText();
        documentTextBox.Select(0, 0);
    }

    // ----- File menu -------------------------------------------------

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        documentTextBox.Clear();
        ShowStatus(nameof(newToolStripMenuItem_Click));
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openTextDialog.ShowDialog(this) == DialogResult.OK)
        {
            documentTextBox.Text = File.ReadAllText(openTextDialog.FileName);
            Text = $"Example 11 - Menus - {Path.GetFileName(openTextDialog.FileName)}";
        }

        ShowStatus(nameof(openToolStripMenuItem_Click));
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();   // closes this example form only; the launcher keeps running
    }

    // ----- Edit menu -------------------------------------------------

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        documentTextBox.Cut();
        ShowStatus(nameof(cutToolStripMenuItem_Click));
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        documentTextBox.Copy();
        ShowStatus(nameof(copyToolStripMenuItem_Click));
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        documentTextBox.Paste();
        ShowStatus(nameof(pasteToolStripMenuItem_Click));
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
        documentTextBox.SelectAll();
        ShowStatus(nameof(selectAllToolStripMenuItem_Click));
    }

    // ----- View menu (uses Font and Color from Sections 2 and 3) -------

    private void largerTextToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ChangeTextSize(+2f);
        ShowStatus(nameof(largerTextToolStripMenuItem_Click));
    }

    private void smallerTextToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ChangeTextSize(-2f);
        ShowStatus(nameof(smallerTextToolStripMenuItem_Click));
    }

    // CheckOnClick = true, so the menu item's Checked property flips each click.
    private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (darkModeToolStripMenuItem.Checked)
        {
            documentTextBox.BackColor = Color.FromArgb(30, 27, 46);
            documentTextBox.ForeColor = Color.FromArgb(250, 250, 249);   // high contrast
        }
        else
        {
            documentTextBox.BackColor = SystemColors.Window;
            documentTextBox.ForeColor = SystemColors.WindowText;
        }

        ShowStatus(nameof(darkModeToolStripMenuItem_Click));
    }

    // ----- Help menu (last, far right) ---------------------------------

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowStatus(nameof(aboutToolStripMenuItem_Click));

        MessageBox.Show(
            "Guide 12: Microsoft Visual C# - Using Controls\n\n" +
            "Example 11 shows a MenuStrip with File, Edit, View, and Help.\n" +
            "By convention, Help is the last (far-right) menu.",
            "About Guide 12 Examples",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    // ----- Helpers ---------------------------------------------------

    private void ChangeTextSize(float change)
    {
        float newSize = Math.Clamp(documentTextBox.Font.Size + change, MinimumTextSize, MaximumTextSize);
        Font newFont = new Font(documentTextBox.Font.FontFamily, newSize);

        documentTextBox.Font = newFont;
        currentDocumentFont?.Dispose();
        currentDocumentFont = newFont;
    }

    private void ShowStatus(string methodName)
    {
        statusLabel.Text = $"Ran {methodName}()";
    }

    private static string WelcomeText() => string.Join(Environment.NewLine,
        "MENUSTRIP EXAMPLE",
        "=================",
        "",
        "Try the menus above:",
        "  * Press Alt+F, Alt+E, Alt+V, or Alt+H (the & access keys).",
        "  * Use shortcut keys: Ctrl+N (New), Ctrl+O (Open), Ctrl++ and Ctrl+- (text size), F1 (About).",
        "  * View > Dark mode is a CheckOnClick menu item.",
        "",
        "Notice the conventional order: File, Edit, View, and Help LAST (far right).",
        "",
        "In the designer, double-click any menu item to jump to its Click() method.");
}
