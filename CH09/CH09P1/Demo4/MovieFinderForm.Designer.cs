namespace Demo4
{
    partial class MovieFinderForm
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblTitleCaption = new Label();
            lblDirectorCaption = new Label();
            lblYearCaption = new Label();
            lblTitle = new Label();
            lblDirector = new Label();
            lblYear = new Label();
            SuspendLayout();
            //
            // txtSearch
            //
            txtSearch.Location = new Point(15, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Title or director";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 0;
            //
            // btnSearch
            //
            btnSearch.Location = new Point(280, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 27);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            //
            // lblTitleCaption
            //
            lblTitleCaption.AutoSize = true;
            lblTitleCaption.Location = new Point(15, 65);
            lblTitleCaption.Name = "lblTitleCaption";
            lblTitleCaption.Size = new Size(32, 15);
            lblTitleCaption.TabIndex = 2;
            lblTitleCaption.Text = "Title:";
            //
            // lblDirectorCaption
            //
            lblDirectorCaption.AutoSize = true;
            lblDirectorCaption.Location = new Point(15, 90);
            lblDirectorCaption.Name = "lblDirectorCaption";
            lblDirectorCaption.Size = new Size(52, 15);
            lblDirectorCaption.TabIndex = 3;
            lblDirectorCaption.Text = "Director:";
            //
            // lblYearCaption
            //
            lblYearCaption.AutoSize = true;
            lblYearCaption.Location = new Point(15, 115);
            lblYearCaption.Name = "lblYearCaption";
            lblYearCaption.Size = new Size(32, 15);
            lblYearCaption.TabIndex = 4;
            lblYearCaption.Text = "Year:";
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(100, 65);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 15);
            lblTitle.TabIndex = 5;
            //
            // lblDirector
            //
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(100, 90);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(0, 15);
            lblDirector.TabIndex = 6;
            //
            // lblYear
            //
            lblYear.AutoSize = true;
            lblYear.Location = new Point(100, 115);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(0, 15);
            lblYear.TabIndex = 7;
            //
            // Form1
            //
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 150);
            Controls.Add(lblYear);
            Controls.Add(lblDirector);
            Controls.Add(lblTitle);
            Controls.Add(lblYearCaption);
            Controls.Add(lblDirectorCaption);
            Controls.Add(lblTitleCaption);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "Form1";
            Text = "Movie Finder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblTitleCaption;
        private Label lblDirectorCaption;
        private Label lblYearCaption;
        private Label lblTitle;
        private Label lblDirector;
        private Label lblYear;
    }
}
