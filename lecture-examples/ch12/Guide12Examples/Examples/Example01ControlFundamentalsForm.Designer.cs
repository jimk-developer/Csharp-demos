namespace Guide12Examples.Examples;

partial class Example01ControlFundamentalsForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        headerLabel = new Label();
        introLabel = new Label();
        sampleButton = new Button();
        sampleLabel = new Label();
        sampleTextBox = new TextBox();
        inspectButtonButton = new Button();
        inspectLabelButton = new Button();
        inspectTextBoxButton = new Button();
        inspectFormButton = new Button();
        outputTextBox = new TextBox();
        SuspendLayout();
        //
        // headerLabel
        //
        headerLabel.BackColor = Color.FromArgb(30, 27, 46);
        headerLabel.Dock = DockStyle.Top;
        headerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        headerLabel.ForeColor = Color.FromArgb(254, 215, 170);
        headerLabel.Location = new Point(0, 0);
        headerLabel.Name = "headerLabel";
        headerLabel.Padding = new Padding(12, 0, 0, 0);
        headerLabel.Size = new Size(784, 50);
        headerLabel.TabIndex = 0;
        headerLabel.Text = "Guide 12  |  Section 1  |  Control Fundamentals and IDE Code";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // introLabel
        //
        introLabel.Location = new Point(12, 58);
        introLabel.Name = "introLabel";
        introLabel.Size = new Size(760, 40);
        introLabel.TabIndex = 1;
        introLabel.Text = "Every widget below is a Control. Inspect one to see its family tree, its property count, and its default event.\r\nThen open this form's .Designer.cs file and find InitializeComponent().";
        //
        // sampleButton
        //
        sampleButton.Location = new Point(12, 104);
        sampleButton.Name = "sampleButton";
        sampleButton.Size = new Size(150, 30);
        sampleButton.TabIndex = 2;
        sampleButton.Text = "Sample Button";
        sampleButton.UseVisualStyleBackColor = true;
        sampleButton.Click += sampleButton_Click;
        //
        // sampleLabel
        //
        sampleLabel.AutoSize = true;
        sampleLabel.Location = new Point(180, 111);
        sampleLabel.Name = "sampleLabel";
        sampleLabel.Size = new Size(76, 15);
        sampleLabel.TabIndex = 3;
        sampleLabel.Text = "Sample Label";
        //
        // sampleTextBox
        //
        sampleTextBox.Location = new Point(300, 108);
        sampleTextBox.Name = "sampleTextBox";
        sampleTextBox.Size = new Size(170, 23);
        sampleTextBox.TabIndex = 4;
        sampleTextBox.Text = "Sample TextBox";
        //
        // inspectButtonButton
        //
        inspectButtonButton.Location = new Point(12, 146);
        inspectButtonButton.Name = "inspectButtonButton";
        inspectButtonButton.Size = new Size(140, 30);
        inspectButtonButton.TabIndex = 5;
        inspectButtonButton.Text = "Inspect &Button";
        inspectButtonButton.UseVisualStyleBackColor = true;
        inspectButtonButton.Click += inspectButtonButton_Click;
        //
        // inspectLabelButton
        //
        inspectLabelButton.Location = new Point(160, 146);
        inspectLabelButton.Name = "inspectLabelButton";
        inspectLabelButton.Size = new Size(140, 30);
        inspectLabelButton.TabIndex = 6;
        inspectLabelButton.Text = "Inspect &Label";
        inspectLabelButton.UseVisualStyleBackColor = true;
        inspectLabelButton.Click += inspectLabelButton_Click;
        //
        // inspectTextBoxButton
        //
        inspectTextBoxButton.Location = new Point(308, 146);
        inspectTextBoxButton.Name = "inspectTextBoxButton";
        inspectTextBoxButton.Size = new Size(140, 30);
        inspectTextBoxButton.TabIndex = 7;
        inspectTextBoxButton.Text = "Inspect &TextBox";
        inspectTextBoxButton.UseVisualStyleBackColor = true;
        inspectTextBoxButton.Click += inspectTextBoxButton_Click;
        //
        // inspectFormButton
        //
        inspectFormButton.Location = new Point(456, 146);
        inspectFormButton.Name = "inspectFormButton";
        inspectFormButton.Size = new Size(140, 30);
        inspectFormButton.TabIndex = 8;
        inspectFormButton.Text = "Inspect this &Form";
        inspectFormButton.UseVisualStyleBackColor = true;
        inspectFormButton.Click += inspectFormButton_Click;
        //
        // outputTextBox
        //
        outputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        outputTextBox.BackColor = Color.White;
        outputTextBox.Font = new Font("Consolas", 10F);
        outputTextBox.Location = new Point(12, 186);
        outputTextBox.Multiline = true;
        outputTextBox.Name = "outputTextBox";
        outputTextBox.ReadOnly = true;
        outputTextBox.ScrollBars = ScrollBars.Vertical;
        outputTextBox.Size = new Size(760, 314);
        outputTextBox.TabIndex = 9;
        //
        // Example01ControlFundamentalsForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 512);
        Controls.Add(outputTextBox);
        Controls.Add(inspectFormButton);
        Controls.Add(inspectTextBoxButton);
        Controls.Add(inspectLabelButton);
        Controls.Add(inspectButtonButton);
        Controls.Add(sampleTextBox);
        Controls.Add(sampleLabel);
        Controls.Add(sampleButton);
        Controls.Add(introLabel);
        Controls.Add(headerLabel);
        MinimumSize = new Size(640, 400);
        Name = "Example01ControlFundamentalsForm";
        Text = "Example 01 - Control Fundamentals and IDE Code";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Label introLabel;
    private Button sampleButton;
    private Label sampleLabel;
    private TextBox sampleTextBox;
    private Button inspectButtonButton;
    private Button inspectLabelButton;
    private Button inspectTextBoxButton;
    private Button inspectFormButton;
    private TextBox outputTextBox;
}
