namespace Demo1
{
    partial class LoanApprovalForm
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
            lblCreditScore = new Label();
            lblAnnualIncome = new Label();
            lblResult = new Label();
            txtCreditScore = new TextBox();
            txtAnnualIncome = new TextBox();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // lblCreditScore
            // 
            lblCreditScore.AutoSize = true;
            lblCreditScore.Location = new Point(96, 57);
            lblCreditScore.Name = "lblCreditScore";
            lblCreditScore.Size = new Size(71, 15);
            lblCreditScore.TabIndex = 0;
            lblCreditScore.Text = "Credit Score";
            // 
            // lblAnnualIncome
            // 
            lblAnnualIncome.AutoSize = true;
            lblAnnualIncome.Location = new Point(310, 57);
            lblAnnualIncome.Name = "lblAnnualIncome";
            lblAnnualIncome.Size = new Size(88, 15);
            lblAnnualIncome.TabIndex = 1;
            lblAnnualIncome.Text = "Annual Income";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(310, 165);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "label3";
            // 
            // txtCreditScore
            // 
            txtCreditScore.Location = new Point(96, 89);
            txtCreditScore.Name = "txtCreditScore";
            txtCreditScore.Size = new Size(100, 23);
            txtCreditScore.TabIndex = 3;
            // 
            // txtAnnualIncome
            // 
            txtAnnualIncome.Location = new Point(310, 89);
            txtAnnualIncome.Name = "txtAnnualIncome";
            txtAnnualIncome.Size = new Size(100, 23);
            txtAnnualIncome.TabIndex = 4;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(96, 150);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 30);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // LoanApprovalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 306);
            Controls.Add(btnCheck);
            Controls.Add(txtAnnualIncome);
            Controls.Add(txtCreditScore);
            Controls.Add(lblResult);
            Controls.Add(lblAnnualIncome);
            Controls.Add(lblCreditScore);
            Name = "LoanApprovalForm";
            Text = "Loan Approval";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreditScore;
        private Label lblAnnualIncome;
        private Label lblResult;
        private TextBox txtCreditScore;
        private TextBox txtAnnualIncome;
        private Button btnCheck;
    }
}
