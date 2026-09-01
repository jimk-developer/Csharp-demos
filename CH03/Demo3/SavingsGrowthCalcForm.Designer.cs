namespace Demo3
{
    partial class SavingsGrowthCalcForm
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
            groupBox1 = new GroupBox();
            txtBalance1 = new TextBox();
            txtName1 = new TextBox();
            lblBalance = new Label();
            lblName = new Label();
            groupBox2 = new GroupBox();
            txtBalance2 = new TextBox();
            txtName2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtBalance3 = new TextBox();
            txtName3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnCalculate = new Button();
            lblResult = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBalance1);
            groupBox1.Controls.Add(txtName1);
            groupBox1.Controls.Add(lblBalance);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 175);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account 1";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // txtBalance1
            // 
            txtBalance1.Location = new Point(19, 113);
            txtBalance1.Name = "txtBalance1";
            txtBalance1.Size = new Size(100, 23);
            txtBalance1.TabIndex = 3;
            // 
            // txtName1
            // 
            txtName1.Location = new Point(19, 52);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(100, 23);
            txtName1.TabIndex = 2;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(19, 95);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(48, 15);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Balance";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBalance2);
            groupBox2.Controls.Add(txtName2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(248, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 175);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account 2";
            // 
            // txtBalance2
            // 
            txtBalance2.Location = new Point(22, 109);
            txtBalance2.Name = "txtBalance2";
            txtBalance2.Size = new Size(100, 23);
            txtBalance2.TabIndex = 4;
            // 
            // txtName2
            // 
            txtName2.Location = new Point(22, 52);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(100, 23);
            txtName2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 91);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Balance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBalance3);
            groupBox3.Controls.Add(txtName3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(465, 52);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 175);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account 3";
            // 
            // txtBalance3
            // 
            txtBalance3.Location = new Point(21, 108);
            txtBalance3.Name = "txtBalance3";
            txtBalance3.Size = new Size(100, 23);
            txtBalance3.TabIndex = 5;
            // 
            // txtName3
            // 
            txtName3.Location = new Point(21, 47);
            txtName3.Name = "txtName3";
            txtName3.Size = new Size(100, 23);
            txtName3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 83);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 22);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(300, 255);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(51, 326);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "label5";
            // 
            // SavingsGrowthCalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SavingsGrowthCalcForm";
            Text = "Savings Growth Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtBalance1;
        private TextBox txtName1;
        private Label lblBalance;
        private Label lblName;
        private TextBox txtBalance2;
        private TextBox txtName2;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox txtBalance3;
        private TextBox txtName3;
        private Label label4;
        private Label label3;
        private Button btnCalculate;
        private Label lblResult;
    }
}
