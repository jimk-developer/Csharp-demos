namespace Demo3
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
            lblPhrase = new Label();
            txtPhrase = new TextBox();
            lblLetter = new Label();
            txtLetter = new TextBox();
            btnCount = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblPhrase
            // 
            lblPhrase.AutoSize = true;
            lblPhrase.Location = new Point(20, 23);
            lblPhrase.Name = "lblPhrase";
            lblPhrase.Size = new Size(115, 20);
            lblPhrase.TabIndex = 0;
            lblPhrase.Text = "Enter a phrase:";
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(140, 20);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(290, 23);
            txtPhrase.TabIndex = 1;
            // 
            // lblLetter
            // 
            lblLetter.AutoSize = true;
            lblLetter.Location = new Point(20, 58);
            lblLetter.Name = "lblLetter";
            lblLetter.Size = new Size(115, 20);
            lblLetter.TabIndex = 2;
            lblLetter.Text = "Letter to count:";
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(140, 55);
            txtLetter.MaxLength = 1;
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(40, 23);
            txtLetter.TabIndex = 3;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(140, 95);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(100, 30);
            btnCount.TabIndex = 4;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(20, 145);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(410, 23);
            lblResult.TabIndex = 5;
            lblResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 190);
            Controls.Add(lblPhrase);
            Controls.Add(txtPhrase);
            Controls.Add(lblLetter);
            Controls.Add(txtLetter);
            Controls.Add(btnCount);
            Controls.Add(lblResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Letter Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhrase;
        private TextBox txtPhrase;
        private Label lblLetter;
        private TextBox txtLetter;
        private Button btnCount;
        private Label lblResult;
    }
}
