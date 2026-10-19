namespace Demo3
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            //
            // txtSearch
            //
            txtSearch.Location = new Point(12, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 23);
            txtSearch.TabIndex = 0;
            //
            // btnSearch
            //
            btnSearch.Location = new Point(200, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            //
            // txtResult
            //
            txtResult.Location = new Point(12, 52);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(268, 160);
            txtResult.TabIndex = 2;
            txtResult.TabStop = false;
            //
            // Form1
            //
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 226);
            Controls.Add(txtResult);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet Lookup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtResult;
    }
}
