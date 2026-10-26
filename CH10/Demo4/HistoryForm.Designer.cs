namespace Demo4;

partial class HistoryForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lstHistory = new ListBox();
        SuspendLayout();
        //
        // lstHistory
        //
        lstHistory.Font = new Font("Consolas", 10F);
        lstHistory.FormattingEnabled = true;
        lstHistory.Location = new Point(12, 12);
        lstHistory.Name = "lstHistory";
        lstHistory.Size = new Size(360, 200);
        lstHistory.TabIndex = 0;
        //
        // HistoryForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 226);
        Controls.Add(lstHistory);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "HistoryForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Transaction History";
        ResumeLayout(false);
    }

    #endregion

    private ListBox lstHistory;
}
