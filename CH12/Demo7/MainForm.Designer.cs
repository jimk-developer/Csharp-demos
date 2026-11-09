namespace Demo7;

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
        lblTeam = new Label();
        cboTeams = new ComboBox();
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
        cboPlayers = new ComboBox();
        btnRemove = new Button();
        rtbRoster = new RichTextBox();
        SuspendLayout();
        // 
        // lblTeam
        // 
        lblTeam.AutoSize = true;
        lblTeam.Location = new Point(20, 18);
        lblTeam.Name = "lblTeam";
        lblTeam.TabIndex = 0;
        lblTeam.Text = "Team:";
        // 
        // cboTeams
        // 
        cboTeams.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTeams.Location = new Point(110, 15);
        cboTeams.Name = "cboTeams";
        cboTeams.Size = new Size(150, 23);
        cboTeams.TabIndex = 1;
        cboTeams.SelectedIndexChanged += cboTeams_SelectedIndexChanged;
        // 
        // lblAdd
        // 
        lblAdd.AutoSize = true;
        lblAdd.Location = new Point(20, 55);
        lblAdd.Name = "lblAdd";
        lblAdd.TabIndex = 2;
        lblAdd.Text = "Add a player to this team:";
        // 
        // lblNumber
        // 
        lblNumber.AutoSize = true;
        lblNumber.Location = new Point(20, 85);
        lblNumber.Name = "lblNumber";
        lblNumber.TabIndex = 3;
        lblNumber.Text = "Number:";
        // 
        // txtNumber
        // 
        txtNumber.Location = new Point(110, 82);
        txtNumber.Name = "txtNumber";
        txtNumber.Size = new Size(150, 23);
        txtNumber.TabIndex = 4;
        // 
        // lblFirstName
        // 
        lblFirstName.AutoSize = true;
        lblFirstName.Location = new Point(20, 115);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.TabIndex = 5;
        lblFirstName.Text = "First name:";
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(110, 112);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(150, 23);
        txtFirstName.TabIndex = 6;
        // 
        // lblLastName
        // 
        lblLastName.AutoSize = true;
        lblLastName.Location = new Point(20, 145);
        lblLastName.Name = "lblLastName";
        lblLastName.TabIndex = 7;
        lblLastName.Text = "Last name:";
        // 
        // txtLastName
        // 
        txtLastName.Location = new Point(110, 142);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(150, 23);
        txtLastName.TabIndex = 8;
        // 
        // lblPosition
        // 
        lblPosition.AutoSize = true;
        lblPosition.Location = new Point(20, 175);
        lblPosition.Name = "lblPosition";
        lblPosition.TabIndex = 9;
        lblPosition.Text = "Position:";
        // 
        // txtPosition
        // 
        txtPosition.Location = new Point(110, 172);
        txtPosition.Name = "txtPosition";
        txtPosition.Size = new Size(150, 23);
        txtPosition.TabIndex = 10;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(110, 205);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(150, 30);
        btnAdd.TabIndex = 11;
        btnAdd.Text = "Add Player";
        btnAdd.Click += btnAdd_Click;
        // 
        // lblRemove
        // 
        lblRemove.AutoSize = true;
        lblRemove.Location = new Point(20, 255);
        lblRemove.Name = "lblRemove";
        lblRemove.TabIndex = 12;
        lblRemove.Text = "Remove a player from this team:";
        // 
        // cboPlayers
        // 
        cboPlayers.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPlayers.Location = new Point(20, 280);
        cboPlayers.Name = "cboPlayers";
        cboPlayers.Size = new Size(240, 23);
        cboPlayers.TabIndex = 13;
        // 
        // btnRemove
        // 
        btnRemove.Location = new Point(110, 315);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new Size(150, 30);
        btnRemove.TabIndex = 14;
        btnRemove.Text = "Remove Player";
        btnRemove.Click += btnRemove_Click;
        // 
        // rtbRoster
        // 
        rtbRoster.ReadOnly = true;
        rtbRoster.Font = new Font("Segoe UI", 11F);
        rtbRoster.Location = new Point(290, 15);
        rtbRoster.Name = "rtbRoster";
        rtbRoster.Size = new Size(290, 330);
        rtbRoster.TabIndex = 15;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(600, 360);
        Controls.Add(lblTeam);
        Controls.Add(cboTeams);
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
        Controls.Add(cboPlayers);
        Controls.Add(btnRemove);
        Controls.Add(rtbRoster);
        Name = "MainForm";
        Text = "League Rosters";
        Load += MainForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTeam;
    private ComboBox cboTeams;
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
    private ComboBox cboPlayers;
    private Button btnRemove;
    private RichTextBox rtbRoster;
}
