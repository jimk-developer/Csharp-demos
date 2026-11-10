// =====================================================================
//  EXAMPLE 4: Mouse Events
//
//  Key ideas:
//   - Mouse events are handled with the MouseEventHandler delegate.
//   - Events such as MouseDown, MouseUp, MouseMove, and MouseClick
//     send a MouseEventArgs object (e) that tells you:
//         e.X, e.Y   where the pointer is, inside the control
//         e.Button   which mouse button was used
//   - MouseEnter, MouseLeave, and MouseHover send a plain EventArgs,
//     because there is no position information to report.
//
//  Try this: move into the blue box, rest the pointer, click with the
//  left and right buttons, then move out. The newest event is on top.
// =====================================================================

namespace Example04_MouseEvents;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Adds a line to the TOP of the list, so the newest event shows first.
    private void Log(string text)
    {
        eventListBox.Items.Insert(0, text);
    }

    // The pointer moved INTO the panel's boundaries
    private void targetPanel_MouseEnter(object sender, EventArgs e)
    {
        targetPanel.BackColor = Color.LightGreen;
        Log("MouseEnter");
    }

    // The pointer moved OUT OF the panel's boundaries
    private void targetPanel_MouseLeave(object sender, EventArgs e)
    {
        targetPanel.BackColor = Color.LightSteelBlue;
        positionLabel.Text = "The pointer is outside the box.";
        Log("MouseLeave");
    }

    // The pointer rested over the panel for a moment
    private void targetPanel_MouseHover(object sender, EventArgs e)
    {
        Log("MouseHover");
    }

    // The pointer moved while inside the panel.
    // (Not added to the list, because it happens many times a second.)
    private void targetPanel_MouseMove(object sender, MouseEventArgs e)
    {
        positionLabel.Text = "X: " + e.X + "    Y: " + e.Y;
    }

    // A mouse button was PRESSED inside the panel
    private void targetPanel_MouseDown(object sender, MouseEventArgs e)
    {
        Log("MouseDown  (" + e.Button + " button)");
    }

    // A mouse button was RELEASED inside the panel
    private void targetPanel_MouseUp(object sender, MouseEventArgs e)
    {
        Log("MouseUp  (" + e.Button + " button)");
    }

    // The user CLICKED inside the panel.
    // e.X and e.Y tell you exactly where the click happened.
    private void targetPanel_MouseClick(object sender, MouseEventArgs e)
    {
        Log("MouseClick at X=" + e.X + ", Y=" + e.Y);
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        eventListBox.Items.Clear();
    }
}
