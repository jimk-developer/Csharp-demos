namespace Demo4
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
            lblLength = new Label();
            txtLength = new TextBox();
            lblWidth = new Label();
            txtWidth = new TextBox();
            btnEstimate = new Button();
            lblPerimeterHeading = new Label();
            lblPerimeter = new Label();
            lblCostHeading = new Label();
            lblCost = new Label();
            SuspendLayout();
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(20, 23);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(100, 20);
            lblLength.TabIndex = 0;
            lblLength.Text = "Length (ft):";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(120, 20);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 1;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(250, 23);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(90, 20);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Width (ft):";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(340, 20);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 3;
            // 
            // btnEstimate
            // 
            btnEstimate.Location = new Point(120, 60);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(110, 30);
            btnEstimate.TabIndex = 4;
            btnEstimate.Text = "Estimate";
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // lblPerimeterHeading
            // 
            lblPerimeterHeading.AutoSize = true;
            lblPerimeterHeading.Location = new Point(20, 110);
            lblPerimeterHeading.Name = "lblPerimeterHeading";
            lblPerimeterHeading.Size = new Size(150, 20);
            lblPerimeterHeading.TabIndex = 5;
            lblPerimeterHeading.Text = "Perimeter";
            // 
            // lblPerimeter
            // 
            lblPerimeter.Location = new Point(20, 135);
            lblPerimeter.Name = "lblPerimeter";
            lblPerimeter.Size = new Size(150, 23);
            lblPerimeter.TabIndex = 6;
            lblPerimeter.Text = "";
            // 
            // lblCostHeading
            // 
            lblCostHeading.AutoSize = true;
            lblCostHeading.Location = new Point(250, 110);
            lblCostHeading.Name = "lblCostHeading";
            lblCostHeading.Size = new Size(150, 20);
            lblCostHeading.TabIndex = 7;
            lblCostHeading.Text = "Fence Cost";
            // 
            // lblCost
            // 
            lblCost.Location = new Point(250, 135);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(150, 23);
            lblCost.TabIndex = 8;
            lblCost.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 175);
            Controls.Add(lblLength);
            Controls.Add(txtLength);
            Controls.Add(lblWidth);
            Controls.Add(txtWidth);
            Controls.Add(btnEstimate);
            Controls.Add(lblPerimeterHeading);
            Controls.Add(lblPerimeter);
            Controls.Add(lblCostHeading);
            Controls.Add(lblCost);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fence Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLength;
        private TextBox txtLength;
        private Label lblWidth;
        private TextBox txtWidth;
        private Button btnEstimate;
        private Label lblPerimeterHeading;
        private Label lblPerimeter;
        private Label lblCostHeading;
        private Label lblCost;
    }
}
