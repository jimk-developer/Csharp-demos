namespace Demo4;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblStudentId = new Label();
        txtStudentId = new TextBox();
        lblPin = new Label();
        txtPin = new TextBox();
        btnLogin = new Button();
        lblWelcome = new Label();
        lblBalance = new Label();
        lblTier = new Label();
        lblAmount = new Label();
        txtAmount = new TextBox();
        btnAddFunds = new Button();
        btnPurchase = new Button();
        btnViewHistory = new Button();
        btnLogout = new Button();
        SuspendLayout();
        //
        // lblStudentId
        //
        lblStudentId.AutoSize = true;
        lblStudentId.Location = new Point(20, 23);
        lblStudentId.Name = "lblStudentId";
        lblStudentId.Text = "Student ID";
        //
        // txtStudentId
        //
        txtStudentId.Location = new Point(100, 20);
        txtStudentId.Name = "txtStudentId";
        txtStudentId.Size = new Size(120, 23);
        txtStudentId.TabIndex = 0;
        //
        // lblPin
        //
        lblPin.AutoSize = true;
        lblPin.Location = new Point(20, 58);
        lblPin.Name = "lblPin";
        lblPin.Text = "PIN";
        //
        // txtPin
        //
        txtPin.Location = new Point(100, 55);
        txtPin.MaxLength = 4;
        txtPin.Name = "txtPin";
        txtPin.PasswordChar = '*';
        txtPin.Size = new Size(120, 23);
        txtPin.TabIndex = 1;
        //
        // btnLogin
        //
        btnLogin.Location = new Point(240, 36);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(90, 30);
        btnLogin.TabIndex = 2;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        //
        // lblWelcome
        //
        lblWelcome.AutoSize = true;
        lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblWelcome.Location = new Point(20, 100);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Text = "Please log in.";
        //
        // lblBalance
        //
        lblBalance.AutoSize = true;
        lblBalance.Location = new Point(20, 130);
        lblBalance.Name = "lblBalance";
        lblBalance.Text = "";
        //
        // lblTier
        //
        lblTier.AutoSize = true;
        lblTier.Location = new Point(20, 152);
        lblTier.Name = "lblTier";
        lblTier.Text = "";
        //
        // lblAmount
        //
        lblAmount.AutoSize = true;
        lblAmount.Location = new Point(20, 193);
        lblAmount.Name = "lblAmount";
        lblAmount.Text = "Amount";
        //
        // txtAmount
        //
        txtAmount.Location = new Point(100, 190);
        txtAmount.Name = "txtAmount";
        txtAmount.Size = new Size(120, 23);
        txtAmount.TabIndex = 3;
        //
        // btnAddFunds
        //
        btnAddFunds.Location = new Point(20, 230);
        btnAddFunds.Name = "btnAddFunds";
        btnAddFunds.Size = new Size(100, 30);
        btnAddFunds.TabIndex = 4;
        btnAddFunds.Text = "Add Funds";
        btnAddFunds.UseVisualStyleBackColor = true;
        btnAddFunds.Click += btnAddFunds_Click;
        //
        // btnPurchase
        //
        btnPurchase.Location = new Point(130, 230);
        btnPurchase.Name = "btnPurchase";
        btnPurchase.Size = new Size(100, 30);
        btnPurchase.TabIndex = 5;
        btnPurchase.Text = "Purchase";
        btnPurchase.UseVisualStyleBackColor = true;
        btnPurchase.Click += btnPurchase_Click;
        //
        // btnViewHistory
        //
        btnViewHistory.Location = new Point(20, 275);
        btnViewHistory.Name = "btnViewHistory";
        btnViewHistory.Size = new Size(210, 30);
        btnViewHistory.TabIndex = 6;
        btnViewHistory.Text = "View History";
        btnViewHistory.UseVisualStyleBackColor = true;
        btnViewHistory.Click += btnViewHistory_Click;
        //
        // btnLogout
        //
        btnLogout.Location = new Point(240, 275);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(90, 30);
        btnLogout.TabIndex = 7;
        btnLogout.Text = "Log Out";
        btnLogout.UseVisualStyleBackColor = true;
        btnLogout.Click += btnLogout_Click;
        //
        // MainForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(350, 325);
        Controls.Add(lblStudentId);
        Controls.Add(txtStudentId);
        Controls.Add(lblPin);
        Controls.Add(txtPin);
        Controls.Add(btnLogin);
        Controls.Add(lblWelcome);
        Controls.Add(lblBalance);
        Controls.Add(lblTier);
        Controls.Add(lblAmount);
        Controls.Add(txtAmount);
        Controls.Add(btnAddFunds);
        Controls.Add(btnPurchase);
        Controls.Add(btnViewHistory);
        Controls.Add(btnLogout);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Campus Meal Card";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblStudentId;
    private TextBox txtStudentId;
    private Label lblPin;
    private TextBox txtPin;
    private Button btnLogin;
    private Label lblWelcome;
    private Label lblBalance;
    private Label lblTier;
    private Label lblAmount;
    private TextBox txtAmount;
    private Button btnAddFunds;
    private Button btnPurchase;
    private Button btnViewHistory;
    private Button btnLogout;
}
