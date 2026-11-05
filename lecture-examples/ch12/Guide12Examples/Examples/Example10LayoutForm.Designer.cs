namespace Guide12Examples.Examples;

partial class Example10LayoutForm
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
        components = new System.ComponentModel.Container();
        headerLabel = new Label();
        instructionsLabel = new Label();
        fixedButton = new Button();
        moveButton = new Button();
        stretchTextBox = new TextBox();
        focusGroupBox = new GroupBox();
        firstNameTextBox = new TextBox();
        lastNameTextBox = new TextBox();
        focusStatusLabel = new Label();
        captureLabel = new Label();
        captureStatusLabel = new Label();
        snapLinesLabel = new Label();
        anchoredButton = new Button();
        navPanel = new Panel();
        dockInfoLabel = new Label();
        statusLabel = new Label();
        focusTimer = new System.Windows.Forms.Timer(components);
        focusGroupBox.SuspendLayout();
        navPanel.SuspendLayout();
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
        headerLabel.Text = "Guide 12  |  Section 10  |  Form Layout";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // instructionsLabel
        // 
        instructionsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        instructionsLabel.Location = new Point(162, 58);
        instructionsLabel.Name = "instructionsLabel";
        instructionsLabel.Size = new Size(610, 40);
        instructionsLabel.TabIndex = 1;
        instructionsLabel.Text = "Resize this window by dragging its corner. Watch which controls stay put (Location), keep their distance\r\nfrom an edge (Anchor), or stretch along an edge (Dock).";
        // 
        // fixedButton
        // 
        fixedButton.Location = new Point(162, 104);
        fixedButton.Name = "fixedButton";
        fixedButton.Size = new Size(170, 32);
        fixedButton.TabIndex = 2;
        fixedButton.Text = "Location: I stay put";
        fixedButton.UseVisualStyleBackColor = true;
        // 
        // moveButton
        // 
        moveButton.Location = new Point(342, 104);
        moveButton.Name = "moveButton";
        moveButton.Size = new Size(200, 32);
        moveButton.TabIndex = 3;
        moveButton.Text = "Change fixedButton.&Location";
        moveButton.UseVisualStyleBackColor = true;
        moveButton.Click += moveButton_Click;
        // 
        // stretchTextBox
        // 
        stretchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        stretchTextBox.Location = new Point(162, 144);
        stretchTextBox.Name = "stretchTextBox";
        stretchTextBox.Size = new Size(610, 23);
        stretchTextBox.TabIndex = 4;
        stretchTextBox.Text = "Anchor = Top, Left, Right  ->  I stretch horizontally";
        // 
        // focusGroupBox
        // 
        focusGroupBox.Controls.Add(firstNameTextBox);
        focusGroupBox.Controls.Add(lastNameTextBox);
        focusGroupBox.Location = new Point(162, 180);
        focusGroupBox.Name = "focusGroupBox";
        focusGroupBox.Size = new Size(300, 116);
        focusGroupBox.TabIndex = 5;
        focusGroupBox.TabStop = false;
        focusGroupBox.Text = "ContainsFocus example  (click a text box)";
        // 
        // firstNameTextBox
        // 
        firstNameTextBox.Location = new Point(14, 30);
        firstNameTextBox.Name = "firstNameTextBox";
        firstNameTextBox.PlaceholderText = "First name";
        firstNameTextBox.Size = new Size(270, 23);
        firstNameTextBox.TabIndex = 6;
        // 
        // lastNameTextBox
        // 
        lastNameTextBox.Location = new Point(14, 66);
        lastNameTextBox.Name = "lastNameTextBox";
        lastNameTextBox.PlaceholderText = "Last name";
        lastNameTextBox.Size = new Size(270, 23);
        lastNameTextBox.TabIndex = 7;
        // 
        // focusStatusLabel
        // 
        focusStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        focusStatusLabel.BackColor = Color.White;
        focusStatusLabel.BorderStyle = BorderStyle.FixedSingle;
        focusStatusLabel.Font = new Font("Consolas", 9F);
        focusStatusLabel.Location = new Point(474, 186);
        focusStatusLabel.Name = "focusStatusLabel";
        focusStatusLabel.Padding = new Padding(4);
        focusStatusLabel.Size = new Size(298, 104);
        focusStatusLabel.TabIndex = 8;
        // 
        // captureLabel
        // 
        captureLabel.BackColor = Color.White;
        captureLabel.BorderStyle = BorderStyle.FixedSingle;
        captureLabel.Location = new Point(162, 308);
        captureLabel.Name = "captureLabel";
        captureLabel.Size = new Size(300, 84);
        captureLabel.TabIndex = 9;
        captureLabel.Text = "Capture example:\r\nPress and hold the mouse here,\r\nthen drag outside this box.";
        captureLabel.TextAlign = ContentAlignment.MiddleCenter;
        captureLabel.MouseDown += captureLabel_MouseDown;
        captureLabel.MouseMove += captureLabel_MouseMove;
        captureLabel.MouseUp += captureLabel_MouseUp;
        // 
        // captureStatusLabel
        // 
        captureStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        captureStatusLabel.BackColor = Color.White;
        captureStatusLabel.BorderStyle = BorderStyle.FixedSingle;
        captureStatusLabel.Font = new Font("Consolas", 9F);
        captureStatusLabel.Location = new Point(474, 308);
        captureStatusLabel.Name = "captureStatusLabel";
        captureStatusLabel.Padding = new Padding(4);
        captureStatusLabel.Size = new Size(298, 84);
        captureStatusLabel.TabIndex = 10;
        // 
        // snapLinesLabel
        // 
        snapLinesLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        snapLinesLabel.ForeColor = Color.DimGray;
        snapLinesLabel.Location = new Point(162, 402);
        snapLinesLabel.Name = "snapLinesLabel";
        snapLinesLabel.Size = new Size(430, 44);
        snapLinesLabel.TabIndex = 11;
        snapLinesLabel.Text = "Snap lines: open this form in the designer and drag fixedButton near another\r\ncontrol. Blue snap lines appear to line up the edges.";
        // 
        // anchoredButton
        // 
        anchoredButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        anchoredButton.Location = new Point(602, 410);
        anchoredButton.Name = "anchoredButton";
        anchoredButton.Size = new Size(170, 32);
        anchoredButton.TabIndex = 12;
        anchoredButton.Text = "Anchor = Bottom, Right";
        anchoredButton.UseVisualStyleBackColor = true;
        // 
        // navPanel
        // 
        navPanel.Controls.Add(dockInfoLabel);
        navPanel.BackColor = Color.FromArgb(254, 215, 170);
        navPanel.Dock = DockStyle.Left;
        navPanel.Location = new Point(0, 50);
        navPanel.Name = "navPanel";
        navPanel.Size = new Size(150, 402);
        navPanel.TabIndex = 13;
        // 
        // dockInfoLabel
        // 
        dockInfoLabel.Dock = DockStyle.Fill;
        dockInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dockInfoLabel.ForeColor = Color.FromArgb(124, 45, 18);
        dockInfoLabel.Location = new Point(0, 0);
        dockInfoLabel.Name = "dockInfoLabel";
        dockInfoLabel.Size = new Size(150, 402);
        dockInfoLabel.TabIndex = 14;
        dockInfoLabel.Text = "Dock = Left\r\n\r\nI stretch from\r\ntop to bottom\r\nas you resize.";
        dockInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // statusLabel
        // 
        statusLabel.BackColor = Color.FromArgb(255, 247, 237);
        statusLabel.BorderStyle = BorderStyle.FixedSingle;
        statusLabel.Dock = DockStyle.Bottom;
        statusLabel.Location = new Point(0, 452);
        statusLabel.Name = "statusLabel";
        statusLabel.Padding = new Padding(8, 0, 0, 0);
        statusLabel.Size = new Size(784, 28);
        statusLabel.TabIndex = 15;
        statusLabel.Text = "Dock = Bottom: I stretch across the bottom edge as you resize.";
        statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // focusTimer
        // 
        focusTimer.Enabled = true;
        focusTimer.Interval = 200;
        focusTimer.Tick += focusTimer_Tick;
        // 
        // Example10LayoutForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 480);
        Controls.Add(instructionsLabel);
        Controls.Add(fixedButton);
        Controls.Add(moveButton);
        Controls.Add(stretchTextBox);
        Controls.Add(focusGroupBox);
        Controls.Add(focusStatusLabel);
        Controls.Add(captureLabel);
        Controls.Add(captureStatusLabel);
        Controls.Add(snapLinesLabel);
        Controls.Add(anchoredButton);
        Controls.Add(navPanel);
        Controls.Add(statusLabel);
        Controls.Add(headerLabel);
        MinimumSize = new Size(800, 519);
        Name = "Example10LayoutForm";
        Text = "Example 10 - Form Layout (resize me!)";
        focusGroupBox.ResumeLayout(false);
        focusGroupBox.PerformLayout();
        navPanel.ResumeLayout(false);
        navPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Label instructionsLabel;
    private Button fixedButton;
    private Button moveButton;
    private TextBox stretchTextBox;
    private GroupBox focusGroupBox;
    private TextBox firstNameTextBox;
    private TextBox lastNameTextBox;
    private Label focusStatusLabel;
    private Label captureLabel;
    private Label captureStatusLabel;
    private Label snapLinesLabel;
    private Button anchoredButton;
    private Panel navPanel;
    private Label dockInfoLabel;
    private Label statusLabel;
    private System.Windows.Forms.Timer focusTimer;
}
