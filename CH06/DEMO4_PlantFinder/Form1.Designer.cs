namespace DEMO4
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNameCaption = new System.Windows.Forms.Label();
            this.lblNameOut = new System.Windows.Forms.Label();
            this.lblTypeCaption = new System.Windows.Forms.Label();
            this.lblTypeOut = new System.Windows.Forms.Label();
            this.lblLightCaption = new System.Windows.Forms.Label();
            this.lblLightOut = new System.Windows.Forms.Label();
            this.lblPriceCaption = new System.Windows.Forms.Label();
            this.lblPriceOut = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(340, 23);
            this.txtSearch.TabIndex = 0;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(376, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // lblNameCaption
            //
            this.lblNameCaption.AutoSize = true;
            this.lblNameCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNameCaption.Location = new System.Drawing.Point(20, 80);
            this.lblNameCaption.Name = "lblNameCaption";
            this.lblNameCaption.Size = new System.Drawing.Size(45, 15);
            this.lblNameCaption.TabIndex = 2;
            this.lblNameCaption.Text = "Name:";
            //
            // lblNameOut
            //
            this.lblNameOut.AutoSize = true;
            this.lblNameOut.Location = new System.Drawing.Point(130, 80);
            this.lblNameOut.Name = "lblNameOut";
            this.lblNameOut.Size = new System.Drawing.Size(0, 15);
            this.lblNameOut.TabIndex = 3;
            this.lblNameOut.Text = "";
            //
            // lblTypeCaption
            //
            this.lblTypeCaption.AutoSize = true;
            this.lblTypeCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTypeCaption.Location = new System.Drawing.Point(20, 112);
            this.lblTypeCaption.Name = "lblTypeCaption";
            this.lblTypeCaption.Size = new System.Drawing.Size(38, 15);
            this.lblTypeCaption.TabIndex = 4;
            this.lblTypeCaption.Text = "Type:";
            //
            // lblTypeOut
            //
            this.lblTypeOut.AutoSize = true;
            this.lblTypeOut.Location = new System.Drawing.Point(130, 112);
            this.lblTypeOut.Name = "lblTypeOut";
            this.lblTypeOut.Size = new System.Drawing.Size(0, 15);
            this.lblTypeOut.TabIndex = 5;
            this.lblTypeOut.Text = "";
            //
            // lblLightCaption
            //
            this.lblLightCaption.AutoSize = true;
            this.lblLightCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLightCaption.Location = new System.Drawing.Point(20, 144);
            this.lblLightCaption.Name = "lblLightCaption";
            this.lblLightCaption.Size = new System.Drawing.Size(75, 15);
            this.lblLightCaption.TabIndex = 6;
            this.lblLightCaption.Text = "Light Needs:";
            //
            // lblLightOut
            //
            this.lblLightOut.AutoSize = true;
            this.lblLightOut.Location = new System.Drawing.Point(130, 144);
            this.lblLightOut.Name = "lblLightOut";
            this.lblLightOut.Size = new System.Drawing.Size(0, 15);
            this.lblLightOut.TabIndex = 7;
            this.lblLightOut.Text = "";
            //
            // lblPriceCaption
            //
            this.lblPriceCaption.AutoSize = true;
            this.lblPriceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPriceCaption.Location = new System.Drawing.Point(20, 176);
            this.lblPriceCaption.Name = "lblPriceCaption";
            this.lblPriceCaption.Size = new System.Drawing.Size(40, 15);
            this.lblPriceCaption.TabIndex = 8;
            this.lblPriceCaption.Text = "Price:";
            //
            // lblPriceOut
            //
            this.lblPriceOut.AutoSize = true;
            this.lblPriceOut.Location = new System.Drawing.Point(130, 176);
            this.lblPriceOut.Name = "lblPriceOut";
            this.lblPriceOut.Size = new System.Drawing.Size(0, 15);
            this.lblPriceOut.TabIndex = 9;
            this.lblPriceOut.Text = "";
            //
            // lblCount
            //
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblCount.Location = new System.Drawing.Point(20, 216);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 15);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "";
            //
            // lblMessage
            //
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMessage.Location = new System.Drawing.Point(20, 240);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "";
            //
            // Form1
            //
            this.AcceptButton = this.btnSearch;
            this.ClientSize = new System.Drawing.Size(504, 285);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPriceOut);
            this.Controls.Add(this.lblPriceCaption);
            this.Controls.Add(this.lblLightOut);
            this.Controls.Add(this.lblLightCaption);
            this.Controls.Add(this.lblTypeOut);
            this.Controls.Add(this.lblTypeCaption);
            this.Controls.Add(this.lblNameOut);
            this.Controls.Add(this.lblNameCaption);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trailside Nursery - Plant Finder";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNameCaption;
        private System.Windows.Forms.Label lblNameOut;
        private System.Windows.Forms.Label lblTypeCaption;
        private System.Windows.Forms.Label lblTypeOut;
        private System.Windows.Forms.Label lblLightCaption;
        private System.Windows.Forms.Label lblLightOut;
        private System.Windows.Forms.Label lblPriceCaption;
        private System.Windows.Forms.Label lblPriceOut;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblMessage;
    }
}
