namespace DEMO2
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
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRateCaption = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Riverbend Kayak Rental";
            //
            // lblPrompt
            //
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(20, 74);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(80, 15);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Hours Rented:";
            //
            // txtHours
            //
            this.txtHours.Location = new System.Drawing.Point(110, 71);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(60, 23);
            this.txtHours.TabIndex = 2;
            //
            // btnCalculate
            //
            this.btnCalculate.Location = new System.Drawing.Point(190, 69);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            //
            // lblRateCaption
            //
            this.lblRateCaption.AutoSize = true;
            this.lblRateCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRateCaption.Location = new System.Drawing.Point(330, 50);
            this.lblRateCaption.Name = "lblRateCaption";
            this.lblRateCaption.Size = new System.Drawing.Size(75, 15);
            this.lblRateCaption.TabIndex = 4;
            this.lblRateCaption.Text = "Hourly Rate";
            //
            // lblRate
            //
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(330, 76);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(0, 15);
            this.lblRate.TabIndex = 5;
            this.lblRate.Text = "";
            //
            // lblTotalCaption
            //
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.Location = new System.Drawing.Point(430, 50);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(97, 15);
            this.lblTotalCaption.TabIndex = 6;
            this.lblTotalCaption.Text = "Total Rental Cost";
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(430, 76);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "";
            //
            // lblError
            //
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblError.Location = new System.Drawing.Point(20, 130);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "";
            //
            // Form1
            //
            this.AcceptButton = this.btnCalculate;
            this.ClientSize = new System.Drawing.Size(564, 180);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalCaption);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblRateCaption);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO2 - Kayak Rental";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRateCaption;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblError;
    }
}
