// =====================================================================
//  EXAMPLE 6: Managing Multiple Controls
//
//  Key ideas:
//   - FOCUS: the focused control has a thin box drawn around it.
//     Pressing Enter (or Space) makes the focused Button raise its
//     Click event.
//   - TabIndex sets the order controls get focus when you press Tab.
//     (Red = 0, Green = 1, Blue = 2. Red has the lowest number, so
//     it has focus when the Form opens.)
//   - TabStop = false means Tab skips that control (the Reset button).
//   - SHARED HANDLER: one method handles the Click event for all
//     three color buttons. The sender parameter tells you which one.
//   - ONE CONTROL, SEVERAL EVENTS: the Reset button has handlers for
//     Click, MouseEnter, and MouseLeave.
//
//  To share a handler in Visual Studio: select a Button, click the
//  lightning bolt in the Properties window, open the drop-down next
//  to Click, and pick an existing method.
// =====================================================================

namespace Example06_MultipleControls;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // SHARED Click handler for redButton, greenButton, and blueButton.
    private void colorButton_Click(object sender, EventArgs e)
    {
        // sender is the Button that raised the event
        Button clickedButton = (Button)sender;

        colorPanel.BackColor = clickedButton.BackColor;
        clickLabel.Text = "You clicked the " + clickedButton.Text + " button.";
    }

    // SHARED Enter handler for the three color buttons.
    // NOTE: the Enter EVENT means "this control just received focus."
    // It has nothing to do with the Enter KEY.
    private void colorButton_Enter(object sender, EventArgs e)
    {
        Button focusedButton = (Button)sender;
        focusLabel.Text = "Focus is on: " + focusedButton.Text +
                          "   (TabIndex " + focusedButton.TabIndex + ")";
    }

    // ---------------------------------------------------------------
    //  One control (resetButton) handling three different events
    // ---------------------------------------------------------------
    private void resetButton_Click(object sender, EventArgs e)
    {
        colorPanel.BackColor = Color.White;
        clickLabel.Text = "Colors reset.";
    }

    private void resetButton_MouseEnter(object sender, EventArgs e)
    {
        resetButton.Text = "Click to Reset!";
    }

    private void resetButton_MouseLeave(object sender, EventArgs e)
    {
        resetButton.Text = "Reset";
    }
}
