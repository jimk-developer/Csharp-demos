using Guide12Examples.Models;

namespace Guide12Examples;

/// <summary>
/// Launcher form. Builds one button per example from <see cref="ExampleCatalog"/>,
/// in the same order as the sections of Guide 12.
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        BuildExampleButtons();
    }

    private void BuildExampleButtons()
    {
        foreach (ExampleInfo example in ExampleCatalog.All)
        {
            // Controls can be created in code, too. This is the same kind of
            // statement the IDE writes for you in InitializeComponent().
            Button exampleButton = new Button
            {
                Text = $"Example {example.Number:00}  -  {example.Title}\r\n{example.Concepts}",
                Tag = example,
                Width = 580,
                Height = 50,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 0, 0),
                Margin = new Padding(0, 0, 0, 6),
                UseVisualStyleBackColor = true
            };

            exampleButton.Click += ExampleButton_Click;
            exampleFlowPanel.Controls.Add(exampleButton);
        }
    }

    // One handler shared by every example button; the Tag tells us which example to open.
    private void ExampleButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button { Tag: ExampleInfo example })
        {
            Form exampleForm = example.CreateForm();
            exampleForm.StartPosition = FormStartPosition.CenterScreen;
            exampleForm.Show();   // Non-modal: the launcher stays usable (see Example 09).
        }
    }
}
