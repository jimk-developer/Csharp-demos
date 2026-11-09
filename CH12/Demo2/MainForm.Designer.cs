namespace Demo2;

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
        lblPrompt = new Label();
        lstCategories = new ListBox();
        btnSearch = new Button();
        SuspendLayout();
        // 
        // lblPrompt
        // 
        lblPrompt.AutoSize = true;
        lblPrompt.Location = new Point(20, 20);
        lblPrompt.Name = "lblPrompt";
        lblPrompt.TabIndex = 0;
        lblPrompt.Text = "Select one or more categories:";
        // 
        // lstCategories
        // 
        lstCategories.SelectionMode = SelectionMode.MultiSimple;
        lstCategories.Location = new Point(20, 45);
        lstCategories.Name = "lstCategories";
        lstCategories.Size = new Size(200, 94);
        lstCategories.TabIndex = 1;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(20, 155);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(100, 30);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Search";
        btnSearch.Click += btnSearch_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(260, 210);
        Controls.Add(lblPrompt);
        Controls.Add(lstCategories);
        Controls.Add(btnSearch);
        Name = "MainForm";
        Text = "Menu Finder";
        Load += MainForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblPrompt;
    private ListBox lstCategories;
    private Button btnSearch;
}
