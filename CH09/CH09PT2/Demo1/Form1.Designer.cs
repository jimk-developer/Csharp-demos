namespace Demo1
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
            lblSize = new Label();
            radSmall = new RadioButton();
            radMedium = new RadioButton();
            radLarge = new RadioButton();
            btnAdd = new Button();
            lblError = new Label();
            lblOrders = new Label();
            lstOrders = new ListBox();
            lblTotal = new Label();
            SuspendLayout();
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(207, 15);
            lblName.TabIndex = 6;
            lblName.Text = "What name do you want on the order?";
            //
            // txtName
            //
            txtName.Location = new Point(12, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 23);
            txtName.TabIndex = 0;
            //
            // lblSize
            //
            lblSize.AutoSize = true;
            lblSize.Location = new Point(12, 75);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(30, 15);
            lblSize.TabIndex = 7;
            lblSize.Text = "Size:";
            //
            // radSmall
            //
            radSmall.AutoSize = true;
            radSmall.Checked = true;
            radSmall.Location = new Point(12, 96);
            radSmall.Name = "radSmall";
            radSmall.Size = new Size(54, 19);
            radSmall.TabIndex = 1;
            radSmall.TabStop = true;
            radSmall.Text = "Small";
            radSmall.UseVisualStyleBackColor = true;
            //
            // radMedium
            //
            radMedium.AutoSize = true;
            radMedium.Location = new Point(12, 121);
            radMedium.Name = "radMedium";
            radMedium.Size = new Size(70, 19);
            radMedium.TabIndex = 2;
            radMedium.Text = "Medium";
            radMedium.UseVisualStyleBackColor = true;
            //
            // radLarge
            //
            radLarge.AutoSize = true;
            radLarge.Location = new Point(12, 146);
            radLarge.Name = "radLarge";
            radLarge.Size = new Size(54, 19);
            radLarge.TabIndex = 3;
            radLarge.Text = "Large";
            radLarge.UseVisualStyleBackColor = true;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(12, 182);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add to Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // lblError
            //
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 224);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 8;
            //
            // lblOrders
            //
            lblOrders.AutoSize = true;
            lblOrders.Location = new Point(290, 15);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(42, 15);
            lblOrders.TabIndex = 9;
            lblOrders.Text = "Orders";
            //
            // lstOrders
            //
            lstOrders.FormattingEnabled = true;
            lstOrders.Location = new Point(290, 36);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(300, 199);
            lstOrders.TabIndex = 5;
            //
            // lblTotal
            //
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(290, 245);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(105, 21);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total: $0.00";
            //
            // Form1
            //
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 285);
            Controls.Add(lblTotal);
            Controls.Add(lstOrders);
            Controls.Add(lblOrders);
            Controls.Add(lblError);
            Controls.Add(btnAdd);
            Controls.Add(radLarge);
            Controls.Add(radMedium);
            Controls.Add(radSmall);
            Controls.Add(lblSize);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coffee Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblSize;
        private RadioButton radSmall;
        private RadioButton radMedium;
        private RadioButton radLarge;
        private Button btnAdd;
        private Label lblError;
        private Label lblOrders;
        private ListBox lstOrders;
        private Label lblTotal;
    }
}
