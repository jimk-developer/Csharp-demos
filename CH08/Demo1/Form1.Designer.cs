namespace Demo1
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
            lblPrompt = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            btnRotate = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(12, 15);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(155, 15);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter three whole numbers:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(12, 40);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(90, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(115, 40);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(90, 23);
            txtNum2.TabIndex = 2;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(218, 40);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(90, 23);
            txtNum3.TabIndex = 3;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(12, 78);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(90, 30);
            btnRotate.TabIndex = 4;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 120);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "";
            // 
            // Form1
            // 
            AcceptButton = btnRotate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 150);
            Controls.Add(lblPrompt);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum3);
            Controls.Add(btnRotate);
            Controls.Add(lblStatus);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Number Rotator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private Button btnRotate;
        private Label lblStatus;
    }
}
