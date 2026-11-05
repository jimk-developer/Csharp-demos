using System.Diagnostics;

namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 9: Multiple Forms and Navigation
// ---------------------------------------------------------------------
// Lecture flow:
//  1. LinkLabel links the user to other sources (web pages, files, forms).
//     - Looks like underlined text; the pointer becomes a hand.
//     - LinkLabel is a CHILD of Label (click "Show LinkLabel family").
//     - LinkColor defaults to blue; VisitedLinkColor defaults to purple.
//       Setting LinkVisited = true switches the link to purple.
//     - LinkClicked is its default event / default method.
//  2. A project can hold more than one Form (Project > Add Form).
//  3. Show()       -> NON-MODAL: the code continues at once and the user
//                     can still use this form. (Guide: settingsForm.Show())
//     ShowDialog() -> MODAL window: the code WAITS on that line and the
//                     user cannot use this form until the dialog closes.
//     -> Open each one, then try "Click me" on this form. Watch the timeline.
// =====================================================================
public partial class Example09MultipleFormsForm : Form
{
    private const string LinkLabelDocsUrl =
        "https://learn.microsoft.com/dotnet/api/system.windows.forms.linklabel";

    private Example09SettingsForm? settingsForm;
    private int clickCount;

    public Example09MultipleFormsForm()
    {
        InitializeComponent();
        Log("Example 09 started. LinkLabels are blue until visited, then purple.");
    }

    // ----- LinkLabel: open a web page ---------------------------------

    // DEFAULT METHOD for a LinkLabel: runs when the link is clicked.
    private void websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            // UseShellExecute = true opens the URL in the user's default browser.
            Process.Start(new ProcessStartInfo(LinkLabelDocsUrl) { UseShellExecute = true });
            websiteLinkLabel.LinkVisited = true;   // turns the link purple
            Log("Opened the LinkLabel documentation in the browser.");
        }
        catch (Exception ex)
        {
            Log($"Could not open the browser: {ex.Message}");
        }
    }

    // ----- Show(): non-modal ------------------------------------------

    private void settingsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        // Reuse the settings form if it is still open; otherwise create a new one.
        if (settingsForm == null || settingsForm.IsDisposed)
        {
            settingsForm = new Example09SettingsForm(this);
            settingsForm.Location = new Point(Right - 60, Top + 60);
        }

        Log("Calling settingsForm.Show() ...");
        settingsForm.Show();
        settingsForm.Activate();
        Log("  Show() returned IMMEDIATELY. This form is still usable (try Click me).");

        settingsLinkLabel.LinkVisited = true;
    }

    // ----- ShowDialog(): modal ----------------------------------------

    private void modalLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using Example09ModalDialogForm signInForm = new Example09ModalDialogForm();

        Log("Calling signInForm.ShowDialog() ... this method now WAITS.");
        Stopwatch timer = Stopwatch.StartNew();

        DialogResult result = signInForm.ShowDialog(this);   // the code stops here until the form closes

        Log($"  ShowDialog() finally returned {result} after {timer.Elapsed.TotalSeconds:0.0} seconds.");

        if (result == DialogResult.OK)
        {
            Log($"  The modal form handed back the name: \"{signInForm.StudentName}\"");
        }

        modalLinkLabel.LinkVisited = true;
    }

    // ----- Proof that this form is (or is not) usable -----------------

    private void clickMeButton_Click(object sender, EventArgs e)
    {
        clickCount++;
        clickCountLabel.Text = $"Clicks: {clickCount}";
    }

    private void familyButton_Click(object sender, EventArgs e)
    {
        Log($"typeof(LinkLabel).BaseType = {typeof(LinkLabel).BaseType!.Name}   (LinkLabel is a child of Label)");
        Log($"LinkColor = {websiteLinkLabel.LinkColor.Name}   VisitedLinkColor = {websiteLinkLabel.VisitedLinkColor.Name}");
    }

    // ----- Helpers ---------------------------------------------------

    private void Log(string message)
    {
        logTextBox.AppendText($"{DateTime.Now:HH:mm:ss}  {message}\r\n");
    }
}
