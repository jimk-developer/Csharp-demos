namespace Demo2
{
    partial class TicketValidatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRow = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.lblSeat = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(20, 23);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(78, 15);
            this.lblRow.TabIndex = 0;
            this.lblRow.Text = "Row [ 1, 20 ]";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(140, 20);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(150, 23);
            this.txtRow.TabIndex = 1;
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(20, 58);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(80, 15);
            this.lblSeat.TabIndex = 2;
            this.lblSeat.Text = "Seat [ 1, 30 ]";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(140, 55);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(150, 23);
            this.txtSeat.TabIndex = 3;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(140, 92);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(150, 30);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(20, 145);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "";
            // 
            // TicketValidatorForm
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 210);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TicketValidatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Validator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblResult;
    }
}
