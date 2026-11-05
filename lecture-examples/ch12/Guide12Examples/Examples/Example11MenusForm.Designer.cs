namespace Guide12Examples.Examples;

partial class Example11MenusForm
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
        mainMenuStrip = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        newToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        fileSeparator = new ToolStripSeparator();
        exitToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem = new ToolStripMenuItem();
        cutToolStripMenuItem = new ToolStripMenuItem();
        copyToolStripMenuItem = new ToolStripMenuItem();
        pasteToolStripMenuItem = new ToolStripMenuItem();
        editSeparator = new ToolStripSeparator();
        selectAllToolStripMenuItem = new ToolStripMenuItem();
        viewToolStripMenuItem = new ToolStripMenuItem();
        largerTextToolStripMenuItem = new ToolStripMenuItem();
        smallerTextToolStripMenuItem = new ToolStripMenuItem();
        viewSeparator = new ToolStripSeparator();
        darkModeToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        headerLabel = new Label();
        documentTextBox = new TextBox();
        statusLabel = new Label();
        openTextDialog = new OpenFileDialog();
        mainMenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // mainMenuStrip
        // 
        mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
        mainMenuStrip.Location = new Point(0, 0);
        mainMenuStrip.Name = "mainMenuStrip";
        mainMenuStrip.Size = new Size(784, 24);
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, fileSeparator, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Text = "&File";
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        newToolStripMenuItem.Text = "&New";
        newToolStripMenuItem.Click += newToolStripMenuItem_Click;
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        openToolStripMenuItem.Text = "&Open...";
        openToolStripMenuItem.Click += openToolStripMenuItem_Click;
        // 
        // fileSeparator
        // 
        fileSeparator.Name = "fileSeparator";
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Text = "E&xit";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, editSeparator, selectAllToolStripMenuItem });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Text = "&Edit";
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        cutToolStripMenuItem.Text = "Cu&t";
        cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
        copyToolStripMenuItem.Text = "&Copy";
        copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
        pasteToolStripMenuItem.Text = "&Paste";
        pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
        // 
        // editSeparator
        // 
        editSeparator.Name = "editSeparator";
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
        selectAllToolStripMenuItem.Text = "Select &All";
        selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { largerTextToolStripMenuItem, smallerTextToolStripMenuItem, viewSeparator, darkModeToolStripMenuItem });
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.Text = "&View";
        // 
        // largerTextToolStripMenuItem
        // 
        largerTextToolStripMenuItem.Name = "largerTextToolStripMenuItem";
        largerTextToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl++";
        largerTextToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
        largerTextToolStripMenuItem.Text = "&Larger text";
        largerTextToolStripMenuItem.Click += largerTextToolStripMenuItem_Click;
        // 
        // smallerTextToolStripMenuItem
        // 
        smallerTextToolStripMenuItem.Name = "smallerTextToolStripMenuItem";
        smallerTextToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+-";
        smallerTextToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
        smallerTextToolStripMenuItem.Text = "&Smaller text";
        smallerTextToolStripMenuItem.Click += smallerTextToolStripMenuItem_Click;
        // 
        // viewSeparator
        // 
        viewSeparator.Name = "viewSeparator";
        // 
        // darkModeToolStripMenuItem
        // 
        darkModeToolStripMenuItem.CheckOnClick = true;
        darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
        darkModeToolStripMenuItem.Text = "&Dark mode";
        darkModeToolStripMenuItem.Click += darkModeToolStripMenuItem_Click;
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Text = "&Help";
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.ShortcutKeys = Keys.F1;
        aboutToolStripMenuItem.Text = "&About Guide 12 Examples";
        aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
        // 
        // headerLabel
        // 
        headerLabel.BackColor = Color.FromArgb(30, 27, 46);
        headerLabel.Dock = DockStyle.Top;
        headerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        headerLabel.ForeColor = Color.FromArgb(254, 215, 170);
        headerLabel.Location = new Point(0, 24);
        headerLabel.Name = "headerLabel";
        headerLabel.Padding = new Padding(12, 0, 0, 0);
        headerLabel.Size = new Size(784, 50);
        headerLabel.TabIndex = 0;
        headerLabel.Text = "Guide 12  |  Section 11  |  Menus";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // documentTextBox
        // 
        documentTextBox.AcceptsTab = true;
        documentTextBox.Dock = DockStyle.Fill;
        documentTextBox.Font = new Font("Consolas", 11F);
        documentTextBox.Location = new Point(0, 74);
        documentTextBox.Multiline = true;
        documentTextBox.Name = "documentTextBox";
        documentTextBox.ScrollBars = ScrollBars.Both;
        documentTextBox.Size = new Size(784, 360);
        documentTextBox.TabIndex = 1;
        documentTextBox.WordWrap = false;
        // 
        // statusLabel
        // 
        statusLabel.BackColor = Color.FromArgb(255, 247, 237);
        statusLabel.Dock = DockStyle.Bottom;
        statusLabel.Location = new Point(0, 434);
        statusLabel.Name = "statusLabel";
        statusLabel.Padding = new Padding(8, 0, 0, 0);
        statusLabel.Size = new Size(784, 26);
        statusLabel.TabIndex = 2;
        statusLabel.Text = "Choose a menu command. The name of the Click() method that ran appears here.";
        statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // openTextDialog
        // 
        openTextDialog.Filter = "Text files|*.txt;*.cs;*.md|All files|*.*";
        openTextDialog.Title = "Open a text file";
        // 
        // Example11MenusForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 460);
        Controls.Add(documentTextBox);
        Controls.Add(statusLabel);
        Controls.Add(headerLabel);
        Controls.Add(mainMenuStrip);
        MainMenuStrip = mainMenuStrip;
        Name = "Example11MenusForm";
        Text = "Example 11 - Menus";
        Load += Example11MenusForm_Load;
        mainMenuStrip.ResumeLayout(false);
        mainMenuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip mainMenuStrip;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripSeparator fileSeparator;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem cutToolStripMenuItem;
    private ToolStripMenuItem copyToolStripMenuItem;
    private ToolStripMenuItem pasteToolStripMenuItem;
    private ToolStripSeparator editSeparator;
    private ToolStripMenuItem selectAllToolStripMenuItem;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem largerTextToolStripMenuItem;
    private ToolStripMenuItem smallerTextToolStripMenuItem;
    private ToolStripSeparator viewSeparator;
    private ToolStripMenuItem darkModeToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private Label headerLabel;
    private TextBox documentTextBox;
    private Label statusLabel;
    private OpenFileDialog openTextDialog;
}
