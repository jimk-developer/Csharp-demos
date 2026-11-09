namespace Demo3;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    // All 4 TextBoxes use this same handler for MouseClick.
    // "sender" is the TextBox that raised the event.
    private void TextBox_MouseClick(object sender, MouseEventArgs e)
    {
        TextBox box = (TextBox)sender;
        box.BackColor = Color.LightPink;
        ShowEvent("MouseClick on " + box.Name);
    }

    // Enter fires when a TextBox receives focus.
    private void TextBox_Enter(object sender, EventArgs e)
    {
        TextBox box = (TextBox)sender;
        box.BackColor = Color.LightGreen;
        ShowEvent("Enter on " + box.Name);
    }

    // Leave fires when a TextBox loses focus.
    private void TextBox_Leave(object sender, EventArgs e)
    {
        TextBox box = (TextBox)sender;
        box.BackColor = Color.White;
        ShowEvent("Leave on " + box.Name);
    }

    // KeyPreview is true, so the form sees every key press first,
    // no matter which TextBox has the focus.
    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F1)
        {
            txtBox1.Focus();
        }
        else if (e.KeyCode == Keys.F2)
        {
            txtBox2.Focus();
        }
        else if (e.KeyCode == Keys.F3)
        {
            txtBox3.Focus();
        }
        else if (e.KeyCode == Keys.F4)
        {
            txtBox4.Focus();
        }
    }

    private void ShowEvent(string name)
    {
        lblLastEvent.Text = "Last event: " + name;
    }
}
