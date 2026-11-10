// =====================================================================
//  EXAMPLE 1: Event Basics
//
//  Key ideas:
//   - Clicking the Button RAISES (fires) its Click event.
//   - The Button is the EVENT SENDER.
//   - clickMeButton_Click() is the EVENT HANDLER (also called the
//     event receiver).
//   - The line that connects the event to the handler is called
//     EVENT WIRING. Open Form1.Designer.cs to find it:
//         clickMeButton.Click += clickMeButton_Click;
//
//  Try this:
//   1. Click the button with the mouse.
//   2. Press Tab until the button has focus, then press the Space bar.
//      Compare what e.ToString() shows each time.
// =====================================================================

namespace Example01_EventBasics;

public partial class Form1 : Form
{
    private int clickCount = 0;

    public Form1()
    {
        InitializeComponent();
    }

    // Visual Studio created the shell of this method when the Button
    // was double-clicked in Design view.
    //   sender = the object that raised the event (the Button)
    //   e      = an EventArgs object that holds information about the event
    private void clickMeButton_Click(object sender, EventArgs e)
    {
        clickCount++;
        messageLabel.Text = "The button was clicked " + clickCount + " time(s).";

        // sender's type is object, so cast it to a Button to use
        // Button properties such as Name.
        Button clickedButton = (Button)sender;

        // Calling ToString() on e shows what type of event object it is.
        infoLabel.Text = "Sender name: " + clickedButton.Name + "\n" +
                         "e.ToString(): " + e.ToString();
    }
}
