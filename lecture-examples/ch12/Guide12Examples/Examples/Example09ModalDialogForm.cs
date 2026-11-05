namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 9: A secondary form shown with ShowDialog() (MODAL)
// ---------------------------------------------------------------------
// A modal window takes control of the program: the user cannot use the
// form that opened it until this one closes.
//  - okButton.DialogResult = OK and cancelButton.DialogResult = Cancel
//    (set in the Properties window). Clicking either one closes the form
//    and becomes the value that ShowDialog() returns.
//  - AcceptButton = okButton (Enter key); CancelButton = cancelButton (Esc).
// =====================================================================
public partial class Example09ModalDialogForm : Form
{
    public Example09ModalDialogForm()
    {
        InitializeComponent();
    }

    /// <summary>Lets the calling form read what the user typed after ShowDialog() returns.</summary>
    public string StudentName => nameTextBox.Text.Trim();
}
