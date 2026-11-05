namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 10: Form Layout
// ---------------------------------------------------------------------
// Lecture flow:
//  1. Snap lines: blue guides in the Form Designer that help align a
//     control with controls already on the form. (Designer only.)
//  2. Location = a control's fixed position in its container.
//  3. Anchor   = keep a fixed DISTANCE from chosen sides as the container
//                is resized (anchoredButton stays near the bottom-right;
//                stretchTextBox is anchored left AND right, so it widens).
//  4. Dock     = ATTACH to a side and STRETCH along it (navPanel, statusLabel).
//     -> Resize the window and compare the three behaviors.
//  5. ContainsFocus (public Control property): true when the control OR
//     one of its child controls has the input focus. Compare it with
//     Focused, which is true only for the control itself.
//  6. Capture: gets or sets whether the control has captured the mouse.
//     While captured, the control keeps getting mouse events even when
//     the pointer leaves it.
// =====================================================================
public partial class Example10LayoutForm : Form
{
    private static readonly Point OriginalFixedButtonLocation = new Point(162, 104);
    private static readonly Point MovedFixedButtonLocation = new Point(560, 104);

    public Example10LayoutForm()
    {
        InitializeComponent();
        captureStatusLabel.Text = "captureLabel.Capture = False";
    }

    // ----- Location --------------------------------------------------

    private void moveButton_Click(object sender, EventArgs e)
    {
        fixedButton.Location = fixedButton.Location == OriginalFixedButtonLocation
            ? MovedFixedButtonLocation
            : OriginalFixedButtonLocation;

        statusLabel.Text = $"fixedButton.Location = new Point({fixedButton.Left}, {fixedButton.Top});";
    }

    // ----- ContainsFocus vs. Focused -----------------------------------

    // A Timer checks the focus five times per second so students can watch
    // the values change as they click around the form.
    private void focusTimer_Tick(object sender, EventArgs e)
    {
        focusStatusLabel.Text =
            $"focusGroupBox.ContainsFocus = {focusGroupBox.ContainsFocus}\r\n" +
            $"focusGroupBox.Focused       = {focusGroupBox.Focused}\r\n" +
            $"firstNameTextBox.Focused    = {firstNameTextBox.Focused}\r\n" +
            $"lastNameTextBox.Focused     = {lastNameTextBox.Focused}\r\n" +
            $"stretchTextBox.Focused      = {stretchTextBox.Focused}";
    }

    // ----- Capture ---------------------------------------------------

    private void captureLabel_MouseDown(object sender, MouseEventArgs e)
    {
        // Controls capture the mouse automatically on MouseDown;
        // setting it here makes the idea visible in code.
        captureLabel.Capture = true;
        ShowCaptureStatus(e.Location);
    }

    private void captureLabel_MouseMove(object sender, MouseEventArgs e)
    {
        if (captureLabel.Capture)
        {
            ShowCaptureStatus(e.Location);
        }
    }

    private void captureLabel_MouseUp(object sender, MouseEventArgs e)
    {
        captureLabel.Capture = false;
        ShowCaptureStatus(e.Location);
    }

    private void ShowCaptureStatus(Point mouseLocation)
    {
        bool isInside = captureLabel.ClientRectangle.Contains(mouseLocation);

        captureStatusLabel.Text =
            $"captureLabel.Capture = {captureLabel.Capture}\r\n" +
            $"Mouse at ({mouseLocation.X}, {mouseLocation.Y})\r\n" +
            (isInside
                ? "Pointer is INSIDE the label."
                : "Pointer is OUTSIDE, but the label\r\nstill gets the events (captured).");
    }
}
