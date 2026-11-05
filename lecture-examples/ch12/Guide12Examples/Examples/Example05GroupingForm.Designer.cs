namespace Guide12Examples.Examples;

partial class Example05GroupingForm
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
        groupBoxCaptionLabel = new Label();
        panelCaptionLabel = new Label();
        colorGroupBox = new GroupBox();
        redRadioButton = new RadioButton();
        blueRadioButton = new RadioButton();
        blackRadioButton = new RadioButton();
        sizeGroupBox = new GroupBox();
        smallRadioButton = new RadioButton();
        mediumRadioButton = new RadioButton();
        largeRadioButton = new RadioButton();
        xLargeRadioButton = new RadioButton();
        optionsPanel = new Panel();
        embroideryCheckBox = new CheckBox();
        giftBoxCheckBox = new CheckBox();
        rushOrderCheckBox = new CheckBox();
        extraPocketCheckBox = new CheckBox();
        longSleevesCheckBox = new CheckBox();
        moistureWickingCheckBox = new CheckBox();
        nameOnBackCheckBox = new CheckBox();
        numberOnBackCheckBox = new CheckBox();
        teamLogoCheckBox = new CheckBox();
        matchingHatCheckBox = new CheckBox();
        selectionLabel = new Label();
        addOnsLabel = new Label();
        mergeButton = new Button();
        noteLabel = new Label();
        colorGroupBox.SuspendLayout();
        sizeGroupBox.SuspendLayout();
        optionsPanel.SuspendLayout();
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
        headerLabel.Text = "Guide 12  |  Section 5  |  Grouping Controls";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // groupBoxCaptionLabel
        // 
        groupBoxCaptionLabel.AutoSize = true;
        groupBoxCaptionLabel.Location = new Point(12, 58);
        groupBoxCaptionLabel.Name = "groupBoxCaptionLabel";
        groupBoxCaptionLabel.TabIndex = 1;
        groupBoxCaptionLabel.Text = "GroupBox: shows a caption, no scroll bars";
        // 
        // panelCaptionLabel
        // 
        panelCaptionLabel.AutoSize = true;
        panelCaptionLabel.Location = new Point(520, 58);
        panelCaptionLabel.Name = "panelCaptionLabel";
        panelCaptionLabel.TabIndex = 2;
        panelCaptionLabel.Text = "Panel: scroll bars, but no caption";
        // 
        // colorGroupBox
        // 
        colorGroupBox.Controls.Add(redRadioButton);
        colorGroupBox.Controls.Add(blueRadioButton);
        colorGroupBox.Controls.Add(blackRadioButton);
        colorGroupBox.Location = new Point(12, 80);
        colorGroupBox.Name = "colorGroupBox";
        colorGroupBox.Size = new Size(240, 156);
        colorGroupBox.TabIndex = 3;
        colorGroupBox.TabStop = false;
        colorGroupBox.Text = "Color";
        // 
        // redRadioButton
        // 
        redRadioButton.AutoSize = true;
        redRadioButton.Checked = true;
        redRadioButton.Location = new Point(16, 28);
        redRadioButton.Name = "redRadioButton";
        redRadioButton.TabIndex = 4;
        redRadioButton.TabStop = true;
        redRadioButton.Text = "&Red";
        redRadioButton.UseVisualStyleBackColor = true;
        // 
        // blueRadioButton
        // 
        blueRadioButton.AutoSize = true;
        blueRadioButton.Location = new Point(16, 56);
        blueRadioButton.Name = "blueRadioButton";
        blueRadioButton.TabIndex = 5;
        blueRadioButton.TabStop = true;
        blueRadioButton.Text = "&Blue";
        blueRadioButton.UseVisualStyleBackColor = true;
        // 
        // blackRadioButton
        // 
        blackRadioButton.AutoSize = true;
        blackRadioButton.Location = new Point(16, 84);
        blackRadioButton.Name = "blackRadioButton";
        blackRadioButton.TabIndex = 6;
        blackRadioButton.TabStop = true;
        blackRadioButton.Text = "Blac&k";
        blackRadioButton.UseVisualStyleBackColor = true;
        // 
        // sizeGroupBox
        // 
        sizeGroupBox.Controls.Add(smallRadioButton);
        sizeGroupBox.Controls.Add(mediumRadioButton);
        sizeGroupBox.Controls.Add(largeRadioButton);
        sizeGroupBox.Controls.Add(xLargeRadioButton);
        sizeGroupBox.Location = new Point(264, 80);
        sizeGroupBox.Name = "sizeGroupBox";
        sizeGroupBox.Size = new Size(240, 156);
        sizeGroupBox.TabIndex = 7;
        sizeGroupBox.TabStop = false;
        sizeGroupBox.Text = "Size";
        // 
        // smallRadioButton
        // 
        smallRadioButton.AutoSize = true;
        smallRadioButton.Location = new Point(16, 28);
        smallRadioButton.Name = "smallRadioButton";
        smallRadioButton.TabIndex = 8;
        smallRadioButton.TabStop = true;
        smallRadioButton.Text = "&Small";
        smallRadioButton.UseVisualStyleBackColor = true;
        // 
        // mediumRadioButton
        // 
        mediumRadioButton.AutoSize = true;
        mediumRadioButton.Checked = true;
        mediumRadioButton.Location = new Point(16, 56);
        mediumRadioButton.Name = "mediumRadioButton";
        mediumRadioButton.TabIndex = 9;
        mediumRadioButton.TabStop = true;
        mediumRadioButton.Text = "&Medium";
        mediumRadioButton.UseVisualStyleBackColor = true;
        // 
        // largeRadioButton
        // 
        largeRadioButton.AutoSize = true;
        largeRadioButton.Location = new Point(16, 84);
        largeRadioButton.Name = "largeRadioButton";
        largeRadioButton.TabIndex = 10;
        largeRadioButton.TabStop = true;
        largeRadioButton.Text = "&Large";
        largeRadioButton.UseVisualStyleBackColor = true;
        // 
        // xLargeRadioButton
        // 
        xLargeRadioButton.AutoSize = true;
        xLargeRadioButton.Location = new Point(16, 112);
        xLargeRadioButton.Name = "xLargeRadioButton";
        xLargeRadioButton.TabIndex = 11;
        xLargeRadioButton.TabStop = true;
        xLargeRadioButton.Text = "X-Lar&ge";
        xLargeRadioButton.UseVisualStyleBackColor = true;
        // 
        // optionsPanel
        // 
        optionsPanel.Controls.Add(embroideryCheckBox);
        optionsPanel.Controls.Add(giftBoxCheckBox);
        optionsPanel.Controls.Add(rushOrderCheckBox);
        optionsPanel.Controls.Add(extraPocketCheckBox);
        optionsPanel.Controls.Add(longSleevesCheckBox);
        optionsPanel.Controls.Add(moistureWickingCheckBox);
        optionsPanel.Controls.Add(nameOnBackCheckBox);
        optionsPanel.Controls.Add(numberOnBackCheckBox);
        optionsPanel.Controls.Add(teamLogoCheckBox);
        optionsPanel.Controls.Add(matchingHatCheckBox);
        optionsPanel.AutoScroll = true;
        optionsPanel.BackColor = Color.White;
        optionsPanel.BorderStyle = BorderStyle.FixedSingle;
        optionsPanel.Location = new Point(520, 80);
        optionsPanel.Name = "optionsPanel";
        optionsPanel.Size = new Size(252, 156);
        optionsPanel.TabIndex = 12;
        // 
        // embroideryCheckBox
        // 
        embroideryCheckBox.AutoSize = true;
        embroideryCheckBox.Location = new Point(10, 8);
        embroideryCheckBox.Name = "embroideryCheckBox";
        embroideryCheckBox.TabIndex = 13;
        embroideryCheckBox.Text = "Embroidery";
        embroideryCheckBox.UseVisualStyleBackColor = true;
        // 
        // giftBoxCheckBox
        // 
        giftBoxCheckBox.AutoSize = true;
        giftBoxCheckBox.Location = new Point(10, 34);
        giftBoxCheckBox.Name = "giftBoxCheckBox";
        giftBoxCheckBox.TabIndex = 14;
        giftBoxCheckBox.Text = "Gift box";
        giftBoxCheckBox.UseVisualStyleBackColor = true;
        // 
        // rushOrderCheckBox
        // 
        rushOrderCheckBox.AutoSize = true;
        rushOrderCheckBox.Location = new Point(10, 60);
        rushOrderCheckBox.Name = "rushOrderCheckBox";
        rushOrderCheckBox.TabIndex = 15;
        rushOrderCheckBox.Text = "Rush order";
        rushOrderCheckBox.UseVisualStyleBackColor = true;
        // 
        // extraPocketCheckBox
        // 
        extraPocketCheckBox.AutoSize = true;
        extraPocketCheckBox.Location = new Point(10, 86);
        extraPocketCheckBox.Name = "extraPocketCheckBox";
        extraPocketCheckBox.TabIndex = 16;
        extraPocketCheckBox.Text = "Extra pocket";
        extraPocketCheckBox.UseVisualStyleBackColor = true;
        // 
        // longSleevesCheckBox
        // 
        longSleevesCheckBox.AutoSize = true;
        longSleevesCheckBox.Location = new Point(10, 112);
        longSleevesCheckBox.Name = "longSleevesCheckBox";
        longSleevesCheckBox.TabIndex = 17;
        longSleevesCheckBox.Text = "Long sleeves";
        longSleevesCheckBox.UseVisualStyleBackColor = true;
        // 
        // moistureWickingCheckBox
        // 
        moistureWickingCheckBox.AutoSize = true;
        moistureWickingCheckBox.Location = new Point(10, 138);
        moistureWickingCheckBox.Name = "moistureWickingCheckBox";
        moistureWickingCheckBox.TabIndex = 18;
        moistureWickingCheckBox.Text = "Moisture wicking";
        moistureWickingCheckBox.UseVisualStyleBackColor = true;
        // 
        // nameOnBackCheckBox
        // 
        nameOnBackCheckBox.AutoSize = true;
        nameOnBackCheckBox.Location = new Point(10, 164);
        nameOnBackCheckBox.Name = "nameOnBackCheckBox";
        nameOnBackCheckBox.TabIndex = 19;
        nameOnBackCheckBox.Text = "Name on back";
        nameOnBackCheckBox.UseVisualStyleBackColor = true;
        // 
        // numberOnBackCheckBox
        // 
        numberOnBackCheckBox.AutoSize = true;
        numberOnBackCheckBox.Location = new Point(10, 190);
        numberOnBackCheckBox.Name = "numberOnBackCheckBox";
        numberOnBackCheckBox.TabIndex = 20;
        numberOnBackCheckBox.Text = "Number on back";
        numberOnBackCheckBox.UseVisualStyleBackColor = true;
        // 
        // teamLogoCheckBox
        // 
        teamLogoCheckBox.AutoSize = true;
        teamLogoCheckBox.Location = new Point(10, 216);
        teamLogoCheckBox.Name = "teamLogoCheckBox";
        teamLogoCheckBox.TabIndex = 21;
        teamLogoCheckBox.Text = "Team logo";
        teamLogoCheckBox.UseVisualStyleBackColor = true;
        // 
        // matchingHatCheckBox
        // 
        matchingHatCheckBox.AutoSize = true;
        matchingHatCheckBox.Location = new Point(10, 242);
        matchingHatCheckBox.Name = "matchingHatCheckBox";
        matchingHatCheckBox.TabIndex = 22;
        matchingHatCheckBox.Text = "Matching hat";
        matchingHatCheckBox.UseVisualStyleBackColor = true;
        // 
        // selectionLabel
        // 
        selectionLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        selectionLabel.ForeColor = Color.FromArgb(124, 45, 18);
        selectionLabel.Location = new Point(12, 246);
        selectionLabel.Name = "selectionLabel";
        selectionLabel.Size = new Size(760, 26);
        selectionLabel.TabIndex = 23;
        selectionLabel.Text = "You chose:";
        // 
        // addOnsLabel
        // 
        addOnsLabel.Location = new Point(12, 274);
        addOnsLabel.Name = "addOnsLabel";
        addOnsLabel.Size = new Size(760, 22);
        addOnsLabel.TabIndex = 24;
        addOnsLabel.Text = "Add-ons checked in the Panel: 0";
        // 
        // mergeButton
        // 
        mergeButton.Location = new Point(12, 304);
        mergeButton.Name = "mergeButton";
        mergeButton.Size = new Size(360, 32);
        mergeButton.TabIndex = 25;
        mergeButton.Text = "&Put all 7 radio buttons in ONE GroupBox";
        mergeButton.UseVisualStyleBackColor = true;
        mergeButton.Click += mergeButton_Click;
        // 
        // noteLabel
        // 
        noteLabel.ForeColor = Color.DimGray;
        noteLabel.Location = new Point(12, 346);
        noteLabel.Name = "noteLabel";
        noteLabel.Size = new Size(760, 52);
        noteLabel.TabIndex = 26;
        noteLabel.Text = "Radio buttons are mutually exclusive only within the SAME container. To build a group in the designer, drag a\r\nGroupBox from the Toolbox first, then drag each RadioButton onto it. Moving the GroupBox now moves its radio\r\nbuttons as a unit. The Panel's ten check boxes do not fit, so the Panel adds a scroll bar (AutoScroll = true).";
        // 
        // Example05GroupingForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 406);
        Controls.Add(noteLabel);
        Controls.Add(mergeButton);
        Controls.Add(addOnsLabel);
        Controls.Add(selectionLabel);
        Controls.Add(optionsPanel);
        Controls.Add(sizeGroupBox);
        Controls.Add(colorGroupBox);
        Controls.Add(panelCaptionLabel);
        Controls.Add(groupBoxCaptionLabel);
        Controls.Add(headerLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Example05GroupingForm";
        Text = "Example 05 - Grouping Controls";
        colorGroupBox.ResumeLayout(false);
        colorGroupBox.PerformLayout();
        sizeGroupBox.ResumeLayout(false);
        sizeGroupBox.PerformLayout();
        optionsPanel.ResumeLayout(false);
        optionsPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Label groupBoxCaptionLabel;
    private Label panelCaptionLabel;
    private GroupBox colorGroupBox;
    private RadioButton redRadioButton;
    private RadioButton blueRadioButton;
    private RadioButton blackRadioButton;
    private GroupBox sizeGroupBox;
    private RadioButton smallRadioButton;
    private RadioButton mediumRadioButton;
    private RadioButton largeRadioButton;
    private RadioButton xLargeRadioButton;
    private Panel optionsPanel;
    private CheckBox embroideryCheckBox;
    private CheckBox giftBoxCheckBox;
    private CheckBox rushOrderCheckBox;
    private CheckBox extraPocketCheckBox;
    private CheckBox longSleevesCheckBox;
    private CheckBox moistureWickingCheckBox;
    private CheckBox nameOnBackCheckBox;
    private CheckBox numberOnBackCheckBox;
    private CheckBox teamLogoCheckBox;
    private CheckBox matchingHatCheckBox;
    private Label selectionLabel;
    private Label addOnsLabel;
    private Button mergeButton;
    private Label noteLabel;
}
