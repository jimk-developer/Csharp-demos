namespace Guide12Examples.Examples;

// =====================================================================
// GUIDE 12 - SECTION 5: Grouping Controls
// ---------------------------------------------------------------------
// Lecture flow:
//  1. GroupBox: caption (Text) YES, scroll bars NO.
//     Panel:    caption NO,        scroll bars YES (AutoScroll).
//  2. Radio buttons are mutually exclusive only within the SAME container.
//     Two GroupBoxes = two independent groups (3 colors + 4 sizes,
//     test question 64). Pick a color AND a size.
//  3. Click "Put all 7 radio buttons in ONE GroupBox" to see what happens
//     without separate containers: only one of the seven can be chosen.
//  4. In the designer: drag the GroupBox first, then drag RadioButtons
//     onto it. Drag the GroupBox around: its radio buttons move with it.
//  5. Shared event handlers: instead of one handler per control, the
//     constructor connects every radio button (and every add-on check box)
//     to ONE handler with +=.
// =====================================================================
public partial class Example05GroupingForm : Form
{
    private readonly RadioButton[] colorRadioButtons;
    private readonly RadioButton[] sizeRadioButtons;
    private bool isMerged;

    public Example05GroupingForm()
    {
        InitializeComponent();

        colorRadioButtons = new[] { redRadioButton, blueRadioButton, blackRadioButton };
        sizeRadioButtons = new[] { smallRadioButton, mediumRadioButton, largeRadioButton, xLargeRadioButton };

        // Connect many controls to one shared handler.
        foreach (RadioButton radioButton in colorRadioButtons.Concat(sizeRadioButtons))
        {
            radioButton.CheckedChanged += AnyRadioButton_CheckedChanged;
        }

        foreach (CheckBox addOnCheckBox in optionsPanel.Controls.OfType<CheckBox>())
        {
            addOnCheckBox.CheckedChanged += AddOnCheckBox_CheckedChanged;
        }

        UpdateSelectionLabel();
    }

    private void AnyRadioButton_CheckedChanged(object? sender, EventArgs e)
    {
        UpdateSelectionLabel();
    }

    private void AddOnCheckBox_CheckedChanged(object? sender, EventArgs e)
    {
        List<string> checkedAddOns = optionsPanel.Controls
            .OfType<CheckBox>()
            .Where(checkBox => checkBox.Checked)
            .Select(checkBox => checkBox.Text)
            .ToList();

        addOnsLabel.Text = $"Add-ons checked in the Panel: {checkedAddOns.Count}   " +
                           string.Join(", ", checkedAddOns);
    }

    // Moves the four size radio buttons into the color GroupBox (and back)
    // to prove that the container decides which radio buttons form a group.
    private void mergeButton_Click(object sender, EventArgs e)
    {
        isMerged = !isMerged;

        foreach (RadioButton sizeRadioButton in sizeRadioButtons)
        {
            if (isMerged)
            {
                // Adding a control to a new container removes it from the old one.
                colorGroupBox.Controls.Add(sizeRadioButton);
                sizeRadioButton.Left = 130;
            }
            else
            {
                sizeGroupBox.Controls.Add(sizeRadioButton);
                sizeRadioButton.Left = 16;
            }
        }

        if (isMerged)
        {
            colorGroupBox.Text = "Color AND Size (now ONE group!)";
            colorGroupBox.Width = 492;
            sizeGroupBox.Visible = false;
            mergeButton.Text = "&Put them back into TWO GroupBoxes";
        }
        else
        {
            colorGroupBox.Text = "Color";
            colorGroupBox.Width = 240;
            sizeGroupBox.Visible = true;
            mergeButton.Text = "&Put all 7 radio buttons in ONE GroupBox";

            // Make sure each group has a selection again.
            if (!colorRadioButtons.Any(r => r.Checked)) redRadioButton.Checked = true;
            if (!sizeRadioButtons.Any(r => r.Checked)) mediumRadioButton.Checked = true;
        }

        UpdateSelectionLabel();
    }

    private void UpdateSelectionLabel()
    {
        string color = colorRadioButtons.FirstOrDefault(r => r.Checked)?.Text.Replace("&", "") ?? "(none)";
        string size = sizeRadioButtons.FirstOrDefault(r => r.Checked)?.Text.Replace("&", "") ?? "(none)";

        selectionLabel.Text = $"You chose:  Color = {color}   |   Size = {size}";
    }
}
