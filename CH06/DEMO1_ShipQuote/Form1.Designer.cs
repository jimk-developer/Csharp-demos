namespace DEMO1
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
            this.txtStateCode = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.lblChargeCaption = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rapid Parcel - Shipping Quote";
            //
            // lblPrompt
            //
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(20, 64);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(66, 15);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "State Code:";
            //
            // txtStateCode
            //
            this.txtStateCode.Location = new System.Drawing.Point(100, 61);
            this.txtStateCode.MaxLength = 2;
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Size = new System.Drawing.Size(60, 23);
            this.txtStateCode.TabIndex = 2;
            //
            // btnLookup
            //
            this.btnLookup.Location = new System.Drawing.Point(180, 59);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(100, 28);
            this.btnLookup.TabIndex = 3;
            this.btnLookup.Text = "Look Up";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            //
            // lblChargeCaption
            //
            this.lblChargeCaption.AutoSize = true;
            this.lblChargeCaption.Location = new System.Drawing.Point(20, 115);
            this.lblChargeCaption.Name = "lblChargeCaption";
            this.lblChargeCaption.Size = new System.Drawing.Size(101, 15);
            this.lblChargeCaption.TabIndex = 4;
            this.lblChargeCaption.Text = "Shipping Charge:";
            //
            // lblCharge
            //
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCharge.Location = new System.Drawing.Point(140, 113);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(0, 20);
            this.lblCharge.TabIndex = 5;
            this.lblCharge.Text = "";
            //
            // lblError
            //
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(20, 155);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "";
            //
            // Form1
            //
            this.AcceptButton = this.btnLookup;
            this.ClientSize = new System.Drawing.Size(444, 196);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblChargeCaption);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.txtStateCode);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO1 - Shipping Quote";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtStateCode;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label lblChargeCaption;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblError;
    }
}
