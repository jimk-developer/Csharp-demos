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
            lblWeight = new Label();
            txtWeight = new TextBox();
            btnCheckWeight = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(12, 18);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(92, 15);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "Package Weight:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(115, 15);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(160, 23);
            txtWeight.TabIndex = 1;
            // 
            // btnCheckWeight
            // 
            btnCheckWeight.Location = new Point(115, 50);
            btnCheckWeight.Name = "btnCheckWeight";
            btnCheckWeight.Size = new Size(110, 30);
            btnCheckWeight.TabIndex = 2;
            btnCheckWeight.Text = "Check Weight";
            btnCheckWeight.UseVisualStyleBackColor = true;
            btnCheckWeight.Click += btnCheckWeight_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(12, 100);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "";
            // 
            // Form1
            // 
            AcceptButton = btnCheckWeight;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 135);
            Controls.Add(lblWeight);
            Controls.Add(txtWeight);
            Controls.Add(btnCheckWeight);
            Controls.Add(lblMessage);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shipping Weight Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWeight;
        private TextBox txtWeight;
        private Button btnCheckWeight;
        private Label lblMessage;
    }
}
