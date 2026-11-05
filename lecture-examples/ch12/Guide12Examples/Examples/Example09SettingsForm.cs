namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 9: A secondary form shown with Show() (NON-MODAL)
// ---------------------------------------------------------------------
// The example form creates this form and calls settingsForm.Show().
// Because it is non-modal, the user can switch back and forth between
// the two forms. This form changes the other form while both are open.
// =====================================================================
public partial class Example09SettingsForm : Form
{
    // The form whose background this settings form changes.
    private readonly Form targetForm;

    public Example09SettingsForm(Form targetForm)
    {
        InitializeComponent();
        this.targetForm = targetForm;
    }

    // One handler shared by the three theme radio buttons.
    private void ThemeRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton radioButton = (RadioButton)sender;

        if (!radioButton.Checked || targetForm.IsDisposed)
        {
            return;
        }

        targetForm.BackColor = (string)radioButton.Tag! switch
        {
            "Warm" => Color.FromArgb(255, 237, 213),
            "Calm" => Color.AliceBlue,
            _ => SystemColors.Control
        };
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
