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
            btnPick = new Button();
            lblSpecial1 = new Label();
            lblSpecial2 = new Label();
            SuspendLayout();
            // 
            // btnPick
            // 
            btnPick.Location = new Point(20, 20);
            btnPick.Name = "btnPick";
            btnPick.Size = new Size(130, 30);
            btnPick.TabIndex = 0;
            btnPick.Text = "Pick Specials";
            btnPick.UseVisualStyleBackColor = true;
            btnPick.Click += btnPick_Click;
            // 
            // lblSpecial1
            // 
            lblSpecial1.Location = new Point(20, 70);
            lblSpecial1.Name = "lblSpecial1";
            lblSpecial1.Size = new Size(480, 23);
            lblSpecial1.TabIndex = 1;
            lblSpecial1.Text = "";
            // 
            // lblSpecial2
            // 
            lblSpecial2.Location = new Point(20, 100);
            lblSpecial2.Name = "lblSpecial2";
            lblSpecial2.Size = new Size(480, 23);
            lblSpecial2.TabIndex = 2;
            lblSpecial2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 150);
            Controls.Add(btnPick);
            Controls.Add(lblSpecial1);
            Controls.Add(lblSpecial2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lunch Special Picker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPick;
        private Label lblSpecial1;
        private Label lblSpecial2;
    }
}
