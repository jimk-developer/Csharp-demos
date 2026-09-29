namespace Demo7
{
    partial class Form1
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblPin = new Label();
            txtPin = new TextBox();
            btnSignIn = new Button();
            lblWelcome = new Label();
            lblBalance = new Label();
            lblAddFundsPrompt = new Label();
            txtAddFunds = new TextBox();
            btnAddFunds = new Button();
            lblMealPrompt = new Label();
            txtMealPrice = new TextBox();
            btnBuyMeal = new Button();
            btnSignOut = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(20, 23);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(100, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(130, 20);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(140, 23);
            txtStudentId.TabIndex = 1;
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Location = new Point(20, 58);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(100, 20);
            lblPin.TabIndex = 2;
            lblPin.Text = "PIN:";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(130, 55);
            txtPin.PasswordChar = '*';
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(140, 23);
            txtPin.TabIndex = 3;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(285, 35);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 30);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new Point(40, 100);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(320, 23);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "";
            // 
            // lblBalance
            // 
            lblBalance.Location = new Point(40, 125);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(320, 23);
            lblBalance.TabIndex = 6;
            lblBalance.Text = "";
            // 
            // lblAddFundsPrompt
            // 
            lblAddFundsPrompt.AutoSize = true;
            lblAddFundsPrompt.Location = new Point(20, 165);
            lblAddFundsPrompt.Name = "lblAddFundsPrompt";
            lblAddFundsPrompt.Size = new Size(250, 20);
            lblAddFundsPrompt.TabIndex = 7;
            lblAddFundsPrompt.Text = "Add funds to your card:";
            // 
            // txtAddFunds
            // 
            txtAddFunds.Location = new Point(20, 190);
            txtAddFunds.Name = "txtAddFunds";
            txtAddFunds.Size = new Size(160, 23);
            txtAddFunds.TabIndex = 8;
            // 
            // btnAddFunds
            // 
            btnAddFunds.Location = new Point(195, 187);
            btnAddFunds.Name = "btnAddFunds";
            btnAddFunds.Size = new Size(100, 30);
            btnAddFunds.TabIndex = 9;
            btnAddFunds.Text = "Add Funds";
            btnAddFunds.UseVisualStyleBackColor = true;
            btnAddFunds.Click += btnAddFunds_Click;
            // 
            // lblMealPrompt
            // 
            lblMealPrompt.AutoSize = true;
            lblMealPrompt.Location = new Point(20, 230);
            lblMealPrompt.Name = "lblMealPrompt";
            lblMealPrompt.Size = new Size(250, 20);
            lblMealPrompt.TabIndex = 10;
            lblMealPrompt.Text = "Enter meal price to purchase:";
            // 
            // txtMealPrice
            // 
            txtMealPrice.Location = new Point(20, 255);
            txtMealPrice.Name = "txtMealPrice";
            txtMealPrice.Size = new Size(160, 23);
            txtMealPrice.TabIndex = 11;
            // 
            // btnBuyMeal
            // 
            btnBuyMeal.Location = new Point(195, 252);
            btnBuyMeal.Name = "btnBuyMeal";
            btnBuyMeal.Size = new Size(100, 30);
            btnBuyMeal.TabIndex = 12;
            btnBuyMeal.Text = "Buy Meal";
            btnBuyMeal.UseVisualStyleBackColor = true;
            btnBuyMeal.Click += btnBuyMeal_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.Location = new Point(140, 300);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(100, 30);
            btnSignOut.TabIndex = 13;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(20, 350);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(340, 23);
            lblMessage.TabIndex = 14;
            lblMessage.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 390);
            Controls.Add(lblStudentId);
            Controls.Add(txtStudentId);
            Controls.Add(lblPin);
            Controls.Add(txtPin);
            Controls.Add(btnSignIn);
            Controls.Add(lblWelcome);
            Controls.Add(lblBalance);
            Controls.Add(lblAddFundsPrompt);
            Controls.Add(txtAddFunds);
            Controls.Add(btnAddFunds);
            Controls.Add(lblMealPrompt);
            Controls.Add(txtMealPrice);
            Controls.Add(btnBuyMeal);
            Controls.Add(btnSignOut);
            Controls.Add(lblMessage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campus Cafe Card";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblPin;
        private TextBox txtPin;
        private Button btnSignIn;
        private Label lblWelcome;
        private Label lblBalance;
        private Label lblAddFundsPrompt;
        private TextBox txtAddFunds;
        private Button btnAddFunds;
        private Label lblMealPrompt;
        private TextBox txtMealPrice;
        private Button btnBuyMeal;
        private Button btnSignOut;
        private Label lblMessage;
    }
}
