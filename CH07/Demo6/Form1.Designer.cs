namespace Demo6
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
            lblSize = new Label();
            txtSize = new TextBox();
            lblToppings = new Label();
            txtToppings = new TextBox();
            btnEstimate = new Button();
            lblSizeCostHeading = new Label();
            lblToppingCostHeading = new Label();
            lblTotalCostHeading = new Label();
            lblSizeCost = new Label();
            lblToppingCost = new Label();
            lblTotalCost = new Label();
            SuspendLayout();
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(20, 15);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(130, 20);
            lblSize.TabIndex = 0;
            lblSize.Text = "Size (s/m/l):";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(20, 38);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(130, 23);
            txtSize.TabIndex = 1;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Location = new Point(180, 15);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(150, 20);
            lblToppings.TabIndex = 2;
            lblToppings.Text = "Number of Toppings";
            // 
            // txtToppings
            // 
            txtToppings.Location = new Point(180, 38);
            txtToppings.Name = "txtToppings";
            txtToppings.Size = new Size(130, 23);
            txtToppings.TabIndex = 3;
            // 
            // btnEstimate
            // 
            btnEstimate.Location = new Point(20, 80);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(110, 30);
            btnEstimate.TabIndex = 4;
            btnEstimate.Text = "Estimate";
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // lblSizeCostHeading
            // 
            lblSizeCostHeading.AutoSize = true;
            lblSizeCostHeading.Location = new Point(20, 130);
            lblSizeCostHeading.Name = "lblSizeCostHeading";
            lblSizeCostHeading.Size = new Size(120, 20);
            lblSizeCostHeading.TabIndex = 5;
            lblSizeCostHeading.Text = "Size Cost";
            // 
            // lblToppingCostHeading
            // 
            lblToppingCostHeading.AutoSize = true;
            lblToppingCostHeading.Location = new Point(170, 130);
            lblToppingCostHeading.Name = "lblToppingCostHeading";
            lblToppingCostHeading.Size = new Size(120, 20);
            lblToppingCostHeading.TabIndex = 6;
            lblToppingCostHeading.Text = "Topping Cost";
            // 
            // lblTotalCostHeading
            // 
            lblTotalCostHeading.AutoSize = true;
            lblTotalCostHeading.Location = new Point(320, 130);
            lblTotalCostHeading.Name = "lblTotalCostHeading";
            lblTotalCostHeading.Size = new Size(120, 20);
            lblTotalCostHeading.TabIndex = 7;
            lblTotalCostHeading.Text = "Total Cost";
            // 
            // lblSizeCost
            // 
            lblSizeCost.Location = new Point(20, 155);
            lblSizeCost.Name = "lblSizeCost";
            lblSizeCost.Size = new Size(120, 23);
            lblSizeCost.TabIndex = 8;
            lblSizeCost.Text = "";
            // 
            // lblToppingCost
            // 
            lblToppingCost.Location = new Point(170, 155);
            lblToppingCost.Name = "lblToppingCost";
            lblToppingCost.Size = new Size(120, 23);
            lblToppingCost.TabIndex = 9;
            lblToppingCost.Text = "";
            // 
            // lblTotalCost
            // 
            lblTotalCost.Location = new Point(320, 155);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(120, 23);
            lblTotalCost.TabIndex = 10;
            lblTotalCost.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 195);
            Controls.Add(lblSize);
            Controls.Add(txtSize);
            Controls.Add(lblToppings);
            Controls.Add(txtToppings);
            Controls.Add(btnEstimate);
            Controls.Add(lblSizeCostHeading);
            Controls.Add(lblToppingCostHeading);
            Controls.Add(lblTotalCostHeading);
            Controls.Add(lblSizeCost);
            Controls.Add(lblToppingCost);
            Controls.Add(lblTotalCost);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizza Price Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSize;
        private TextBox txtSize;
        private Label lblToppings;
        private TextBox txtToppings;
        private Button btnEstimate;
        private Label lblSizeCostHeading;
        private Label lblToppingCostHeading;
        private Label lblTotalCostHeading;
        private Label lblSizeCost;
        private Label lblToppingCost;
        private Label lblTotalCost;
    }
}
