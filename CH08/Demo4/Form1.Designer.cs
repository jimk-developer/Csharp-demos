namespace Demo4
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
            lblScore = new Label();
            txtScore = new TextBox();
            lblError = new Label();
            btnAddScore = new Button();
            lblCount = new Label();
            lblPassing = new Label();
            lblFailing = new Label();
            lblPercent = new Label();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(12, 18);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(39, 15);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(70, 15);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 1;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(180, 18);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 2;
            lblError.Text = "";
            // 
            // btnAddScore
            // 
            btnAddScore.Location = new Point(70, 50);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(100, 30);
            btnAddScore.TabIndex = 3;
            btnAddScore.Text = "Add Score";
            btnAddScore.UseVisualStyleBackColor = true;
            btnAddScore.Click += btnAddScore_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 100);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(118, 15);
            lblCount.TabIndex = 4;
            lblCount.Text = "Scores Entered: 0/10";
            // 
            // lblPassing
            // 
            lblPassing.AutoSize = true;
            lblPassing.Location = new Point(12, 125);
            lblPassing.Name = "lblPassing";
            lblPassing.Size = new Size(63, 15);
            lblPassing.TabIndex = 5;
            lblPassing.Text = "Passing: 0";
            // 
            // lblFailing
            // 
            lblFailing.AutoSize = true;
            lblFailing.Location = new Point(12, 150);
            lblFailing.Name = "lblFailing";
            lblFailing.Size = new Size(59, 15);
            lblFailing.TabIndex = 6;
            lblFailing.Text = "Failing: 0";
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(12, 175);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(132, 15);
            lblPercent.TabIndex = 7;
            lblPercent.Text = "Percent Passing: 0.0%";
            // 
            // Form1
            // 
            AcceptButton = btnAddScore;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 215);
            Controls.Add(lblScore);
            Controls.Add(txtScore);
            Controls.Add(lblError);
            Controls.Add(btnAddScore);
            Controls.Add(lblCount);
            Controls.Add(lblPassing);
            Controls.Add(lblFailing);
            Controls.Add(lblPercent);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Score Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private TextBox txtScore;
        private Label lblError;
        private Button btnAddScore;
        private Label lblCount;
        private Label lblPassing;
        private Label lblFailing;
        private Label lblPercent;
    }
}
