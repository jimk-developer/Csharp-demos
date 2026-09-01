namespace Demo2
{
    partial class VendingMachineForm
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
            Button btnCalculate;
            label1 = new Label();
            txtMachine1 = new TextBox();
            txtMachine2 = new TextBox();
            txtMachine3 = new TextBox();
            txtMachine4 = new TextBox();
            lblResult = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(259, 145);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 31);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter snacks by machine";
            // 
            // txtMachine1
            // 
            txtMachine1.Location = new Point(58, 86);
            txtMachine1.Name = "txtMachine1";
            txtMachine1.Size = new Size(100, 23);
            txtMachine1.TabIndex = 1;
            // 
            // txtMachine2
            // 
            txtMachine2.Location = new Point(187, 86);
            txtMachine2.Name = "txtMachine2";
            txtMachine2.Size = new Size(100, 23);
            txtMachine2.TabIndex = 2;
            // 
            // txtMachine3
            // 
            txtMachine3.Location = new Point(320, 86);
            txtMachine3.Name = "txtMachine3";
            txtMachine3.Size = new Size(100, 23);
            txtMachine3.TabIndex = 3;
            // 
            // txtMachine4
            // 
            txtMachine4.Location = new Point(439, 86);
            txtMachine4.Name = "txtMachine4";
            txtMachine4.Size = new Size(100, 23);
            txtMachine4.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(226, 197);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 6;
            // 
            // VendingMachineForm
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtMachine4);
            Controls.Add(txtMachine3);
            Controls.Add(txtMachine2);
            Controls.Add(txtMachine1);
            Controls.Add(label1);
            Name = "VendingMachineForm";
            Text = "Vending Machine Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMachine1;
        private TextBox txtMachine2;
        private TextBox txtMachine3;
        private TextBox txtMachine4;
        private Label lblResult;
    }
}
