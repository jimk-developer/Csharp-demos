namespace Guide12Examples.Examples;

partial class Example08DateTimeForm
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
        calendarTitleLabel = new Label();
        reservationCalendar = new MonthCalendar();
        outputTextBox = new TextBox();
        pickerTitleLabel = new Label();
        dueDatePicker = new DateTimePicker();
        pickerResultLabel = new Label();
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
        headerLabel.Text = "Guide 12  |  Section 8  |  Date/Time Controls";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // calendarTitleLabel
        // 
        calendarTitleLabel.AutoSize = true;
        calendarTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        calendarTitleLabel.Location = new Point(12, 56);
        calendarTitleLabel.Name = "calendarTitleLabel";
        calendarTitleLabel.TabIndex = 1;
        calendarTitleLabel.Text = "MonthCalendar  (always visible)";
        // 
        // reservationCalendar
        // 
        reservationCalendar.Location = new Point(12, 80);
        reservationCalendar.MaxSelectionCount = 14;
        reservationCalendar.Name = "reservationCalendar";
        reservationCalendar.TabIndex = 2;
        reservationCalendar.DateChanged += reservationCalendar_DateChanged;
        // 
        // outputTextBox
        // 
        outputTextBox.BackColor = Color.White;
        outputTextBox.Font = new Font("Consolas", 9.75F);
        outputTextBox.Location = new Point(260, 80);
        outputTextBox.Multiline = true;
        outputTextBox.Name = "outputTextBox";
        outputTextBox.ReadOnly = true;
        outputTextBox.ScrollBars = ScrollBars.Vertical;
        outputTextBox.Size = new Size(512, 172);
        outputTextBox.TabIndex = 3;
        // 
        // pickerTitleLabel
        // 
        pickerTitleLabel.AutoSize = true;
        pickerTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        pickerTitleLabel.Location = new Point(12, 270);
        pickerTitleLabel.Name = "pickerTitleLabel";
        pickerTitleLabel.TabIndex = 4;
        pickerTitleLabel.Text = "DateTimePicker  (compact; the calendar drops down from the arrow)";
        // 
        // dueDatePicker
        // 
        dueDatePicker.Location = new Point(12, 292);
        dueDatePicker.Name = "dueDatePicker";
        dueDatePicker.Size = new Size(250, 23);
        dueDatePicker.TabIndex = 5;
        dueDatePicker.ValueChanged += dueDatePicker_ValueChanged;
        // 
        // pickerResultLabel
        // 
        pickerResultLabel.Font = new Font("Consolas", 9.75F);
        pickerResultLabel.Location = new Point(272, 292);
        pickerResultLabel.Name = "pickerResultLabel";
        pickerResultLabel.Size = new Size(500, 40);
        pickerResultLabel.TabIndex = 6;
        pickerResultLabel.Text = "Click the down arrow and pick a date.";
        // 
        // noteLabel
        // 
        noteLabel.ForeColor = Color.DimGray;
        noteLabel.Location = new Point(12, 340);
        noteLabel.Name = "noteLabel";
        noteLabel.Size = new Size(760, 40);
        noteLabel.TabIndex = 7;
        noteLabel.Text = "MaxDate is set to 6 months from today, so later dates cannot be selected. Drag across several days to select a range\r\n(MaxSelectionCount = 14). DateChanged is the MonthCalendar's default event; ValueChanged is the DateTimePicker's.";
        // 
        // Example08DateTimeForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 390);
        Controls.Add(noteLabel);
        Controls.Add(pickerResultLabel);
        Controls.Add(dueDatePicker);
        Controls.Add(pickerTitleLabel);
        Controls.Add(outputTextBox);
        Controls.Add(reservationCalendar);
        Controls.Add(calendarTitleLabel);
        Controls.Add(headerLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Example08DateTimeForm";
        Text = "Example 08 - Date/Time Controls";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Label calendarTitleLabel;
    private MonthCalendar reservationCalendar;
    private TextBox outputTextBox;
    private Label pickerTitleLabel;
    private DateTimePicker dueDatePicker;
    private Label pickerResultLabel;
    private Label noteLabel;
}
