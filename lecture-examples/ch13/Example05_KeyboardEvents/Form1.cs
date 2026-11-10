// =====================================================================
//  EXAMPLE 5: Keyboard Events (Key Events)
//
//  Key ideas:
//   - An event caused by the keyboard is called a KEY EVENT.
//   - KeyDown uses the KeyEventHandler delegate and sends a
//     KeyEventArgs object:
//         e.KeyCode  the key itself (for example, A)
//         e.KeyData  the key PLUS any modifier keys (for example, A, Shift)
//   - KeyPress uses the KeyPressEventHandler delegate and sends a
//     KeyPressEventArgs object:
//         e.KeyChar  the character that was typed (for example, 'a')
//
//  Try this:
//   1. In the top box, type a few letters, then hold Shift or Ctrl
//      while pressing a letter. Compare KeyCode and KeyData.
//   2. Press Enter to "search."
//   3. In the bottom box, try typing letters. Only digits are allowed.
// =====================================================================

namespace Example05_KeyboardEvents;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // KeyDown: runs when any key is pressed down in searchTextBox
    private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        keyInfoLabel.Text = "KeyCode: " + e.KeyCode + "        KeyData: " + e.KeyData;

        // KeyData includes modifier keys, so Shift+Enter will NOT match.
        if (e.KeyData == Keys.Enter)
        {
            resultLabel.Text = "Searching for: " + searchTextBox.Text;

            // Stops the Windows "ding" sound when Enter is pressed
            e.SuppressKeyPress = true;
        }
    }

    // KeyPress: runs when a character key is typed in ageTextBox
    private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        // '\b' is the Backspace character. Allow it so users can erase.
        if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
        {
            ageMessageLabel.Text = "";
        }
        else
        {
            // Handled = true means "ignore this key";
            // the character will not appear in the TextBox.
            e.Handled = true;
            ageMessageLabel.Text = "'" + e.KeyChar + "' is not a digit.";
        }
    }
}
