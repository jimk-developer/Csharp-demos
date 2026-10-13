namespace Demo3
{
    partial class MealCardForm
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
            grpSignIn = new GroupBox();
            lblCardNumber = new Label();
            txtCardNumber = new TextBox();
            lblPin = new Label();
            txtPin = new TextBox();
            btnSignIn = new Button();
            btnSignOut = new Button();
            lblWelcome = new Label();
            lblBalance = new Label();
            grpMoney = new GroupBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            btnAddFunds = new Button();
            btnBuyMeal = new Button();
            lblMessage = new Label();
            grpSignIn.SuspendLayout();
            grpMoney.SuspendLayout();
            SuspendLayout();
            //
            // grpSignIn
            //
            grpSignIn.Controls.Add(lblCardNumber);
            grpSignIn.Controls.Add(txtCardNumber);
            grpSignIn.Controls.Add(lblPin);
            grpSignIn.Controls.Add(txtPin);
            grpSignIn.Controls.Add(btnSignIn);
            grpSignIn.Controls.Add(btnSignOut);
            grpSignIn.Location = new Point(12, 12);
            grpSignIn.Name = "grpSignIn";
            grpSignIn.Size = new Size(360, 100);
            grpSignIn.TabIndex = 0;
            grpSignIn.TabStop = false;
            grpSignIn.Text = "Sign In";
            //
            // lblCardNumber
            //
            lblCardNumber.AutoSize = true;
            lblCardNumber.Location = new Point(10, 28);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(78, 15);
            lblCardNumber.TabIndex = 0;
            lblCardNumber.Text = "Card Number";
            //
            // txtCardNumber
            //
            txtCardNumber.Location = new Point(100, 25);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(120, 23);
            txtCardNumber.TabIndex = 1;
            //
            // lblPin
            //
            lblPin.AutoSize = true;
            lblPin.Location = new Point(10, 62);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(26, 15);
            lblPin.TabIndex = 2;
            lblPin.Text = "PIN";
            //
            // txtPin
            //
            txtPin.Location = new Point(100, 59);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(120, 23);
            txtPin.TabIndex = 3;
            //
            // btnSignIn
            //
            btnSignIn.Location = new Point(240, 23);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(100, 27);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            //
            // btnSignOut
            //
            btnSignOut.Location = new Point(240, 57);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(100, 27);
            btnSignOut.TabIndex = 5;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            //
            // lblWelcome
            //
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.Location = new Point(12, 122);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(360, 25);
            lblWelcome.TabIndex = 1;
            //
            // lblBalance
            //
            lblBalance.Font = new Font("Segoe UI", 12F);
            lblBalance.Location = new Point(12, 150);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(360, 25);
            lblBalance.TabIndex = 2;
            //
            // grpMoney
            //
            grpMoney.Controls.Add(lblAmount);
            grpMoney.Controls.Add(txtAmount);
            grpMoney.Controls.Add(btnAddFunds);
            grpMoney.Controls.Add(btnBuyMeal);
            grpMoney.Location = new Point(12, 185);
            grpMoney.Name = "grpMoney";
            grpMoney.Size = new Size(360, 100);
            grpMoney.TabIndex = 3;
            grpMoney.TabStop = false;
            grpMoney.Text = "Card Activity";
            //
            // lblAmount
            //
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(10, 28);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount";
            //
            // txtAmount
            //
            txtAmount.Location = new Point(100, 25);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(120, 23);
            txtAmount.TabIndex = 1;
            //
            // btnAddFunds
            //
            btnAddFunds.Location = new Point(240, 23);
            btnAddFunds.Name = "btnAddFunds";
            btnAddFunds.Size = new Size(100, 27);
            btnAddFunds.TabIndex = 2;
            btnAddFunds.Text = "Add Funds";
            btnAddFunds.UseVisualStyleBackColor = true;
            btnAddFunds.Click += btnAddFunds_Click;
            //
            // btnBuyMeal
            //
            btnBuyMeal.Location = new Point(240, 57);
            btnBuyMeal.Name = "btnBuyMeal";
            btnBuyMeal.Size = new Size(100, 27);
            btnBuyMeal.TabIndex = 3;
            btnBuyMeal.Text = "Buy Meal";
            btnBuyMeal.UseVisualStyleBackColor = true;
            btnBuyMeal.Click += btnBuyMeal_Click;
            //
            // lblMessage
            //
            lblMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblMessage.ForeColor = Color.DarkRed;
            lblMessage.Location = new Point(12, 295);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(360, 25);
            lblMessage.TabIndex = 4;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 330);
            Controls.Add(lblMessage);
            Controls.Add(grpMoney);
            Controls.Add(lblBalance);
            Controls.Add(lblWelcome);
            Controls.Add(grpSignIn);
            Name = "Form1";
            Text = "Cafeteria Meal Card";
            grpSignIn.ResumeLayout(false);
            grpSignIn.PerformLayout();
            grpMoney.ResumeLayout(false);
            grpMoney.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSignIn;
        private Label lblCardNumber;
        private TextBox txtCardNumber;
        private Label lblPin;
        private TextBox txtPin;
        private Button btnSignIn;
        private Button btnSignOut;
        private Label lblWelcome;
        private Label lblBalance;
        private GroupBox grpMoney;
        private Label lblAmount;
        private TextBox txtAmount;
        private Button btnAddFunds;
        private Button btnBuyMeal;
        private Label lblMessage;
    }
}
