namespace Guide12Examples.Examples;

partial class Example04SelectionControlsForm
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
        itemLabel = new Label();
        extrasTitleLabel = new Label();
        warrantyCheckBox = new CheckBox();
        carryingCaseCheckBox = new CheckBox();
        giftWrapCheckBox = new CheckBox();
        shippingTitleLabel = new Label();
        standardRadioButton = new RadioButton();
        expressRadioButton = new RadioButton();
        totalLabel = new Label();
        eventLogTitleLabel = new Label();
        eventLogTextBox = new TextBox();
        clearLogButton = new Button();
        familyButton = new Button();
        familyLabel = new Label();
        namingNoteLabel = new Label();
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
        headerLabel.Text = "Guide 12  |  Section 4  |  Selection Controls";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // itemLabel
        // 
        itemLabel.AutoSize = true;
        itemLabel.Font = new Font("Segoe UI", 10F);
        itemLabel.Location = new Point(12, 62);
        itemLabel.Name = "itemLabel";
        itemLabel.TabIndex = 1;
        itemLabel.Text = "Item: Ranken Tech Toolkit  -  base price $120.00";
        // 
        // extrasTitleLabel
        // 
        extrasTitleLabel.AutoSize = true;
        extrasTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        extrasTitleLabel.Location = new Point(12, 96);
        extrasTitleLabel.Name = "extrasTitleLabel";
        extrasTitleLabel.TabIndex = 2;
        extrasTitleLabel.Text = "Extras  (CheckBox: any number, even none)";
        // 
        // warrantyCheckBox
        // 
        warrantyCheckBox.AutoSize = true;
        warrantyCheckBox.Location = new Point(24, 120);
        warrantyCheckBox.Name = "warrantyCheckBox";
        warrantyCheckBox.TabIndex = 3;
        warrantyCheckBox.Text = "&Warranty (+$25.00)";
        warrantyCheckBox.UseVisualStyleBackColor = true;
        warrantyCheckBox.CheckedChanged += warrantyCheckBox_CheckedChanged;
        // 
        // carryingCaseCheckBox
        // 
        carryingCaseCheckBox.AutoSize = true;
        carryingCaseCheckBox.Location = new Point(24, 146);
        carryingCaseCheckBox.Name = "carryingCaseCheckBox";
        carryingCaseCheckBox.TabIndex = 4;
        carryingCaseCheckBox.Text = "Carrying &case (+$15.00)";
        carryingCaseCheckBox.UseVisualStyleBackColor = true;
        carryingCaseCheckBox.CheckedChanged += carryingCaseCheckBox_CheckedChanged;
        // 
        // giftWrapCheckBox
        // 
        giftWrapCheckBox.AutoSize = true;
        giftWrapCheckBox.Location = new Point(24, 172);
        giftWrapCheckBox.Name = "giftWrapCheckBox";
        giftWrapCheckBox.TabIndex = 5;
        giftWrapCheckBox.Text = "&Gift wrap (+$5.00)";
        giftWrapCheckBox.UseVisualStyleBackColor = true;
        giftWrapCheckBox.CheckedChanged += giftWrapCheckBox_CheckedChanged;
        // 
        // shippingTitleLabel
        // 
        shippingTitleLabel.AutoSize = true;
        shippingTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        shippingTitleLabel.Location = new Point(12, 206);
        shippingTitleLabel.Name = "shippingTitleLabel";
        shippingTitleLabel.TabIndex = 6;
        shippingTitleLabel.Text = "Shipping  (RadioButton: exactly one at a time)";
        // 
        // standardRadioButton
        // 
        standardRadioButton.AutoSize = true;
        standardRadioButton.Checked = true;
        standardRadioButton.Location = new Point(24, 230);
        standardRadioButton.Name = "standardRadioButton";
        standardRadioButton.TabIndex = 7;
        standardRadioButton.TabStop = true;
        standardRadioButton.Text = "&Standard shipping (free)";
        standardRadioButton.UseVisualStyleBackColor = true;
        standardRadioButton.CheckedChanged += standardRadioButton_CheckedChanged;
        // 
        // expressRadioButton
        // 
        expressRadioButton.AutoSize = true;
        expressRadioButton.Location = new Point(24, 256);
        expressRadioButton.Name = "expressRadioButton";
        expressRadioButton.TabIndex = 8;
        expressRadioButton.TabStop = true;
        expressRadioButton.Text = "E&xpress shipping (+$35.00)";
        expressRadioButton.UseVisualStyleBackColor = true;
        expressRadioButton.CheckedChanged += expressRadioButton_CheckedChanged;
        // 
        // totalLabel
        // 
        totalLabel.AutoSize = true;
        totalLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        totalLabel.ForeColor = Color.FromArgb(124, 45, 18);
        totalLabel.Location = new Point(12, 294);
        totalLabel.Name = "totalLabel";
        totalLabel.TabIndex = 9;
        totalLabel.Text = "Order total: $120.00";
        // 
        // eventLogTitleLabel
        // 
        eventLogTitleLabel.AutoSize = true;
        eventLogTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        eventLogTitleLabel.Location = new Point(400, 96);
        eventLogTitleLabel.Name = "eventLogTitleLabel";
        eventLogTitleLabel.TabIndex = 10;
        eventLogTitleLabel.Text = "CheckedChanged event log";
        // 
        // eventLogTextBox
        // 
        eventLogTextBox.BackColor = Color.White;
        eventLogTextBox.Font = new Font("Consolas", 9F);
        eventLogTextBox.Location = new Point(400, 118);
        eventLogTextBox.Multiline = true;
        eventLogTextBox.Name = "eventLogTextBox";
        eventLogTextBox.ReadOnly = true;
        eventLogTextBox.ScrollBars = ScrollBars.Vertical;
        eventLogTextBox.Size = new Size(372, 200);
        eventLogTextBox.TabIndex = 11;
        // 
        // clearLogButton
        // 
        clearLogButton.Location = new Point(400, 326);
        clearLogButton.Name = "clearLogButton";
        clearLogButton.Size = new Size(120, 30);
        clearLogButton.TabIndex = 12;
        clearLogButton.Text = "C&lear log";
        clearLogButton.UseVisualStyleBackColor = true;
        clearLogButton.Click += clearLogButton_Click;
        // 
        // familyButton
        // 
        familyButton.Location = new Point(530, 326);
        familyButton.Name = "familyButton";
        familyButton.Size = new Size(242, 30);
        familyButton.TabIndex = 13;
        familyButton.Text = "Show &ButtonBase family";
        familyButton.UseVisualStyleBackColor = true;
        familyButton.Click += familyButton_Click;
        // 
        // familyLabel
        // 
        familyLabel.BorderStyle = BorderStyle.FixedSingle;
        familyLabel.Font = new Font("Consolas", 9F);
        familyLabel.Location = new Point(12, 368);
        familyLabel.Name = "familyLabel";
        familyLabel.Size = new Size(760, 76);
        familyLabel.TabIndex = 14;
        familyLabel.Text = "Click \"Show ButtonBase family\" to see what Button, CheckBox, and RadioButton have in common.";
        // 
        // namingNoteLabel
        // 
        namingNoteLabel.ForeColor = Color.DimGray;
        namingNoteLabel.Location = new Point(12, 452);
        namingNoteLabel.Name = "namingNoteLabel";
        namingNoteLabel.Size = new Size(760, 36);
        namingNoteLabel.TabIndex = 15;
        namingNoteLabel.Text = "Every control was renamed with its (Name) property BEFORE double-clicking it (warrantyCheckBox, not checkBox1).\r\nThe & in each Text value makes an access key: press Alt + the underlined letter.";
        // 
        // Example04SelectionControlsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 496);
        Controls.Add(namingNoteLabel);
        Controls.Add(familyLabel);
        Controls.Add(familyButton);
        Controls.Add(clearLogButton);
        Controls.Add(eventLogTextBox);
        Controls.Add(eventLogTitleLabel);
        Controls.Add(totalLabel);
        Controls.Add(expressRadioButton);
        Controls.Add(standardRadioButton);
        Controls.Add(shippingTitleLabel);
        Controls.Add(giftWrapCheckBox);
        Controls.Add(carryingCaseCheckBox);
        Controls.Add(warrantyCheckBox);
        Controls.Add(extrasTitleLabel);
        Controls.Add(itemLabel);
        Controls.Add(headerLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Example04SelectionControlsForm";
        Text = "Example 04 - Selection Controls";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Label itemLabel;
    private Label extrasTitleLabel;
    private CheckBox warrantyCheckBox;
    private CheckBox carryingCaseCheckBox;
    private CheckBox giftWrapCheckBox;
    private Label shippingTitleLabel;
    private RadioButton standardRadioButton;
    private RadioButton expressRadioButton;
    private Label totalLabel;
    private Label eventLogTitleLabel;
    private TextBox eventLogTextBox;
    private Button clearLogButton;
    private Button familyButton;
    private Label familyLabel;
    private Label namingNoteLabel;
}
