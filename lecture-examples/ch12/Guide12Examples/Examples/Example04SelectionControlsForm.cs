namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 4: Selection Controls
// ---------------------------------------------------------------------
// Lecture flow:
//  1. CheckBox    = independent options; select any number (even none).
//     RadioButton = mutually exclusive; only ONE per group (container).
//  2. Button, CheckBox, and RadioButton all descend from ButtonBase.
//     -> click "Show ButtonBase family".
//  3. Checked (bool, read/write) tells you whether the control is selected.
//  4. CheckedChanged is the DEFAULT EVENT for both CheckBox and
//     RadioButton (double-click either one in the designer).
//     -> Watch the event log: switching radio buttons fires CheckedChanged
//        TWICE (once for the button turning off, once for the one turning on).
//        That is why the guide's example needs the else branch.
//  5. Text property = string shown to the right of the button.
//     & in Text = access key (Alt + letter). Try Alt+X for Express.
//  6. Rename controls with (Name) in the Properties window BEFORE
//     double-clicking, so handlers get meaningful names.
// =====================================================================
public partial class Example04SelectionControlsForm : Form
{
    // The guide uses double to match the test questions.
    // (In real money code, prefer decimal.)
    private const double BASE_COST = 120.00;
    private const double WARRANTY_FEE = 25.00;
    private const double CARRYING_CASE_FEE = 15.00;
    private const double GIFT_WRAP_FEE = 5.00;

    private double orderCost = BASE_COST;

    public Example04SelectionControlsForm()
    {
        InitializeComponent();
        UpdateTotal();
    }

    // ----- CheckBox: any number can be checked ------------------------

    private void warrantyCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (warrantyCheckBox.Checked)
        {
            orderCost += WARRANTY_FEE;
        }
        else
        {
            orderCost -= WARRANTY_FEE;
        }

        LogEvent(nameof(warrantyCheckBox), warrantyCheckBox.Checked);
        UpdateTotal();
    }

    private void carryingCaseCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (carryingCaseCheckBox.Checked)
        {
            orderCost += CARRYING_CASE_FEE;
        }
        else
        {
            orderCost -= CARRYING_CASE_FEE;
        }

        LogEvent(nameof(carryingCaseCheckBox), carryingCaseCheckBox.Checked);
        UpdateTotal();
    }

    private void giftWrapCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (giftWrapCheckBox.Checked)
        {
            orderCost += GIFT_WRAP_FEE;
        }
        else
        {
            orderCost -= GIFT_WRAP_FEE;
        }

        LogEvent(nameof(giftWrapCheckBox), giftWrapCheckBox.Checked);
        UpdateTotal();
    }

    // ----- RadioButton: only one in the group can be checked ----------

    private void standardRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        // Standard shipping is free, so nothing to add; we just log the event.
        LogEvent(nameof(standardRadioButton), standardRadioButton.Checked);
    }

    // This is the example from Guide 12 (and test question 54).
    private void expressRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        const double EXPRESS_FEE = 35.00;

        if (expressRadioButton.Checked)
        {
            orderCost += EXPRESS_FEE;
        }
        else
        {
            orderCost -= EXPRESS_FEE;
        }

        LogEvent(nameof(expressRadioButton), expressRadioButton.Checked);
        UpdateTotal();
    }

    // ----- ButtonBase family -----------------------------------------

    private void familyButton_Click(object sender, EventArgs e)
    {
        familyLabel.Text =
            $"typeof(Button).BaseType      = {typeof(Button).BaseType!.Name}\r\n" +
            $"typeof(CheckBox).BaseType    = {typeof(CheckBox).BaseType!.Name}\r\n" +
            $"typeof(RadioButton).BaseType = {typeof(RadioButton).BaseType!.Name}\r\n" +
            $"warrantyCheckBox is ButtonBase? {warrantyCheckBox is ButtonBase}    " +
            $"expressRadioButton is ButtonBase? {expressRadioButton is ButtonBase}";
    }

    private void clearLogButton_Click(object sender, EventArgs e)
    {
        eventLogTextBox.Clear();
    }

    // ----- Helpers ---------------------------------------------------

    private void LogEvent(string controlName, bool isChecked)
    {
        eventLogTextBox.AppendText($"{controlName}.Checked = {isChecked}\r\n");
    }

    private void UpdateTotal()
    {
        totalLabel.Text = $"Order total: {orderCost:C}";
    }
}
