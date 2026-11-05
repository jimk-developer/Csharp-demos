namespace Guide12Examples;

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
        headerLabel = new Label();
        exampleFlowPanel = new FlowLayoutPanel();
        footerLabel = new Label();
        SuspendLayout();
        //
        // headerLabel
        //
        headerLabel.BackColor = Color.FromArgb(30, 27, 46);
        headerLabel.Dock = DockStyle.Top;
        headerLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        headerLabel.ForeColor = Color.FromArgb(254, 215, 170);
        headerLabel.Location = new Point(0, 0);
        headerLabel.Name = "headerLabel";
        headerLabel.Padding = new Padding(12, 0, 0, 0);
        headerLabel.Size = new Size(624, 56);
        headerLabel.TabIndex = 0;
        headerLabel.Text = "Guide 12: Microsoft Visual C# - Using Controls";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // exampleFlowPanel
        //
        exampleFlowPanel.AutoScroll = true;
        exampleFlowPanel.Dock = DockStyle.Fill;
        exampleFlowPanel.FlowDirection = FlowDirection.TopDown;
        exampleFlowPanel.Location = new Point(0, 56);
        exampleFlowPanel.Name = "exampleFlowPanel";
        exampleFlowPanel.Padding = new Padding(12, 8, 12, 8);
        exampleFlowPanel.Size = new Size(624, 577);
        exampleFlowPanel.TabIndex = 1;
        exampleFlowPanel.WrapContents = false;
        //
        // footerLabel
        //
        footerLabel.BackColor = Color.FromArgb(255, 247, 237);
        footerLabel.Dock = DockStyle.Bottom;
        footerLabel.Location = new Point(0, 633);
        footerLabel.Name = "footerLabel";
        footerLabel.Padding = new Padding(12, 0, 0, 0);
        footerLabel.Size = new Size(624, 48);
        footerLabel.TabIndex = 2;
        footerLabel.Text = "Each example matches a section of Guide 12, in order. Open an example, then open its .cs file\r\n(teaching code) and .Designer.cs file (IDE-generated code) side by side in Visual Studio.";
        footerLabel.TextAlign = ContentAlignment.MiddleLeft;
        //
        // MainForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(624, 681);
        Controls.Add(exampleFlowPanel);
        Controls.Add(footerLabel);
        Controls.Add(headerLabel);
        MinimumSize = new Size(560, 400);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Guide 12 Examples - Launcher";
        ResumeLayout(false);
    }

    #endregion

    private Label headerLabel;
    private FlowLayoutPanel exampleFlowPanel;
    private Label footerLabel;
}
