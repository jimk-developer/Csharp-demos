namespace Guide12Examples.Examples;

partial class Example09MultipleFormsForm
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
        websiteLinkLabel = new LinkLabel();
        settingsLinkLabel = new LinkLabel();
        modalLinkLabel = new LinkLabel();
        clickMeButton = new Button();
        clickCountLabel = new Label();
        familyButton = new Button();
        logTitleLabel = new Label();
        logTextBox = new TextBox();
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
        headerLabel.Text = "Guide 12  |  Section 9  |  Multiple Forms and Navigation";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // websiteLinkLabel
        // 
        websiteLinkLabel.AutoSize = true;
        websiteLinkLabel.Font = new Font("Segoe UI", 10F);
        websiteLinkLabel.Location = new Point(12, 62);
        websiteLinkLabel.Name = "websiteLinkLabel";
        websiteLinkLabel.TabIndex = 1;
        websiteLinkLabel.TabStop = true;
        websiteLinkLabel.Text = "Open the LinkLabel documentation (web page)";
        websiteLinkLabel.LinkClicked += websiteLinkLabel_LinkClicked;
        // 
        // settingsLinkLabel
        // 
        settingsLinkLabel.AutoSize = true;
        settingsLinkLabel.Font = new Font("Segoe UI", 10F);
        settingsLinkLabel.Location = new Point(12, 92);
        settingsLinkLabel.Name = "settingsLinkLabel";
        settingsLinkLabel.TabIndex = 2;
        settingsLinkLabel.TabStop = true;
        settingsLinkLabel.Text = "Open the Settings form with Show()  (non-modal)";
        settingsLinkLabel.LinkClicked += settingsLinkLabel_LinkClicked;
        // 
        // modalLinkLabel
        // 
        modalLinkLabel.AutoSize = true;
        modalLinkLabel.Font = new Font("Segoe UI", 10F);
        modalLinkLabel.Location = new Point(12, 122);
        modalLinkLabel.Name = "modalLinkLabel";
        modalLinkLabel.TabIndex = 3;
        modalLinkLabel.TabStop = true;
        modalLinkLabel.Text = "Open the Sign-in form with ShowDialog()  (modal)";
        modalLinkLabel.LinkClicked += modalLinkLabel_LinkClicked;
        // 
        // clickMeButton
        // 
        clickMeButton.Location = new Point(440, 62);
        clickMeButton.Name = "clickMeButton";
        clickMeButton.Size = new Size(200, 30);
        clickMeButton.TabIndex = 4;
        clickMeButton.Text = "Click &me";
        clickMeButton.UseVisualStyleBackColor = true;
        clickMeButton.Click += clickMeButton_Click;
        // 
        // clickCountLabel
        // 
        clickCountLabel.AutoSize = true;
        clickCountLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        clickCountLabel.Location = new Point(650, 67);
        clickCountLabel.Name = "clickCountLabel";
        clickCountLabel.TabIndex = 5;
        clickCountLabel.Text = "Clicks: 0";
        // 
        // familyButton
        // 
        familyButton.Location = new Point(440, 100);
        familyButton.Name = "familyButton";
        familyButton.Size = new Size(332, 30);
        familyButton.TabIndex = 6;
        familyButton.Text = "Show LinkLabel &family and colors";
        familyButton.UseVisualStyleBackColor = true;
        familyButton.Click += familyButton_Click;
        // 
        // logTitleLabel
        // 
        logTitleLabel.AutoSize = true;
        logTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        logTitleLabel.Location = new Point(12, 160);
        logTitleLabel.Name = "logTitleLabel";
        logTitleLabel.TabIndex = 7;
        logTitleLabel.Text = "What happened (timeline)";
        // 
        // logTextBox
        // 
        logTextBox.BackColor = Color.White;
        logTextBox.Font = new Font("Consolas", 9.75F);
        logTextBox.Location = new Point(12, 182);
        logTextBox.Multiline = true;
        logTextBox.Name = "logTextBox";
        logTextBox.ReadOnly = true;
        logTextBox.ScrollBars = ScrollBars.Vertical;
        logTextBox.Size = new Size(760, 196);
        logTextBox.TabIndex = 8;
        // 
        // noteLabel
        // 
        noteLabel.ForeColor = Color.DimGray;
        noteLabel.Location = new Point(12, 386);
        noteLabel.Name = "noteLabel";
        noteLabel.Size = new Size(760, 36);
        noteLabel.TabIndex = 9;
        noteLabel.Text = "Add another form to a project with Project > Add Form (Windows Forms), or Project > Add New Item > Form.\r\nShow() lets the user keep working in this form; ShowDialog() makes a MODAL window that blocks this form until it closes.";
        // 
        // Example09MultipleFormsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 430);
        Controls.Add(noteLabel);
        Controls.Add(logTextBox);
        Controls.Add(logTitleLabel);
        Controls.Add(familyButton);
        Controls.Add(clickCountLabel);
        Controls.Add(clickMeButton);
        Controls.Add(modalLinkLabel);
        Controls.Add(settingsLinkLabel);
        Controls.Add(websiteLinkLabel);
        Controls.Add(headerLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Example09MultipleFormsForm";
        Text = "Example 09 - Multiple Forms and Navigation";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private LinkLabel websiteLinkLabel;
    private LinkLabel settingsLinkLabel;
    private LinkLabel modalLinkLabel;
    private Button clickMeButton;
    private Label clickCountLabel;
    private Button familyButton;
    private Label logTitleLabel;
    private TextBox logTextBox;
    private Label noteLabel;
}
