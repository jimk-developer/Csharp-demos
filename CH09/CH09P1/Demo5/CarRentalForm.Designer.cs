namespace Demo5
{
    partial class CarRentalForm
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
            lblCustomer = new Label();
            txtCustomer = new TextBox();
            lblDays = new Label();
            txtDays = new TextBox();
            lblDailyRate = new Label();
            txtDailyRate = new TextBox();
            btnCalculate = new Button();
            lblOutput = new Label();
            SuspendLayout();
            //
            // lblCustomer
            //
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(15, 20);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(59, 15);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer";
            //
            // txtCustomer
            //
            txtCustomer.Location = new Point(110, 17);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(180, 23);
            txtCustomer.TabIndex = 1;
            //
            // lblDays
            //
            lblDays.AutoSize = true;
            lblDays.Location = new Point(15, 52);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(32, 15);
            lblDays.TabIndex = 2;
            lblDays.Text = "Days";
            //
            // txtDays
            //
            txtDays.Location = new Point(110, 49);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(80, 23);
            txtDays.TabIndex = 3;
            //
            // lblDailyRate
            //
            lblDailyRate.AutoSize = true;
            lblDailyRate.Location = new Point(15, 84);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(60, 15);
            lblDailyRate.TabIndex = 4;
            lblDailyRate.Text = "Daily Rate";
            //
            // txtDailyRate
            //
            txtDailyRate.Location = new Point(110, 81);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(80, 23);
            txtDailyRate.TabIndex = 5;
            //
            // btnCalculate
            //
            btnCalculate.Location = new Point(110, 115);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 27);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            //
            // lblOutput
            //
            lblOutput.Font = new Font("Segoe UI", 11F);
            lblOutput.Location = new Point(15, 155);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(300, 110);
            lblOutput.TabIndex = 7;
            //
            // Form1
            //
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 280);
            Controls.Add(lblOutput);
            Controls.Add(btnCalculate);
            Controls.Add(txtDailyRate);
            Controls.Add(lblDailyRate);
            Controls.Add(txtDays);
            Controls.Add(lblDays);
            Controls.Add(txtCustomer);
            Controls.Add(lblCustomer);
            Name = "Form1";
            Text = "Car Rental Estimate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomer;
        private TextBox txtCustomer;
        private Label lblDays;
        private TextBox txtDays;
        private Label lblDailyRate;
        private TextBox txtDailyRate;
        private Button btnCalculate;
        private Label lblOutput;
    }
}
