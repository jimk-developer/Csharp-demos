namespace Guide12Examples.Examples;

partial class Example07ListControlsForm
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
        coursesTitleLabel = new Label();
        coursesListBox = new ListBox();
        selectionLabel = new Label();
        multiColumnCheckBox = new CheckBox();
        selectionModeGroupBox = new GroupBox();
        noneRadioButton = new RadioButton();
        oneRadioButton = new RadioButton();
        multiSimpleRadioButton = new RadioButton();
        multiExtendedRadioButton = new RadioButton();
        countButton = new Button();
        getSelectedButton = new Button();
        familyButton = new Button();
        outputTextBox = new TextBox();
        comboTitleLabel = new Label();
        scheduleComboBox = new ComboBox();
        addScheduleButton = new Button();
        comboResultLabel = new Label();
        scrollNoteLabel = new Label();
        checkedListTitleLabel = new Label();
        toolsCheckedListBox = new CheckedListBox();
        toolsLabel = new Label();
        selectionModeGroupBox.SuspendLayout();
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
        headerLabel.Text = "Guide 12  |  Section 7  |  List Controls";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // coursesTitleLabel
        // 
        coursesTitleLabel.AutoSize = true;
        coursesTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        coursesTitleLabel.Location = new Point(12, 56);
        coursesTitleLabel.Name = "coursesTitleLabel";
        coursesTitleLabel.TabIndex = 1;
        coursesTitleLabel.Text = "ListBox  (items from the String Collection Editor)";
        // 
        // coursesListBox
        // 
        coursesListBox.Items.AddRange(new object[] { "AUT 101 Automotive Basics", "CIS 110 Intro to Programming", "CIS 215 C# Programming", "CIS 220 Database Design", "ELE 105 DC Circuits", "ELE 210 Motor Controls", "ENG 101 Technical Writing", "HVA 120 Refrigeration I", "IT 130 Networking Fundamentals", "IT 240 Cybersecurity", "MAT 115 Technical Math", "WEL 101 Welding I" });
        coursesListBox.ColumnWidth = 190;
        coursesListBox.FormattingEnabled = true;
        coursesListBox.Location = new Point(12, 78);
        coursesListBox.Name = "coursesListBox";
        coursesListBox.Size = new Size(300, 154);
        coursesListBox.TabIndex = 2;
        coursesListBox.SelectedIndexChanged += coursesListBox_SelectedIndexChanged;
        // 
        // selectionLabel
        // 
        selectionLabel.BorderStyle = BorderStyle.FixedSingle;
        selectionLabel.Location = new Point(12, 238);
        selectionLabel.Name = "selectionLabel";
        selectionLabel.Size = new Size(300, 50);
        selectionLabel.TabIndex = 3;
        selectionLabel.Text = "Click a course. The SelectedIndexChanged method updates this label.";
        // 
        // multiColumnCheckBox
        // 
        multiColumnCheckBox.AutoSize = true;
        multiColumnCheckBox.Location = new Point(330, 78);
        multiColumnCheckBox.Name = "multiColumnCheckBox";
        multiColumnCheckBox.TabIndex = 4;
        multiColumnCheckBox.Text = "Multi&Column";
        multiColumnCheckBox.UseVisualStyleBackColor = true;
        multiColumnCheckBox.CheckedChanged += multiColumnCheckBox_CheckedChanged;
        // 
        // selectionModeGroupBox
        // 
        selectionModeGroupBox.Controls.Add(noneRadioButton);
        selectionModeGroupBox.Controls.Add(oneRadioButton);
        selectionModeGroupBox.Controls.Add(multiSimpleRadioButton);
        selectionModeGroupBox.Controls.Add(multiExtendedRadioButton);
        selectionModeGroupBox.Location = new Point(330, 104);
        selectionModeGroupBox.Name = "selectionModeGroupBox";
        selectionModeGroupBox.Size = new Size(200, 128);
        selectionModeGroupBox.TabIndex = 5;
        selectionModeGroupBox.TabStop = false;
        selectionModeGroupBox.Text = "SelectionMode";
        // 
        // noneRadioButton
        // 
        noneRadioButton.AutoSize = true;
        noneRadioButton.Location = new Point(16, 24);
        noneRadioButton.Name = "noneRadioButton";
        noneRadioButton.TabIndex = 6;
        noneRadioButton.TabStop = true;
        noneRadioButton.Tag = "None";
        noneRadioButton.Text = "None";
        noneRadioButton.UseVisualStyleBackColor = true;
        noneRadioButton.CheckedChanged += SelectionModeRadioButton_CheckedChanged;
        // 
        // oneRadioButton
        // 
        oneRadioButton.AutoSize = true;
        oneRadioButton.Checked = true;
        oneRadioButton.Location = new Point(16, 48);
        oneRadioButton.Name = "oneRadioButton";
        oneRadioButton.TabIndex = 7;
        oneRadioButton.TabStop = true;
        oneRadioButton.Tag = "One";
        oneRadioButton.Text = "&One";
        oneRadioButton.UseVisualStyleBackColor = true;
        oneRadioButton.CheckedChanged += SelectionModeRadioButton_CheckedChanged;
        // 
        // multiSimpleRadioButton
        // 
        multiSimpleRadioButton.AutoSize = true;
        multiSimpleRadioButton.Location = new Point(16, 72);
        multiSimpleRadioButton.Name = "multiSimpleRadioButton";
        multiSimpleRadioButton.TabIndex = 8;
        multiSimpleRadioButton.TabStop = true;
        multiSimpleRadioButton.Tag = "MultiSimple";
        multiSimpleRadioButton.Text = "Multi&Simple";
        multiSimpleRadioButton.UseVisualStyleBackColor = true;
        multiSimpleRadioButton.CheckedChanged += SelectionModeRadioButton_CheckedChanged;
        // 
        // multiExtendedRadioButton
        // 
        multiExtendedRadioButton.AutoSize = true;
        multiExtendedRadioButton.Location = new Point(16, 96);
        multiExtendedRadioButton.Name = "multiExtendedRadioButton";
        multiExtendedRadioButton.TabIndex = 9;
        multiExtendedRadioButton.TabStop = true;
        multiExtendedRadioButton.Tag = "MultiExtended";
        multiExtendedRadioButton.Text = "Multi&Extended";
        multiExtendedRadioButton.UseVisualStyleBackColor = true;
        multiExtendedRadioButton.CheckedChanged += SelectionModeRadioButton_CheckedChanged;
        // 
        // countButton
        // 
        countButton.Location = new Point(550, 78);
        countButton.Name = "countButton";
        countButton.Size = new Size(222, 30);
        countButton.TabIndex = 10;
        countButton.Text = "Show Items.&Count";
        countButton.UseVisualStyleBackColor = true;
        countButton.Click += countButton_Click;
        // 
        // getSelectedButton
        // 
        getSelectedButton.Location = new Point(550, 114);
        getSelectedButton.Name = "getSelectedButton";
        getSelectedButton.Size = new Size(222, 30);
        getSelectedButton.TabIndex = 11;
        getSelectedButton.Text = "Call &GetSelected(i) for each";
        getSelectedButton.UseVisualStyleBackColor = true;
        getSelectedButton.Click += getSelectedButton_Click;
        // 
        // familyButton
        // 
        familyButton.Location = new Point(550, 150);
        familyButton.Name = "familyButton";
        familyButton.Size = new Size(222, 30);
        familyButton.TabIndex = 12;
        familyButton.Text = "Show List&Control family";
        familyButton.UseVisualStyleBackColor = true;
        familyButton.Click += familyButton_Click;
        // 
        // outputTextBox
        // 
        outputTextBox.BackColor = Color.White;
        outputTextBox.Font = new Font("Consolas", 9F);
        outputTextBox.Location = new Point(330, 238);
        outputTextBox.Multiline = true;
        outputTextBox.Name = "outputTextBox";
        outputTextBox.ReadOnly = true;
        outputTextBox.ScrollBars = ScrollBars.Both;
        outputTextBox.Size = new Size(442, 50);
        outputTextBox.TabIndex = 13;
        outputTextBox.WordWrap = false;
        // 
        // comboTitleLabel
        // 
        comboTitleLabel.AutoSize = true;
        comboTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        comboTitleLabel.Location = new Point(12, 302);
        comboTitleLabel.Name = "comboTitleLabel";
        comboTitleLabel.TabIndex = 14;
        comboTitleLabel.Text = "ComboBox  (pick from the list OR type new text)";
        // 
        // scheduleComboBox
        // 
        scheduleComboBox.Items.AddRange(new object[] { "Day classes", "Evening classes", "Weekend classes", "Online classes" });
        scheduleComboBox.FormattingEnabled = true;
        scheduleComboBox.Location = new Point(12, 324);
        scheduleComboBox.Name = "scheduleComboBox";
        scheduleComboBox.Size = new Size(300, 23);
        scheduleComboBox.TabIndex = 15;
        scheduleComboBox.SelectedIndexChanged += scheduleComboBox_SelectedIndexChanged;
        // 
        // addScheduleButton
        // 
        addScheduleButton.Location = new Point(322, 323);
        addScheduleButton.Name = "addScheduleButton";
        addScheduleButton.Size = new Size(150, 26);
        addScheduleButton.TabIndex = 16;
        addScheduleButton.Text = "&Add typed text";
        addScheduleButton.UseVisualStyleBackColor = true;
        addScheduleButton.Click += addScheduleButton_Click;
        // 
        // comboResultLabel
        // 
        comboResultLabel.Location = new Point(12, 354);
        comboResultLabel.Name = "comboResultLabel";
        comboResultLabel.Size = new Size(460, 40);
        comboResultLabel.TabIndex = 17;
        comboResultLabel.Text = "Choose a schedule, or type a new one and click Add typed text.";
        // 
        // scrollNoteLabel
        // 
        scrollNoteLabel.ForeColor = Color.DimGray;
        scrollNoteLabel.Location = new Point(12, 400);
        scrollNoteLabel.Name = "scrollNoteLabel";
        scrollNoteLabel.Size = new Size(460, 90);
        scrollNoteLabel.TabIndex = 18;
        scrollNoteLabel.Text = "The ListBox holds 12 items but only about 9 fit, so a scroll bar appears automatically; no code needed.\r\n\r\nItems were entered in the designer: select the ListBox, click Items in the Properties window, click the ellipsis (...), and type one item per line in the String Collection Editor.";
        // 
        // checkedListTitleLabel
        // 
        checkedListTitleLabel.AutoSize = true;
        checkedListTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        checkedListTitleLabel.Location = new Point(500, 302);
        checkedListTitleLabel.Name = "checkedListTitleLabel";
        checkedListTitleLabel.TabIndex = 19;
        checkedListTitleLabel.Text = "CheckedListBox  (a check box per item)";
        // 
        // toolsCheckedListBox
        // 
        toolsCheckedListBox.Items.AddRange(new object[] { "Multimeter", "Torque wrench", "Laptop", "Safety glasses", "Soldering iron", "Wire strippers", "Socket set" });
        toolsCheckedListBox.CheckOnClick = true;
        toolsCheckedListBox.FormattingEnabled = true;
        toolsCheckedListBox.Location = new Point(500, 324);
        toolsCheckedListBox.Name = "toolsCheckedListBox";
        toolsCheckedListBox.Size = new Size(272, 130);
        toolsCheckedListBox.TabIndex = 20;
        toolsCheckedListBox.ItemCheck += toolsCheckedListBox_ItemCheck;
        // 
        // toolsLabel
        // 
        toolsLabel.Location = new Point(500, 458);
        toolsLabel.Name = "toolsLabel";
        toolsLabel.Size = new Size(272, 36);
        toolsLabel.TabIndex = 21;
        toolsLabel.Text = "Checked: 0 item(s)";
        // 
        // Example07ListControlsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 502);
        Controls.Add(toolsLabel);
        Controls.Add(toolsCheckedListBox);
        Controls.Add(checkedListTitleLabel);
        Controls.Add(scrollNoteLabel);
        Controls.Add(comboResultLabel);
        Controls.Add(addScheduleButton);
        Controls.Add(scheduleComboBox);
        Controls.Add(comboTitleLabel);
        Controls.Add(outputTextBox);
        Controls.Add(familyButton);
        Controls.Add(getSelectedButton);
        Controls.Add(countButton);
        Controls.Add(selectionModeGroupBox);
        Controls.Add(multiColumnCheckBox);
        Controls.Add(selectionLabel);
        Controls.Add(coursesListBox);
        Controls.Add(coursesTitleLabel);
        Controls.Add(headerLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Example07ListControlsForm";
        Text = "Example 07 - List Controls";
        selectionModeGroupBox.ResumeLayout(false);
        selectionModeGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Label coursesTitleLabel;
    private ListBox coursesListBox;
    private Label selectionLabel;
    private CheckBox multiColumnCheckBox;
    private GroupBox selectionModeGroupBox;
    private RadioButton noneRadioButton;
    private RadioButton oneRadioButton;
    private RadioButton multiSimpleRadioButton;
    private RadioButton multiExtendedRadioButton;
    private Button countButton;
    private Button getSelectedButton;
    private Button familyButton;
    private TextBox outputTextBox;
    private Label comboTitleLabel;
    private ComboBox scheduleComboBox;
    private Button addScheduleButton;
    private Label comboResultLabel;
    private Label scrollNoteLabel;
    private Label checkedListTitleLabel;
    private CheckedListBox toolsCheckedListBox;
    private Label toolsLabel;
}
