namespace Guide12Examples.Examples;

partial class Example03ColorForm
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
        orderNowButton = new Button();
        yellowBackButton = new Button();
        goldenrodBackButton = new Button();
        customColorButton = new Button();
        blackForeButton = new Button();
        whiteForeButton = new Button();
        resetColorsButton = new Button();
        codeLabel = new Label();
        contrastLabel = new Label();
        colorAloneTitleLabel = new Label();
        colorOnlyCaptionLabel = new Label();
        betterCaptionLabel = new Label();
        colorOnlyErrorLabel = new Label();
        colorOnlyOkLabel = new Label();
        betterErrorLabel = new Label();
        betterOkLabel = new Label();
        colorBlindTitleLabel = new Label();
        redSwatchLabel = new Label();
        greenSwatchLabel = new Label();
        blueSwatchLabel = new Label();
        purpleSwatchLabel = new Label();
        simulateButton = new Button();
        calmingBlueButton = new Button();
        noteLabel = new Label();
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
        headerLabel.Text = "Guide 12  |  Section 3  |  Color";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // orderNowButton
        // 
        orderNowButton.BackColor = SystemColors.Control;
        orderNowButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        orderNowButton.Location = new Point(12, 62);
        orderNowButton.Name = "orderNowButton";
        orderNowButton.Size = new Size(180, 68);
        orderNowButton.TabIndex = 1;
        orderNowButton.Text = "Order Now";
        orderNowButton.UseVisualStyleBackColor = false;
        // 
        // yellowBackButton
        // 
        yellowBackButton.Location = new Point(204, 62);
        yellowBackButton.Name = "yellowBackButton";
        yellowBackButton.Size = new Size(186, 32);
        yellowBackButton.TabIndex = 2;
        yellowBackButton.Text = "BackColor = Color.Yellow";
        yellowBackButton.UseVisualStyleBackColor = true;
        yellowBackButton.Click += yellowBackButton_Click;
        // 
        // goldenrodBackButton
        // 
        goldenrodBackButton.Location = new Point(396, 62);
        goldenrodBackButton.Name = "goldenrodBackButton";
        goldenrodBackButton.Size = new Size(186, 32);
        goldenrodBackButton.TabIndex = 3;
        goldenrodBackButton.Text = "BackColor = LightGoldenrodYellow";
        goldenrodBackButton.UseVisualStyleBackColor = true;
        goldenrodBackButton.Click += goldenrodBackButton_Click;
        // 
        // customColorButton
        // 
        customColorButton.Location = new Point(588, 62);
        customColorButton.Name = "customColorButton";
        customColorButton.Size = new Size(184, 32);
        customColorButton.TabIndex = 4;
        customColorButton.Text = "Custom: Color.FromArgb(...)";
        customColorButton.UseVisualStyleBackColor = true;
        customColorButton.Click += customColorButton_Click;
        // 
        // blackForeButton
        // 
        blackForeButton.Location = new Point(204, 98);
        blackForeButton.Name = "blackForeButton";
        blackForeButton.Size = new Size(186, 32);
        blackForeButton.TabIndex = 5;
        blackForeButton.Text = "ForeColor = Color.Black";
        blackForeButton.UseVisualStyleBackColor = true;
        blackForeButton.Click += blackForeButton_Click;
        // 
        // whiteForeButton
        // 
        whiteForeButton.Location = new Point(396, 98);
        whiteForeButton.Name = "whiteForeButton";
        whiteForeButton.Size = new Size(186, 32);
        whiteForeButton.TabIndex = 6;
        whiteForeButton.Text = "ForeColor = Color.White";
        whiteForeButton.UseVisualStyleBackColor = true;
        whiteForeButton.Click += whiteForeButton_Click;
        // 
        // resetColorsButton
        // 
        resetColorsButton.Location = new Point(588, 98);
        resetColorsButton.Name = "resetColorsButton";
        resetColorsButton.Size = new Size(184, 32);
        resetColorsButton.TabIndex = 7;
        resetColorsButton.Text = "&Reset colors";
        resetColorsButton.UseVisualStyleBackColor = true;
        resetColorsButton.Click += resetColorsButton_Click;
        // 
        // codeLabel
        // 
        codeLabel.Font = new Font("Consolas", 10F);
        codeLabel.ForeColor = Color.FromArgb(124, 45, 18);
        codeLabel.Location = new Point(12, 140);
        codeLabel.Name = "codeLabel";
        codeLabel.Size = new Size(760, 22);
        codeLabel.TabIndex = 8;
        codeLabel.Text = "// Click a button to change orderNowButton's colors.";
        // 
        // contrastLabel
        // 
        contrastLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        contrastLabel.Location = new Point(12, 164);
        contrastLabel.Name = "contrastLabel";
        contrastLabel.Size = new Size(760, 22);
        contrastLabel.TabIndex = 9;
        contrastLabel.Text = "Contrast:";
        // 
        // colorAloneTitleLabel
        // 
        colorAloneTitleLabel.AutoSize = true;
        colorAloneTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        colorAloneTitleLabel.Location = new Point(12, 196);
        colorAloneTitleLabel.Name = "colorAloneTitleLabel";
        colorAloneTitleLabel.TabIndex = 10;
        colorAloneTitleLabel.Text = "Never rely on color alone";
        // 
        // colorOnlyCaptionLabel
        // 
        colorOnlyCaptionLabel.AutoSize = true;
        colorOnlyCaptionLabel.Location = new Point(12, 218);
        colorOnlyCaptionLabel.Name = "colorOnlyCaptionLabel";
        colorOnlyCaptionLabel.TabIndex = 11;
        colorOnlyCaptionLabel.Text = "Color only: which one is the error?";
        // 
        // betterCaptionLabel
        // 
        betterCaptionLabel.AutoSize = true;
        betterCaptionLabel.Location = new Point(400, 218);
        betterCaptionLabel.Name = "betterCaptionLabel";
        betterCaptionLabel.TabIndex = 12;
        betterCaptionLabel.Text = "Better: color + text + symbol";
        // 
        // colorOnlyErrorLabel
        // 
        colorOnlyErrorLabel.BackColor = Color.Red;
        colorOnlyErrorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        colorOnlyErrorLabel.ForeColor = Color.White;
        colorOnlyErrorLabel.Location = new Point(12, 238);
        colorOnlyErrorLabel.Name = "colorOnlyErrorLabel";
        colorOnlyErrorLabel.Size = new Size(182, 40);
        colorOnlyErrorLabel.TabIndex = 13;
        colorOnlyErrorLabel.Text = "";
        colorOnlyErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // colorOnlyOkLabel
        // 
        colorOnlyOkLabel.BackColor = Color.Green;
        colorOnlyOkLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        colorOnlyOkLabel.ForeColor = Color.White;
        colorOnlyOkLabel.Location = new Point(202, 238);
        colorOnlyOkLabel.Name = "colorOnlyOkLabel";
        colorOnlyOkLabel.Size = new Size(182, 40);
        colorOnlyOkLabel.TabIndex = 14;
        colorOnlyOkLabel.Text = "";
        colorOnlyOkLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // betterErrorLabel
        // 
        betterErrorLabel.BackColor = Color.Red;
        betterErrorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        betterErrorLabel.ForeColor = Color.White;
        betterErrorLabel.Location = new Point(400, 238);
        betterErrorLabel.Name = "betterErrorLabel";
        betterErrorLabel.Size = new Size(182, 40);
        betterErrorLabel.TabIndex = 15;
        betterErrorLabel.Text = "✖ Error: card declined";
        betterErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // betterOkLabel
        // 
        betterOkLabel.BackColor = Color.Green;
        betterOkLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        betterOkLabel.ForeColor = Color.White;
        betterOkLabel.Location = new Point(590, 238);
        betterOkLabel.Name = "betterOkLabel";
        betterOkLabel.Size = new Size(182, 40);
        betterOkLabel.TabIndex = 16;
        betterOkLabel.Text = "✔ Saved successfully";
        betterOkLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // colorBlindTitleLabel
        // 
        colorBlindTitleLabel.AutoSize = true;
        colorBlindTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        colorBlindTitleLabel.Location = new Point(12, 292);
        colorBlindTitleLabel.Name = "colorBlindTitleLabel";
        colorBlindTitleLabel.TabIndex = 17;
        colorBlindTitleLabel.Text = "Red-green color blindness: red vs. green AND blue vs. purple are hard to tell apart";
        // 
        // redSwatchLabel
        // 
        redSwatchLabel.BackColor = Color.Red;
        redSwatchLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        redSwatchLabel.ForeColor = Color.White;
        redSwatchLabel.Location = new Point(12, 314);
        redSwatchLabel.Name = "redSwatchLabel";
        redSwatchLabel.Size = new Size(182, 50);
        redSwatchLabel.TabIndex = 18;
        redSwatchLabel.Text = "Red";
        redSwatchLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // greenSwatchLabel
        // 
        greenSwatchLabel.BackColor = Color.Green;
        greenSwatchLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        greenSwatchLabel.ForeColor = Color.White;
        greenSwatchLabel.Location = new Point(202, 314);
        greenSwatchLabel.Name = "greenSwatchLabel";
        greenSwatchLabel.Size = new Size(182, 50);
        greenSwatchLabel.TabIndex = 19;
        greenSwatchLabel.Text = "Green";
        greenSwatchLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // blueSwatchLabel
        // 
        blueSwatchLabel.BackColor = Color.CornflowerBlue;
        blueSwatchLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        blueSwatchLabel.ForeColor = Color.White;
        blueSwatchLabel.Location = new Point(392, 314);
        blueSwatchLabel.Name = "blueSwatchLabel";
        blueSwatchLabel.Size = new Size(182, 50);
        blueSwatchLabel.TabIndex = 20;
        blueSwatchLabel.Text = "Blue";
        blueSwatchLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // purpleSwatchLabel
        // 
        purpleSwatchLabel.BackColor = Color.MediumPurple;
        purpleSwatchLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        purpleSwatchLabel.ForeColor = Color.White;
        purpleSwatchLabel.Location = new Point(582, 314);
        purpleSwatchLabel.Name = "purpleSwatchLabel";
        purpleSwatchLabel.Size = new Size(190, 50);
        purpleSwatchLabel.TabIndex = 21;
        purpleSwatchLabel.Text = "Purple";
        purpleSwatchLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // simulateButton
        // 
        simulateButton.Location = new Point(12, 374);
        simulateButton.Name = "simulateButton";
        simulateButton.Size = new Size(280, 32);
        simulateButton.TabIndex = 22;
        simulateButton.Text = "&Simulate red-green color blindness";
        simulateButton.UseVisualStyleBackColor = true;
        simulateButton.Click += simulateButton_Click;
        // 
        // calmingBlueButton
        // 
        calmingBlueButton.Location = new Point(302, 374);
        calmingBlueButton.Name = "calmingBlueButton";
        calmingBlueButton.Size = new Size(220, 32);
        calmingBlueButton.TabIndex = 23;
        calmingBlueButton.Text = "Apply &calming blue theme";
        calmingBlueButton.UseVisualStyleBackColor = true;
        calmingBlueButton.Click += calmingBlueButton_Click;
        // 
        // noteLabel
        // 
        noteLabel.ForeColor = Color.DimGray;
        noteLabel.Location = new Point(12, 414);
        noteLabel.Name = "noteLabel";
        noteLabel.Size = new Size(760, 36);
        noteLabel.TabIndex = 24;
        noteLabel.Text = "The simulation is a classroom approximation (deuteranopia matrix). Notice that the \"color only\" boxes become hard to\r\ntell apart, while the boxes with text and a symbol still make sense.";
        // 
        // Example03ColorForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 458);
        Controls.Add(noteLabel);
        Controls.Add(calmingBlueButton);
        Controls.Add(simulateButton);
        Controls.Add(purpleSwatchLabel);
        Controls.Add(blueSwatchLabel);
        Controls.Add(greenSwatchLabel);
        Controls.Add(redSwatchLabel);
        Controls.Add(colorBlindTitleLabel);
        Controls.Add(betterOkLabel);
        Controls.Add(betterErrorLabel);
        Controls.Add(colorOnlyOkLabel);
        Controls.Add(colorOnlyErrorLabel);
        Controls.Add(betterCaptionLabel);
        Controls.Add(colorOnlyCaptionLabel);
        Controls.Add(colorAloneTitleLabel);
        Controls.Add(contrastLabel);
        Controls.Add(codeLabel);
        Controls.Add(resetColorsButton);
        Controls.Add(whiteForeButton);
        Controls.Add(blackForeButton);
        Controls.Add(customColorButton);
        Controls.Add(goldenrodBackButton);
        Controls.Add(yellowBackButton);
        Controls.Add(orderNowButton);
        Controls.Add(headerLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Example03ColorForm";
        Text = "Example 03 - Color";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Button orderNowButton;
    private Button yellowBackButton;
    private Button goldenrodBackButton;
    private Button customColorButton;
    private Button blackForeButton;
    private Button whiteForeButton;
    private Button resetColorsButton;
    private Label codeLabel;
    private Label contrastLabel;
    private Label colorAloneTitleLabel;
    private Label colorOnlyCaptionLabel;
    private Label betterCaptionLabel;
    private Label colorOnlyErrorLabel;
    private Label colorOnlyOkLabel;
    private Label betterErrorLabel;
    private Label betterOkLabel;
    private Label colorBlindTitleLabel;
    private Label redSwatchLabel;
    private Label greenSwatchLabel;
    private Label blueSwatchLabel;
    private Label purpleSwatchLabel;
    private Button simulateButton;
    private Button calmingBlueButton;
    private Label noteLabel;
}
