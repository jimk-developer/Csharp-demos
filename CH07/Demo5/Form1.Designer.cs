namespace Demo5
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
            lblText = new Label();
            txtText = new TextBox();
            lblMaskChar = new Label();
            txtMaskChar = new TextBox();
            lblNumToShow = new Label();
            txtNumToShow = new TextBox();
            btnMask = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(20, 23);
            lblText.Name = "lblText";
            lblText.Size = new Size(135, 20);
            lblText.TabIndex = 0;
            lblText.Text = "Text to mask:";
            // 
            // txtText
            // 
            txtText.Location = new Point(160, 20);
            txtText.Name = "txtText";
            txtText.Size = new Size(340, 23);
            txtText.TabIndex = 1;
            // 
            // lblMaskChar
            // 
            lblMaskChar.AutoSize = true;
            lblMaskChar.Location = new Point(20, 58);
            lblMaskChar.Name = "lblMaskChar";
            lblMaskChar.Size = new Size(135, 20);
            lblMaskChar.TabIndex = 2;
            lblMaskChar.Text = "Mask character:";
            // 
            // txtMaskChar
            // 
            txtMaskChar.Location = new Point(160, 55);
            txtMaskChar.MaxLength = 1;
            txtMaskChar.Name = "txtMaskChar";
            txtMaskChar.Size = new Size(40, 23);
            txtMaskChar.TabIndex = 3;
            // 
            // lblNumToShow
            // 
            lblNumToShow.AutoSize = true;
            lblNumToShow.Location = new Point(20, 93);
            lblNumToShow.Name = "lblNumToShow";
            lblNumToShow.Size = new Size(135, 20);
            lblNumToShow.TabIndex = 4;
            lblNumToShow.Text = "Characters to show:";
            // 
            // txtNumToShow
            // 
            txtNumToShow.Location = new Point(160, 90);
            txtNumToShow.Name = "txtNumToShow";
            txtNumToShow.Size = new Size(60, 23);
            txtNumToShow.TabIndex = 5;
            // 
            // btnMask
            // 
            btnMask.Location = new Point(160, 125);
            btnMask.Name = "btnMask";
            btnMask.Size = new Size(100, 30);
            btnMask.TabIndex = 6;
            btnMask.Text = "Mask";
            btnMask.UseVisualStyleBackColor = true;
            btnMask.Click += btnMask_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(20, 175);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(480, 23);
            lblResult.TabIndex = 7;
            lblResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 215);
            Controls.Add(lblText);
            Controls.Add(txtText);
            Controls.Add(lblMaskChar);
            Controls.Add(txtMaskChar);
            Controls.Add(lblNumToShow);
            Controls.Add(txtNumToShow);
            Controls.Add(btnMask);
            Controls.Add(lblResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Email Masker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private TextBox txtText;
        private Label lblMaskChar;
        private TextBox txtMaskChar;
        private Label lblNumToShow;
        private TextBox txtNumToShow;
        private Button btnMask;
        private Label lblResult;
    }
}
