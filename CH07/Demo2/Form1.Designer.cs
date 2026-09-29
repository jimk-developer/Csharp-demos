namespace Demo2
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
            lblCreditScore = new Label();
            txtCreditScore = new TextBox();
            lblIncome = new Label();
            txtIncome = new TextBox();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblCreditScore
            // 
            lblCreditScore.AutoSize = true;
            lblCreditScore.Location = new Point(20, 23);
            lblCreditScore.Name = "lblCreditScore";
            lblCreditScore.Size = new Size(110, 20);
            lblCreditScore.TabIndex = 0;
            lblCreditScore.Text = "Credit Score:";
            // 
            // txtCreditScore
            // 
            txtCreditScore.Location = new Point(150, 20);
            txtCreditScore.Name = "txtCreditScore";
            txtCreditScore.Size = new Size(180, 23);
            txtCreditScore.TabIndex = 1;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(20, 58);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(110, 20);
            lblIncome.TabIndex = 2;
            lblIncome.Text = "Annual Income:";
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(150, 55);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(180, 23);
            txtIncome.TabIndex = 3;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(150, 95);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(120, 30);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Check Loan";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(20, 145);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(310, 23);
            lblResult.TabIndex = 5;
            lblResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 190);
            Controls.Add(lblCreditScore);
            Controls.Add(txtCreditScore);
            Controls.Add(lblIncome);
            Controls.Add(txtIncome);
            Controls.Add(btnCheck);
            Controls.Add(lblResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan Approval Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreditScore;
        private TextBox txtCreditScore;
        private Label lblIncome;
        private TextBox txtIncome;
        private Button btnCheck;
        private Label lblResult;
    }
}
