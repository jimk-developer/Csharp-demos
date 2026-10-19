namespace Demo2
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
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblPoints = new Label();
            txtPoints = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            btnAdd = new Button();
            lblCount = new Label();
            lblTotalPoints = new Label();
            lblDueBy = new Label();
            dtpDueBy = new DateTimePicker();
            btnSearch = new Button();
            lstOutput = new ListBox();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(29, 15);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Title";
            //
            // txtTitle
            //
            txtTitle.Location = new Point(12, 32);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(160, 23);
            txtTitle.TabIndex = 0;
            //
            // lblDueDate
            //
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(182, 12);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 15);
            lblDueDate.TabIndex = 9;
            lblDueDate.Text = "Due Date";
            //
            // dtpDueDate
            //
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(182, 32);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(130, 23);
            dtpDueDate.TabIndex = 1;
            //
            // lblPoints
            //
            lblPoints.AutoSize = true;
            lblPoints.Location = new Point(322, 12);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(40, 15);
            lblPoints.TabIndex = 10;
            lblPoints.Text = "Points";
            //
            // txtPoints
            //
            txtPoints.Location = new Point(322, 32);
            txtPoints.Name = "txtPoints";
            txtPoints.Size = new Size(80, 23);
            txtPoints.TabIndex = 2;
            //
            // lblCategory
            //
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(412, 12);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category";
            //
            // cboCategory
            //
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(412, 32);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(130, 23);
            cboCategory.TabIndex = 3;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(552, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 25);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // lblCount
            //
            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 70);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(104, 15);
            lblCount.TabIndex = 12;
            lblCount.Text = "Assignments: 0/10";
            //
            // lblTotalPoints
            //
            lblTotalPoints.AutoSize = true;
            lblTotalPoints.Location = new Point(182, 70);
            lblTotalPoints.Name = "lblTotalPoints";
            lblTotalPoints.Size = new Size(80, 15);
            lblTotalPoints.TabIndex = 13;
            lblTotalPoints.Text = "Total Points: 0";
            //
            // lblDueBy
            //
            lblDueBy.AutoSize = true;
            lblDueBy.Location = new Point(12, 105);
            lblDueBy.Name = "lblDueBy";
            lblDueBy.Size = new Size(140, 15);
            lblDueBy.TabIndex = 14;
            lblDueBy.Text = "Show assignments due by";
            //
            // dtpDueBy
            //
            dtpDueBy.Format = DateTimePickerFormat.Short;
            dtpDueBy.Location = new Point(12, 125);
            dtpDueBy.Name = "dtpDueBy";
            dtpDueBy.Size = new Size(130, 23);
            dtpDueBy.TabIndex = 5;
            //
            // btnSearch
            //
            btnSearch.Location = new Point(152, 124);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 25);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Show Due By";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            //
            // lstOutput
            //
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(12, 162);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(620, 199);
            lstOutput.TabIndex = 7;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 375);
            Controls.Add(lstOutput);
            Controls.Add(btnSearch);
            Controls.Add(dtpDueBy);
            Controls.Add(lblDueBy);
            Controls.Add(lblTotalPoints);
            Controls.Add(lblCount);
            Controls.Add(btnAdd);
            Controls.Add(cboCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtPoints);
            Controls.Add(lblPoints);
            Controls.Add(dtpDueDate);
            Controls.Add(lblDueDate);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assignment Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private Label lblPoints;
        private TextBox txtPoints;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Button btnAdd;
        private Label lblCount;
        private Label lblTotalPoints;
        private Label lblDueBy;
        private DateTimePicker dtpDueBy;
        private Button btnSearch;
        private ListBox lstOutput;
    }
}
