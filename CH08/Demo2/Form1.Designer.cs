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
            lblPhrase = new Label();
            txtPhrase = new TextBox();
            btnCapitalize = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // lblPhrase
            // 
            lblPhrase.AutoSize = true;
            lblPhrase.Location = new Point(12, 18);
            lblPhrase.Name = "lblPhrase";
            lblPhrase.Size = new Size(45, 15);
            lblPhrase.TabIndex = 0;
            lblPhrase.Text = "Phrase:";
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(70, 15);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(310, 23);
            txtPhrase.TabIndex = 1;
            // 
            // btnCapitalize
            // 
            btnCapitalize.Location = new Point(70, 50);
            btnCapitalize.Name = "btnCapitalize";
            btnCapitalize.Size = new Size(110, 30);
            btnCapitalize.TabIndex = 2;
            btnCapitalize.Text = "Capitalize";
            btnCapitalize.UseVisualStyleBackColor = true;
            btnCapitalize.Click += btnCapitalize_Click;
            // 
            // lblOutput
            // 
            lblOutput.Location = new Point(12, 95);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(368, 40);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "";
            // 
            // Form1
            // 
            AcceptButton = btnCapitalize;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 145);
            Controls.Add(lblPhrase);
            Controls.Add(txtPhrase);
            Controls.Add(btnCapitalize);
            Controls.Add(lblOutput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Title Case Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhrase;
        private TextBox txtPhrase;
        private Button btnCapitalize;
        private Label lblOutput;
    }
}
