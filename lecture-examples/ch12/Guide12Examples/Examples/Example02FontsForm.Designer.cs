namespace Guide12Examples.Examples;

partial class Example02FontsForm
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
        previewLabel = new Label();
        codeLabel = new Label();
        fontInfoLabel = new Label();
        constructorsTitleLabel = new Label();
        twoArgButton = new Button();
        calibriButton = new Button();
        threeArgButton = new Button();
        boldItalicButton = new Button();
        serifTitleLabel = new Label();
        serifLabel = new Label();
        sansSerifLabel = new Label();
        accessibleTitleLabel = new Label();
        helveticaButton = new Button();
        courierButton = new Button();
        arialButton = new Button();
        verdanaButton = new Button();
        decorativeButton = new Button();
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
        headerLabel.Text = "Guide 12  |  Section 2  |  Fonts";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // previewLabel
        //
        previewLabel.BackColor = Color.White;
        previewLabel.BorderStyle = BorderStyle.FixedSingle;
        previewLabel.Font = new Font("Segoe UI", 14F);
        previewLabel.Location = new Point(12, 60);
        previewLabel.Name = "previewLabel";
        previewLabel.Size = new Size(760, 90);
        previewLabel.TabIndex = 1;
        previewLabel.Text = "The quick brown fox jumps over the lazy dog.";
        previewLabel.TextAlign = ContentAlignment.MiddleCenter;
        //
        // codeLabel
        //
        codeLabel.Font = new Font("Consolas", 10F);
        codeLabel.ForeColor = Color.FromArgb(124, 45, 18);
        codeLabel.Location = new Point(12, 156);
        codeLabel.Name = "codeLabel";
        codeLabel.Size = new Size(760, 22);
        codeLabel.TabIndex = 2;
        codeLabel.Text = "// Click a button to run a Font constructor.";
        //
        // fontInfoLabel
        //
        fontInfoLabel.Location = new Point(12, 180);
        fontInfoLabel.Name = "fontInfoLabel";
        fontInfoLabel.Size = new Size(760, 20);
        fontInfoLabel.TabIndex = 3;
        fontInfoLabel.Text = "Result:";
        //
        // constructorsTitleLabel
        //
        constructorsTitleLabel.AutoSize = true;
        constructorsTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        constructorsTitleLabel.Location = new Point(12, 208);
        constructorsTitleLabel.Name = "constructorsTitleLabel";
        constructorsTitleLabel.Size = new Size(229, 15);
        constructorsTitleLabel.TabIndex = 4;
        constructorsTitleLabel.Text = "Overloaded Font constructors";
        //
        // twoArgButton
        //
        twoArgButton.Location = new Point(12, 230);
        twoArgButton.Name = "twoArgButton";
        twoArgButton.Size = new Size(185, 34);
        twoArgButton.TabIndex = 5;
        twoArgButton.Text = "new Font(\"Arial\", 10.5f)";
        twoArgButton.UseVisualStyleBackColor = true;
        twoArgButton.Click += twoArgButton_Click;
        //
        // calibriButton
        //
        calibriButton.Location = new Point(202, 230);
        calibriButton.Name = "calibriButton";
        calibriButton.Size = new Size(185, 34);
        calibriButton.TabIndex = 6;
        calibriButton.Text = "new Font(\"Calibri\", 14.5f)";
        calibriButton.UseVisualStyleBackColor = true;
        calibriButton.Click += calibriButton_Click;
        //
        // threeArgButton
        //
        threeArgButton.Location = new Point(392, 230);
        threeArgButton.Name = "threeArgButton";
        threeArgButton.Size = new Size(185, 34);
        threeArgButton.TabIndex = 7;
        threeArgButton.Text = "+ FontStyle.Bold (3 args)";
        threeArgButton.UseVisualStyleBackColor = true;
        threeArgButton.Click += threeArgButton_Click;
        //
        // boldItalicButton
        //
        boldItalicButton.Location = new Point(582, 230);
        boldItalicButton.Name = "boldItalicButton";
        boldItalicButton.Size = new Size(190, 34);
        boldItalicButton.TabIndex = 8;
        boldItalicButton.Text = "FontStyle.Bold | Italic";
        boldItalicButton.UseVisualStyleBackColor = true;
        boldItalicButton.Click += boldItalicButton_Click;
        //
        // serifTitleLabel
        //
        serifTitleLabel.AutoSize = true;
        serifTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        serifTitleLabel.Location = new Point(12, 276);
        serifTitleLabel.Name = "serifTitleLabel";
        serifTitleLabel.Size = new Size(125, 15);
        serifTitleLabel.TabIndex = 9;
        serifTitleLabel.Text = "Serif vs. sans serif";
        //
        // serifLabel
        //
        serifLabel.BackColor = Color.White;
        serifLabel.BorderStyle = BorderStyle.FixedSingle;
        serifLabel.Font = new Font("Times New Roman", 20F);
        serifLabel.Location = new Point(12, 298);
        serifLabel.Name = "serifLabel";
        serifLabel.Size = new Size(374, 56);
        serifLabel.TabIndex = 10;
        serifLabel.Text = "Serif: Times New Roman";
        serifLabel.TextAlign = ContentAlignment.MiddleCenter;
        //
        // sansSerifLabel
        //
        sansSerifLabel.BackColor = Color.White;
        sansSerifLabel.BorderStyle = BorderStyle.FixedSingle;
        sansSerifLabel.Font = new Font("Arial", 20F);
        sansSerifLabel.Location = new Point(398, 298);
        sansSerifLabel.Name = "sansSerifLabel";
        sansSerifLabel.Size = new Size(374, 56);
        sansSerifLabel.TabIndex = 11;
        sansSerifLabel.Text = "Sans serif: Arial";
        sansSerifLabel.TextAlign = ContentAlignment.MiddleCenter;
        //
        // accessibleTitleLabel
        //
        accessibleTitleLabel.AutoSize = true;
        accessibleTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        accessibleTitleLabel.Location = new Point(12, 366);
        accessibleTitleLabel.Name = "accessibleTitleLabel";
        accessibleTitleLabel.Size = new Size(252, 15);
        accessibleTitleLabel.TabIndex = 12;
        accessibleTitleLabel.Text = "Accessible fonts for messages to the user";
        //
        // helveticaButton
        //
        helveticaButton.Location = new Point(12, 388);
        helveticaButton.Name = "helveticaButton";
        helveticaButton.Size = new Size(145, 34);
        helveticaButton.TabIndex = 13;
        helveticaButton.Tag = "Helvetica";
        helveticaButton.Text = "Helvetica";
        helveticaButton.UseVisualStyleBackColor = true;
        helveticaButton.Click += AccessibleFontButton_Click;
        //
        // courierButton
        //
        courierButton.Location = new Point(162, 388);
        courierButton.Name = "courierButton";
        courierButton.Size = new Size(145, 34);
        courierButton.TabIndex = 14;
        courierButton.Tag = "Courier New";
        courierButton.Text = "Courier (New)";
        courierButton.UseVisualStyleBackColor = true;
        courierButton.Click += AccessibleFontButton_Click;
        //
        // arialButton
        //
        arialButton.Location = new Point(312, 388);
        arialButton.Name = "arialButton";
        arialButton.Size = new Size(145, 34);
        arialButton.TabIndex = 15;
        arialButton.Tag = "Arial";
        arialButton.Text = "Arial";
        arialButton.UseVisualStyleBackColor = true;
        arialButton.Click += AccessibleFontButton_Click;
        //
        // verdanaButton
        //
        verdanaButton.Location = new Point(462, 388);
        verdanaButton.Name = "verdanaButton";
        verdanaButton.Size = new Size(145, 34);
        verdanaButton.TabIndex = 16;
        verdanaButton.Tag = "Verdana";
        verdanaButton.Text = "Verdana";
        verdanaButton.UseVisualStyleBackColor = true;
        verdanaButton.Click += AccessibleFontButton_Click;
        //
        // decorativeButton
        //
        decorativeButton.ForeColor = Color.FromArgb(185, 28, 28);
        decorativeButton.Location = new Point(612, 388);
        decorativeButton.Name = "decorativeButton";
        decorativeButton.Size = new Size(160, 34);
        decorativeButton.TabIndex = 17;
        decorativeButton.Tag = "Segoe Script";
        decorativeButton.Text = "Avoid: decorative";
        decorativeButton.UseVisualStyleBackColor = true;
        decorativeButton.Click += decorativeButton_Click;
        //
        // noteLabel
        //
        noteLabel.ForeColor = Color.DimGray;
        noteLabel.Location = new Point(12, 432);
        noteLabel.Name = "noteLabel";
        noteLabel.Size = new Size(760, 36);
        noteLabel.TabIndex = 18;
        noteLabel.Text = "Windows does not include Helvetica. When you ask for a font that is not installed, GDI+ substitutes another font.\r\nWatch the Result line to see which font Windows actually used.";
        //
        // Example02FontsForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 476);
        Controls.Add(noteLabel);
        Controls.Add(decorativeButton);
        Controls.Add(verdanaButton);
        Controls.Add(arialButton);
        Controls.Add(courierButton);
        Controls.Add(helveticaButton);
        Controls.Add(accessibleTitleLabel);
        Controls.Add(sansSerifLabel);
        Controls.Add(serifLabel);
        Controls.Add(serifTitleLabel);
        Controls.Add(boldItalicButton);
        Controls.Add(threeArgButton);
        Controls.Add(calibriButton);
        Controls.Add(twoArgButton);
        Controls.Add(constructorsTitleLabel);
        Controls.Add(fontInfoLabel);
        Controls.Add(codeLabel);
        Controls.Add(previewLabel);
        Controls.Add(headerLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Example02FontsForm";
        Text = "Example 02 - Fonts";
        FormClosed += Example02FontsForm_FormClosed;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Label previewLabel;
    private Label codeLabel;
    private Label fontInfoLabel;
    private Label constructorsTitleLabel;
    private Button twoArgButton;
    private Button calibriButton;
    private Button threeArgButton;
    private Button boldItalicButton;
    private Label serifTitleLabel;
    private Label serifLabel;
    private Label sansSerifLabel;
    private Label accessibleTitleLabel;
    private Button helveticaButton;
    private Button courierButton;
    private Button arialButton;
    private Button verdanaButton;
    private Button decorativeButton;
    private Label noteLabel;
}
