namespace Demo2
{
    partial class LibraryBooksForm
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
            lblStaffCode = new Label();
            txtStaffCode = new TextBox();
            grpSearch = new GroupBox();
            lblSearchId = new Label();
            txtSearchId = new TextBox();
            btnSearch = new Button();
            lblBookInfo = new Label();
            grpAdd = new GroupBox();
            lblAddTitle = new Label();
            txtAddTitle = new TextBox();
            lblAddId = new Label();
            txtAddId = new TextBox();
            lblAddCopies = new Label();
            txtAddCopies = new TextBox();
            btnAdd = new Button();
            grpUpdate = new GroupBox();
            lblUpdateId = new Label();
            txtUpdateId = new TextBox();
            lblUpdateCopies = new Label();
            txtUpdateCopies = new TextBox();
            btnUpdate = new Button();
            grpDelete = new GroupBox();
            lblDeleteId = new Label();
            txtDeleteId = new TextBox();
            btnDelete = new Button();
            lblMessage = new Label();
            grpSearch.SuspendLayout();
            grpAdd.SuspendLayout();
            grpUpdate.SuspendLayout();
            grpDelete.SuspendLayout();
            SuspendLayout();
            //
            // lblStaffCode
            //
            lblStaffCode.AutoSize = true;
            lblStaffCode.Location = new Point(12, 15);
            lblStaffCode.Name = "lblStaffCode";
            lblStaffCode.Size = new Size(63, 15);
            lblStaffCode.TabIndex = 0;
            lblStaffCode.Text = "Staff Code";
            //
            // txtStaffCode
            //
            txtStaffCode.Location = new Point(85, 12);
            txtStaffCode.Name = "txtStaffCode";
            txtStaffCode.PasswordChar = '*';
            txtStaffCode.Size = new Size(80, 23);
            txtStaffCode.TabIndex = 1;
            //
            // grpSearch
            //
            grpSearch.Controls.Add(lblSearchId);
            grpSearch.Controls.Add(txtSearchId);
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Controls.Add(lblBookInfo);
            grpSearch.Location = new Point(12, 45);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(520, 95);
            grpSearch.TabIndex = 2;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search";
            //
            // lblSearchId
            //
            lblSearchId.AutoSize = true;
            lblSearchId.Location = new Point(10, 28);
            lblSearchId.Name = "lblSearchId";
            lblSearchId.Size = new Size(48, 15);
            lblSearchId.TabIndex = 0;
            lblSearchId.Text = "Book ID";
            //
            // txtSearchId
            //
            txtSearchId.Location = new Point(70, 25);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(80, 23);
            txtSearchId.TabIndex = 1;
            //
            // btnSearch
            //
            btnSearch.Location = new Point(410, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 27);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            //
            // lblBookInfo
            //
            lblBookInfo.Location = new Point(10, 60);
            lblBookInfo.Name = "lblBookInfo";
            lblBookInfo.Size = new Size(500, 25);
            lblBookInfo.TabIndex = 3;
            //
            // grpAdd
            //
            grpAdd.Controls.Add(lblAddTitle);
            grpAdd.Controls.Add(txtAddTitle);
            grpAdd.Controls.Add(lblAddId);
            grpAdd.Controls.Add(txtAddId);
            grpAdd.Controls.Add(lblAddCopies);
            grpAdd.Controls.Add(txtAddCopies);
            grpAdd.Controls.Add(btnAdd);
            grpAdd.Location = new Point(12, 150);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(520, 65);
            grpAdd.TabIndex = 3;
            grpAdd.TabStop = false;
            grpAdd.Text = "Add Book";
            //
            // lblAddTitle
            //
            lblAddTitle.AutoSize = true;
            lblAddTitle.Location = new Point(10, 28);
            lblAddTitle.Name = "lblAddTitle";
            lblAddTitle.Size = new Size(29, 15);
            lblAddTitle.TabIndex = 0;
            lblAddTitle.Text = "Title";
            //
            // txtAddTitle
            //
            txtAddTitle.Location = new Point(45, 25);
            txtAddTitle.Name = "txtAddTitle";
            txtAddTitle.Size = new Size(140, 23);
            txtAddTitle.TabIndex = 1;
            //
            // lblAddId
            //
            lblAddId.AutoSize = true;
            lblAddId.Location = new Point(195, 28);
            lblAddId.Name = "lblAddId";
            lblAddId.Size = new Size(18, 15);
            lblAddId.TabIndex = 2;
            lblAddId.Text = "ID";
            //
            // txtAddId
            //
            txtAddId.Location = new Point(220, 25);
            txtAddId.Name = "txtAddId";
            txtAddId.Size = new Size(60, 23);
            txtAddId.TabIndex = 3;
            //
            // lblAddCopies
            //
            lblAddCopies.AutoSize = true;
            lblAddCopies.Location = new Point(290, 28);
            lblAddCopies.Name = "lblAddCopies";
            lblAddCopies.Size = new Size(43, 15);
            lblAddCopies.TabIndex = 4;
            lblAddCopies.Text = "Copies";
            //
            // txtAddCopies
            //
            txtAddCopies.Location = new Point(340, 25);
            txtAddCopies.Name = "txtAddCopies";
            txtAddCopies.Size = new Size(50, 23);
            txtAddCopies.TabIndex = 5;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(410, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // grpUpdate
            //
            grpUpdate.Controls.Add(lblUpdateId);
            grpUpdate.Controls.Add(txtUpdateId);
            grpUpdate.Controls.Add(lblUpdateCopies);
            grpUpdate.Controls.Add(txtUpdateCopies);
            grpUpdate.Controls.Add(btnUpdate);
            grpUpdate.Location = new Point(12, 225);
            grpUpdate.Name = "grpUpdate";
            grpUpdate.Size = new Size(520, 65);
            grpUpdate.TabIndex = 4;
            grpUpdate.TabStop = false;
            grpUpdate.Text = "Update Copies";
            //
            // lblUpdateId
            //
            lblUpdateId.AutoSize = true;
            lblUpdateId.Location = new Point(10, 28);
            lblUpdateId.Name = "lblUpdateId";
            lblUpdateId.Size = new Size(48, 15);
            lblUpdateId.TabIndex = 0;
            lblUpdateId.Text = "Book ID";
            //
            // txtUpdateId
            //
            txtUpdateId.Location = new Point(70, 25);
            txtUpdateId.Name = "txtUpdateId";
            txtUpdateId.Size = new Size(80, 23);
            txtUpdateId.TabIndex = 1;
            //
            // lblUpdateCopies
            //
            lblUpdateCopies.AutoSize = true;
            lblUpdateCopies.Location = new Point(165, 28);
            lblUpdateCopies.Name = "lblUpdateCopies";
            lblUpdateCopies.Size = new Size(70, 15);
            lblUpdateCopies.TabIndex = 2;
            lblUpdateCopies.Text = "New Copies";
            //
            // txtUpdateCopies
            //
            txtUpdateCopies.Location = new Point(245, 25);
            txtUpdateCopies.Name = "txtUpdateCopies";
            txtUpdateCopies.Size = new Size(50, 23);
            txtUpdateCopies.TabIndex = 3;
            //
            // btnUpdate
            //
            btnUpdate.Location = new Point(410, 23);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            //
            // grpDelete
            //
            grpDelete.Controls.Add(lblDeleteId);
            grpDelete.Controls.Add(txtDeleteId);
            grpDelete.Controls.Add(btnDelete);
            grpDelete.Location = new Point(12, 300);
            grpDelete.Name = "grpDelete";
            grpDelete.Size = new Size(520, 65);
            grpDelete.TabIndex = 5;
            grpDelete.TabStop = false;
            grpDelete.Text = "Delete Book";
            //
            // lblDeleteId
            //
            lblDeleteId.AutoSize = true;
            lblDeleteId.Location = new Point(10, 28);
            lblDeleteId.Name = "lblDeleteId";
            lblDeleteId.Size = new Size(48, 15);
            lblDeleteId.TabIndex = 0;
            lblDeleteId.Text = "Book ID";
            //
            // txtDeleteId
            //
            txtDeleteId.Location = new Point(70, 25);
            txtDeleteId.Name = "txtDeleteId";
            txtDeleteId.Size = new Size(80, 23);
            txtDeleteId.TabIndex = 1;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(410, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // lblMessage
            //
            lblMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblMessage.ForeColor = Color.DarkRed;
            lblMessage.Location = new Point(12, 375);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(520, 25);
            lblMessage.TabIndex = 6;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 410);
            Controls.Add(lblMessage);
            Controls.Add(grpDelete);
            Controls.Add(grpUpdate);
            Controls.Add(grpAdd);
            Controls.Add(grpSearch);
            Controls.Add(txtStaffCode);
            Controls.Add(lblStaffCode);
            Name = "Form1";
            Text = "Library Books";
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            grpUpdate.ResumeLayout(false);
            grpUpdate.PerformLayout();
            grpDelete.ResumeLayout(false);
            grpDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStaffCode;
        private TextBox txtStaffCode;
        private GroupBox grpSearch;
        private Label lblSearchId;
        private TextBox txtSearchId;
        private Button btnSearch;
        private Label lblBookInfo;
        private GroupBox grpAdd;
        private Label lblAddTitle;
        private TextBox txtAddTitle;
        private Label lblAddId;
        private TextBox txtAddId;
        private Label lblAddCopies;
        private TextBox txtAddCopies;
        private Button btnAdd;
        private GroupBox grpUpdate;
        private Label lblUpdateId;
        private TextBox txtUpdateId;
        private Label lblUpdateCopies;
        private TextBox txtUpdateCopies;
        private Button btnUpdate;
        private GroupBox grpDelete;
        private Label lblDeleteId;
        private TextBox txtDeleteId;
        private Button btnDelete;
        private Label lblMessage;
    }
}
