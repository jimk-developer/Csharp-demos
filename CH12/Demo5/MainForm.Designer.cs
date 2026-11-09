namespace Demo5;

partial class MainForm
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
        lblAdd = new Label();
        lblNumber = new Label();
        txtNumber = new TextBox();
        lblFirstName = new Label();
        txtFirstName = new TextBox();
        lblLastName = new Label();
        txtLastName = new TextBox();
        lblPosition = new Label();
        txtPosition = new TextBox();
        btnAdd = new Button();
        lblRemove = new Label();
        cboRemove = new ComboBox();
        btnRemove = new Button();
        rtbRoster = new RichTextBox();
        SuspendLayout();
        // 
        // lblAdd
        // 
        lblAdd.AutoSize = true;
        lblAdd.Location = new Point(20, 15);
        lblAdd.Name = "lblAdd";
        lblAdd.TabIndex = 0;
        lblAdd.Text = "Add a player:";
        // 
        // lblNumber
        // 
        lblNumber.AutoSize = true;
        lblNumber.Location = new Point(20, 45);
        lblNumber.Name = "lblNumber";
        lblNumber.TabIndex = 1;
        lblNumber.Text = "Number:";
        // 
        // txtNumber
        // 
        txtNumber.Location = new Point(110, 42);
        txtNumber.Name = "txtNumber";
        txtNumber.Size = new Size(150, 23);
        txtNumber.TabIndex = 2;
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Location = new Point(20, 75);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.TabIndex = 3;
        lblFirstName.Text = "First name:";
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(110, 72);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(150, 23);
        txtFirstName.TabIndex = 4;
        // 
        // lblLastName
        // 
        lblLastName.AutoSize = true;
        lblLastName.Location = new Point(20, 105);
        lblLastName.Name = "lblLastName";
        lblLastName.TabIndex = 5;
        lblLastName.Text = "Last name:";
        // 
        // txtLastName
        // 
        txtLastName.Location = new Point(110, 102);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(150, 23);
        txtLastName.TabIndex = 6;
        // 
        // lblPosition
        // 
        lblPosition.AutoSize = true;
        lblPosition.Location = new Point(20, 135);
        lblPosition.Name = "lblPosition";
        lblPosition.TabIndex = 7;
        lblPosition.Text = "Position:";
        // 
        // txtPosition
        // 
        txtPosition.Location = new Point(110, 132);
        txtPosition.Name = "txtPosition";
        txtPosition.Size = new Size(150, 23);
        txtPosition.TabIndex = 8;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(110, 165);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(150, 30);
        btnAdd.TabIndex = 9;
        btnAdd.Text = "Add Player";
        btnAdd.Click += btnAdd_Click;
        // 
        // lblRemove
        // 
        lblRemove.AutoSize = true;
        lblRemove.Location = new Point(20, 215);
        lblRemove.Name = "lblRemove";
        lblRemove.TabIndex = 10;
        lblRemove.Text = "Remove a player:";
        // 
        // cboRemove
        // 
        cboRemove.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRemove.Location = new Point(20, 240);
        cboRemove.Name = "cboRemove";
        cboRemove.Size = new Size(240, 23);
        cboRemove.TabIndex = 11;
        // 
        // btnRemove
        // 
        btnRemove.Location = new Point(110, 275);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new Size(150, 30);
        btnRemove.TabIndex = 12;
        btnRemove.Text = "Remove Player";
        btnRemove.Click += btnRemove_Click;
        // 
        // rtbRoster
        // 
        rtbRoster.ReadOnly = true;
        rtbRoster.Font = new Font("Segoe UI", 11F);
        rtbRoster.Location = new Point(290, 15);
        rtbRoster.Name = "rtbRoster";
        rtbRoster.Size = new Size(290, 295);
        rtbRoster.TabIndex = 13;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(600, 330);
        Controls.Add(lblAdd);
        Controls.Add(lblNumber);
        Controls.Add(txtNumber);
        Controls.Add(lblFirstName);
        Controls.Add(txtFirstName);
        Controls.Add(lblLastName);
        Controls.Add(txtLastName);
        Controls.Add(lblPosition);
        Controls.Add(txtPosition);
        Controls.Add(btnAdd);
        Controls.Add(lblRemove);
        Controls.Add(cboRemove);
        Controls.Add(btnRemove);
        Controls.Add(rtbRoster);
        Name = "MainForm";
        Text = "Team Roster";
        Load += MainForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblAdd;
    private Label lblNumber;
    private TextBox txtNumber;
    private Label lblFirstName;
    private TextBox txtFirstName;
    private Label lblLastName;
    private TextBox txtLastName;
    private Label lblPosition;
    private TextBox txtPosition;
    private Button btnAdd;
    private Label lblRemove;
    private ComboBox cboRemove;
    private Button btnRemove;
    private RichTextBox rtbRoster;
}
