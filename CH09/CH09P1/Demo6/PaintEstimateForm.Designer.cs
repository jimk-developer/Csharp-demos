namespace Demo6
{
    partial class PaintEstimateForm
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
            lblName = new Label();
            txtName = new TextBox();
            lblWidth = new Label();
            txtWidth = new TextBox();
            lblHeight = new Label();
            txtHeight = new TextBox();
            btnAdd = new Button();
            lstOutput = new ListBox();
            lblMessage = new Label();
            SuspendLayout();
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Wall Name";
            //
            // txtName
            //
            txtName.Location = new Point(110, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 1;
            //
            // lblWidth
            //
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(15, 52);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(68, 15);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Width (feet)";
            //
            // txtWidth
            //
            txtWidth.Location = new Point(110, 49);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(60, 23);
            txtWidth.TabIndex = 3;
            //
            // lblHeight
            //
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(15, 84);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(72, 15);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Height (feet)";
            //
            // txtHeight
            //
            txtHeight.Location = new Point(110, 81);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(60, 23);
            txtHeight.TabIndex = 5;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(110, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // lstOutput
            //
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(15, 155);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(330, 184);
            lstOutput.TabIndex = 7;
            //
            // lblMessage
            //
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblMessage.ForeColor = Color.DarkRed;
            lblMessage.Location = new Point(15, 345);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 17);
            lblMessage.TabIndex = 8;
            //
            // Form1
            //
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 375);
            Controls.Add(lblMessage);
            Controls.Add(lstOutput);
            Controls.Add(btnAdd);
            Controls.Add(txtHeight);
            Controls.Add(lblHeight);
            Controls.Add(txtWidth);
            Controls.Add(lblWidth);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Paint Estimate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblWidth;
        private TextBox txtWidth;
        private Label lblHeight;
        private TextBox txtHeight;
        private Button btnAdd;
        private ListBox lstOutput;
        private Label lblMessage;
    }
}
