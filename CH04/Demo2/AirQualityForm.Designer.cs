namespace Demo2
{
    partial class AirQualityForm
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
            lblAoiReading = new Label();
            lblCategory = new Label();
            txtAqi = new TextBox();
            txtCategory = new TextBox();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // lblAoiReading
            // 
            lblAoiReading.AutoSize = true;
            lblAoiReading.Location = new Point(47, 44);
            lblAoiReading.Name = "lblAoiReading";
            lblAoiReading.Size = new Size(73, 15);
            lblAoiReading.TabIndex = 0;
            lblAoiReading.Text = "AQI Reading";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(288, 46);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // txtAqi
            // 
            txtAqi.Location = new Point(47, 80);
            txtAqi.Name = "txtAqi";
            txtAqi.Size = new Size(100, 23);
            txtAqi.TabIndex = 2;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(288, 80);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(177, 23);
            txtCategory.TabIndex = 3;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(180, 80);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // AirQualityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCheck);
            Controls.Add(txtCategory);
            Controls.Add(txtAqi);
            Controls.Add(lblCategory);
            Controls.Add(lblAoiReading);
            Name = "AirQualityForm";
            Text = "Air Quality Index";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAoiReading;
        private Label lblCategory;
        private TextBox txtAqi;
        private TextBox txtCategory;
        private Button btnCheck;
    }
}
