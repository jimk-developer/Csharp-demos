namespace DEMO5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnMask = new System.Windows.Forms.Button();
            this.lblMaskedCaption = new System.Windows.Forms.Label();
            this.lblMasked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Contact Privacy Masker";
            //
            // lblPrompt
            //
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(20, 68);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(90, 15);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Phone Number:";
            //
            // txtPhone
            //
            this.txtPhone.Location = new System.Drawing.Point(125, 65);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            this.txtPhone.TabIndex = 2;
            //
            // btnMask
            //
            this.btnMask.Location = new System.Drawing.Point(345, 63);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(100, 28);
            this.btnMask.TabIndex = 3;
            this.btnMask.Text = "Mask";
            this.btnMask.UseVisualStyleBackColor = true;
            this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
            //
            // lblMaskedCaption
            //
            this.lblMaskedCaption.AutoSize = true;
            this.lblMaskedCaption.Location = new System.Drawing.Point(20, 125);
            this.lblMaskedCaption.Name = "lblMaskedCaption";
            this.lblMaskedCaption.Size = new System.Drawing.Size(97, 15);
            this.lblMaskedCaption.TabIndex = 4;
            this.lblMaskedCaption.Text = "Masked Number:";
            //
            // lblMasked
            //
            this.lblMasked.AutoSize = true;
            this.lblMasked.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblMasked.Location = new System.Drawing.Point(125, 121);
            this.lblMasked.Name = "lblMasked";
            this.lblMasked.Size = new System.Drawing.Size(0, 19);
            this.lblMasked.TabIndex = 5;
            this.lblMasked.Text = "";
            //
            // Form1
            //
            this.AcceptButton = this.btnMask;
            this.ClientSize = new System.Drawing.Size(474, 180);
            this.Controls.Add(this.lblMasked);
            this.Controls.Add(this.lblMaskedCaption);
            this.Controls.Add(this.btnMask);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO5 - Contact Privacy Masker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnMask;
        private System.Windows.Forms.Label lblMaskedCaption;
        private System.Windows.Forms.Label lblMasked;
    }
}
