namespace DEMO3
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
            this.lblTitleCaption = new System.Windows.Forms.Label();
            this.lblTitleOut = new System.Windows.Forms.Label();
            this.lblAuthorCaption = new System.Windows.Forms.Label();
            this.lblAuthorOut = new System.Windows.Forms.Label();
            this.lblPriceCaption = new System.Windows.Forms.Label();
            this.lblPriceOut = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(330, 23);
            this.txtSearch.TabIndex = 0;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(366, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // lblTitleCaption
            //
            this.lblTitleCaption.AutoSize = true;
            this.lblTitleCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleCaption.Location = new System.Drawing.Point(20, 80);
            this.lblTitleCaption.Name = "lblTitleCaption";
            this.lblTitleCaption.Size = new System.Drawing.Size(35, 15);
            this.lblTitleCaption.TabIndex = 2;
            this.lblTitleCaption.Text = "Title:";
            //
            // lblTitleOut
            //
            this.lblTitleOut.AutoSize = true;
            this.lblTitleOut.Location = new System.Drawing.Point(120, 80);
            this.lblTitleOut.Name = "lblTitleOut";
            this.lblTitleOut.Size = new System.Drawing.Size(0, 15);
            this.lblTitleOut.TabIndex = 3;
            this.lblTitleOut.Text = "";
            //
            // lblAuthorCaption
            //
            this.lblAuthorCaption.AutoSize = true;
            this.lblAuthorCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAuthorCaption.Location = new System.Drawing.Point(20, 112);
            this.lblAuthorCaption.Name = "lblAuthorCaption";
            this.lblAuthorCaption.Size = new System.Drawing.Size(52, 15);
            this.lblAuthorCaption.TabIndex = 4;
            this.lblAuthorCaption.Text = "Author:";
            //
            // lblAuthorOut
            //
            this.lblAuthorOut.AutoSize = true;
            this.lblAuthorOut.Location = new System.Drawing.Point(120, 112);
            this.lblAuthorOut.Name = "lblAuthorOut";
            this.lblAuthorOut.Size = new System.Drawing.Size(0, 15);
            this.lblAuthorOut.TabIndex = 5;
            this.lblAuthorOut.Text = "";
            //
            // lblPriceCaption
            //
            this.lblPriceCaption.AutoSize = true;
            this.lblPriceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPriceCaption.Location = new System.Drawing.Point(20, 144);
            this.lblPriceCaption.Name = "lblPriceCaption";
            this.lblPriceCaption.Size = new System.Drawing.Size(40, 15);
            this.lblPriceCaption.TabIndex = 6;
            this.lblPriceCaption.Text = "Price:";
            //
            // lblPriceOut
            //
            this.lblPriceOut.AutoSize = true;
            this.lblPriceOut.Location = new System.Drawing.Point(120, 144);
            this.lblPriceOut.Name = "lblPriceOut";
            this.lblPriceOut.Size = new System.Drawing.Size(0, 15);
            this.lblPriceOut.TabIndex = 7;
            this.lblPriceOut.Text = "";
            //
            // lblMessage
            //
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMessage.Location = new System.Drawing.Point(20, 185);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "";
            //
            // Form1
            //
            this.AcceptButton = this.btnSearch;
            this.ClientSize = new System.Drawing.Size(494, 230);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPriceOut);
            this.Controls.Add(this.lblPriceCaption);
            this.Controls.Add(this.lblAuthorOut);
            this.Controls.Add(this.lblAuthorCaption);
            this.Controls.Add(this.lblTitleOut);
            this.Controls.Add(this.lblTitleCaption);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookNook";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTitleCaption;
        private System.Windows.Forms.Label lblTitleOut;
        private System.Windows.Forms.Label lblAuthorCaption;
        private System.Windows.Forms.Label lblAuthorOut;
        private System.Windows.Forms.Label lblPriceCaption;
        private System.Windows.Forms.Label lblPriceOut;
        private System.Windows.Forms.Label lblMessage;
    }
}
