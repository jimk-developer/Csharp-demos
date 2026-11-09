namespace Demo4;

partial class MainForm
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
        btnTitle = new Button();
        lblAuthor = new Label();
        txtAuthor = new TextBox();
        btnAuthor = new Button();
        lblResult = new Label();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Location = new Point(20, 23);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(33, 15);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Title:";
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(90, 20);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(200, 23);
        txtTitle.TabIndex = 1;
        txtTitle.KeyDown += txtTitle_KeyDown;
        // 
        // btnTitle
        // 
        btnTitle.Location = new Point(300, 18);
        btnTitle.Name = "btnTitle";
        btnTitle.Size = new Size(120, 27);
        btnTitle.TabIndex = 2;
        btnTitle.Text = "Search Title";
        btnTitle.Click += btnTitle_Click;
        // 
        // lblAuthor
        // 
        lblAuthor.AutoSize = true;
        lblAuthor.Location = new Point(20, 63);
        lblAuthor.Name = "lblAuthor";
        lblAuthor.Size = new Size(47, 15);
        lblAuthor.TabIndex = 3;
        lblAuthor.Text = "Author:";
        // 
        // txtAuthor
        // 
        txtAuthor.Location = new Point(90, 60);
        txtAuthor.Name = "txtAuthor";
        txtAuthor.Size = new Size(200, 23);
        txtAuthor.TabIndex = 4;
        txtAuthor.KeyDown += txtAuthor_KeyDown;
        // 
        // btnAuthor
        // 
        btnAuthor.Location = new Point(300, 58);
        btnAuthor.Name = "btnAuthor";
        btnAuthor.Size = new Size(120, 27);
        btnAuthor.TabIndex = 5;
        btnAuthor.Text = "Search Author";
        btnAuthor.Click += btnAuthor_Click;
        // 
        // lblResult
        // 
        lblResult.Location = new Point(20, 110);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(400, 100);
        lblResult.TabIndex = 6;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 230);
        Controls.Add(lblTitle);
        Controls.Add(txtTitle);
        Controls.Add(btnTitle);
        Controls.Add(lblAuthor);
        Controls.Add(txtAuthor);
        Controls.Add(btnAuthor);
        Controls.Add(lblResult);
        Name = "MainForm";
        Text = "Book Search";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private TextBox txtTitle;
    private Button btnTitle;
    private Label lblAuthor;
    private TextBox txtAuthor;
    private Button btnAuthor;
    private Label lblResult;
}
