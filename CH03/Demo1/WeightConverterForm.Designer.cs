namespace Demo1
{
    partial class WeightConverterForm
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
            lblWeightInKilograms = new Label();
            txtWeightInPounds = new TextBox();
            txtWeightInKilograms = new TextBox();
            lblResult = new Label();
            btnConvertToKilograms = new Button();
            btnConvertToPounds = new Button();
            lblWeightInPounds = new Label();
            SuspendLayout();
            // 
            // lblWeightInKilograms
            // 
            lblWeightInKilograms.AutoSize = true;
            lblWeightInKilograms.Location = new Point(40, 74);
            lblWeightInKilograms.Name = "lblWeightInKilograms";
            lblWeightInKilograms.Size = new Size(117, 15);
            lblWeightInKilograms.TabIndex = 1;
            lblWeightInKilograms.Text = "Weight in Kilograms:";
            // 
            // txtWeightInPounds
            // 
            txtWeightInPounds.Location = new Point(159, 26);
            txtWeightInPounds.Name = "txtWeightInPounds";
            txtWeightInPounds.Size = new Size(100, 23);
            txtWeightInPounds.TabIndex = 2;
            // 
            // txtWeightInKilograms
            // 
            txtWeightInKilograms.Location = new Point(160, 71);
            txtWeightInKilograms.Name = "txtWeightInKilograms";
            txtWeightInKilograms.Size = new Size(100, 23);
            txtWeightInKilograms.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(69, 178);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 4;
            // 
            // btnConvertToKilograms
            // 
            btnConvertToKilograms.Location = new Point(69, 125);
            btnConvertToKilograms.Name = "btnConvertToKilograms";
            btnConvertToKilograms.Size = new Size(88, 23);
            btnConvertToKilograms.TabIndex = 5;
            btnConvertToKilograms.Text = "Convert to kg";
            btnConvertToKilograms.UseVisualStyleBackColor = true;
            btnConvertToKilograms.Click += btnConvertToKilograms_Click;
            // 
            // btnConvertToPounds
            // 
            btnConvertToPounds.Location = new Point(174, 125);
            btnConvertToPounds.Name = "btnConvertToPounds";
            btnConvertToPounds.Size = new Size(85, 23);
            btnConvertToPounds.TabIndex = 6;
            btnConvertToPounds.Text = "Convert to lb";
            btnConvertToPounds.UseVisualStyleBackColor = true;
            btnConvertToPounds.Click += btnConvertToPounds_Click;
            // 
            // lblWeightInPounds
            // 
            lblWeightInPounds.AutoSize = true;
            lblWeightInPounds.Location = new Point(40, 29);
            lblWeightInPounds.Name = "lblWeightInPounds";
            lblWeightInPounds.Size = new Size(104, 15);
            lblWeightInPounds.TabIndex = 7;
            lblWeightInPounds.Text = "Weight in pounds:";
            // 
            // WeightConverterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWeightInPounds);
            Controls.Add(btnConvertToPounds);
            Controls.Add(btnConvertToKilograms);
            Controls.Add(lblResult);
            Controls.Add(txtWeightInKilograms);
            Controls.Add(txtWeightInPounds);
            Controls.Add(lblWeightInKilograms);
            Name = "WeightConverterForm";
            Text = "Weight Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWeightInKilograms;
        private TextBox txtWeightInPounds;
        private TextBox txtWeightInKilograms;
        private Label lblResult;
        private Button btnConvertToKilograms;
        private Button btnConvertToPounds;
        private Label lblWeightInPounds;
    }
}
