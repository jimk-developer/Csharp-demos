using Guide12Examples.Models;

namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 7: List Controls
// ---------------------------------------------------------------------
// Lecture flow:
//  1. ListBox, ComboBox, and CheckedListBox all descend from ListControl.
//     -> click "Show ListControl family".
//       ListBox        = list the user clicks to select
//       ComboBox       = list + editing field (pick OR type new text)
//       CheckedListBox = list with a check box beside each item
//  2. Items: added in the designer with the String Collection Editor.
//     Open the .Designer.cs file to see the generated Items.AddRange(...).
//  3. Too many items to show? A scroll bar appears automatically.
//  4. Properties and methods:
//       MultiColumn   (bool)  columns instead of one vertical list
//       SelectionMode         None, One, MultiSimple, MultiExtended
//       SelectedItem          the item the user chose
//       Items.Count           how many items are in the list
//       GetSelected(index)    true/false: is the item at index selected?
//  5. SelectedIndexChanged is the ListBox's default event: put code there
//     to react when the user clicks a different item (updates the label
//     beneath the list).
// =====================================================================
public partial class Example07ListControlsForm : Form
{
    public Example07ListControlsForm()
    {
        InitializeComponent();
    }

    // ----- ListBox ---------------------------------------------------

    // DEFAULT EVENT for a ListBox
    private void coursesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (coursesListBox.SelectionMode == SelectionMode.One)
        {
            selectionLabel.Text =
                $"SelectedItem  = {coursesListBox.SelectedItem}\r\n" +
                $"SelectedIndex = {coursesListBox.SelectedIndex}";
        }
        else
        {
            // In the multi-select modes, SelectedItems holds every chosen item.
            selectionLabel.Text =
                $"{coursesListBox.SelectedItems.Count} selected:\r\n" +
                string.Join(", ", coursesListBox.SelectedItems.Cast<object>());
        }
    }

    private void multiColumnCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        coursesListBox.MultiColumn = multiColumnCheckBox.Checked;
        outputTextBox.Text = $"coursesListBox.MultiColumn = {coursesListBox.MultiColumn};";
    }

    // One handler shared by the four SelectionMode radio buttons.
    private void SelectionModeRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton radioButton = (RadioButton)sender;

        if (radioButton.Checked)
        {
            coursesListBox.SelectionMode = Enum.Parse<SelectionMode>((string)radioButton.Tag!);
            outputTextBox.Text = $"coursesListBox.SelectionMode = SelectionMode.{coursesListBox.SelectionMode};";
        }
    }

    private void countButton_Click(object sender, EventArgs e)
    {
        outputTextBox.Text =
            $"coursesListBox.Items.Count         = {coursesListBox.Items.Count}\r\n" +
            $"coursesListBox.SelectedItems.Count = {coursesListBox.SelectedItems.Count}";
    }

    private void getSelectedButton_Click(object sender, EventArgs e)
    {
        List<string> lines = new List<string>();

        for (int index = 0; index < coursesListBox.Items.Count; index++)
        {
            bool isSelected = coursesListBox.GetSelected(index);   // returns a bool
            lines.Add($"GetSelected({index,2}) = {isSelected,-5}  {coursesListBox.Items[index]}");
        }

        outputTextBox.Text = string.Join("\r\n", lines);
    }

    private void familyButton_Click(object sender, EventArgs e)
    {
        outputTextBox.Text =
            "ListBox        : " + FamilyOf(typeof(ListBox)) + "\r\n" +
            "ComboBox       : " + FamilyOf(typeof(ComboBox)) + "\r\n" +
            "CheckedListBox : " + FamilyOf(typeof(CheckedListBox));
    }

    // ----- ComboBox --------------------------------------------------

    private void scheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        comboResultLabel.Text = $"SelectedItem = {scheduleComboBox.SelectedItem}";
    }

    // The editing field lets the user type text that is not in the list yet.
    private void addScheduleButton_Click(object sender, EventArgs e)
    {
        string typedText = scheduleComboBox.Text.Trim();

        if (typedText.Length == 0)
        {
            comboResultLabel.Text = "Type something in the ComboBox first.";
        }
        else if (scheduleComboBox.Items.Contains(typedText))
        {
            comboResultLabel.Text = $"\"{typedText}\" is already in the list.";
        }
        else
        {
            scheduleComboBox.Items.Add(typedText);
            comboResultLabel.Text = $"Added \"{typedText}\". Items.Count is now {scheduleComboBox.Items.Count}.";
        }
    }

    // ----- CheckedListBox ---------------------------------------------

    // ItemCheck fires BEFORE the check mark changes, so e.NewValue tells us
    // what the item is about to become.
    private void toolsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        List<string> checkedTools = toolsCheckedListBox.CheckedItems.Cast<string>().ToList();
        string changedTool = (string)toolsCheckedListBox.Items[e.Index];

        if (e.NewValue == CheckState.Checked)
        {
            checkedTools.Add(changedTool);
        }
        else
        {
            checkedTools.Remove(changedTool);
        }

        toolsLabel.Text = $"Checked: {checkedTools.Count} item(s)\r\n{string.Join(", ", checkedTools)}";
    }

    // ----- Helpers ---------------------------------------------------

    private static string FamilyOf(Type type) =>
        string.Join(" -> ", ControlInspector.GetInheritanceChain(type)
            .TakeWhile(t => t != typeof(Control))
            .Select(t => t.Name)) + " -> Control";
}
