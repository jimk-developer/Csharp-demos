namespace Demo2;

partial class ResultsForm
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
        lblResults = new Label();
        lstResults = new ListBox();
        SuspendLayout();
        // 
        // lblResults
        // 
        lblResults.AutoSize = true;
        lblResults.Location = new Point(20, 20);
        lblResults.Name = "lblResults";
        lblResults.TabIndex = 0;
        lblResults.Text = "Matching menu items:";
        // 
        // lstResults
        // 
        lstResults.Location = new Point(20, 45);
        lstResults.Name = "lstResults";
        lstResults.Size = new Size(320, 184);
        lstResults.TabIndex = 1;
        // 
        // ResultsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(360, 250);
        Controls.Add(lblResults);
        Controls.Add(lstResults);
        StartPosition = FormStartPosition.CenterParent;
        Name = "ResultsForm";
        Text = "Search Results";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblResults;
    private ListBox lstResults;
}
