namespace Demo3;

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
        lblHelp = new Label();
        txtBox1 = new TextBox();
        txtBox2 = new TextBox();
        txtBox3 = new TextBox();
        txtBox4 = new TextBox();
        lblLastEvent = new Label();
        SuspendLayout();
        // 
        // lblHelp
        // 
        lblHelp.AutoSize = true;
        lblHelp.Location = new Point(20, 15);
        lblHelp.Name = "lblHelp";
        lblHelp.TabIndex = 0;
        lblHelp.Text = "Click or Tab between boxes. Press F1 - F4 to jump to a box.";
        // 
        // txtBox1
        // 
        txtBox1.PlaceholderText = "TextBox 1";
        txtBox1.Location = new Point(20, 45);
        txtBox1.Name = "txtBox1";
        txtBox1.Size = new Size(170, 23);
        txtBox1.TabIndex = 1;
        txtBox1.Enter += TextBox_Enter;
        txtBox1.Leave += TextBox_Leave;
        txtBox1.MouseClick += TextBox_MouseClick;
        // 
        // txtBox2
        // 
        txtBox2.PlaceholderText = "TextBox 2";
        txtBox2.Location = new Point(210, 45);
        txtBox2.Name = "txtBox2";
        txtBox2.Size = new Size(170, 23);
        txtBox2.TabIndex = 2;
        txtBox2.Enter += TextBox_Enter;
        txtBox2.Leave += TextBox_Leave;
        txtBox2.MouseClick += TextBox_MouseClick;
        // 
        // txtBox3
        // 
        txtBox3.PlaceholderText = "TextBox 3";
        txtBox3.Location = new Point(20, 95);
        txtBox3.Name = "txtBox3";
        txtBox3.Size = new Size(170, 23);
        txtBox3.TabIndex = 3;
        txtBox3.Enter += TextBox_Enter;
        txtBox3.Leave += TextBox_Leave;
        txtBox3.MouseClick += TextBox_MouseClick;
        // 
        // txtBox4
        // 
        txtBox4.PlaceholderText = "TextBox 4";
        txtBox4.Location = new Point(210, 95);
        txtBox4.Name = "txtBox4";
        txtBox4.Size = new Size(170, 23);
        txtBox4.TabIndex = 4;
        txtBox4.Enter += TextBox_Enter;
        txtBox4.Leave += TextBox_Leave;
        txtBox4.MouseClick += TextBox_MouseClick;
        // 
        // lblLastEvent
        // 
        lblLastEvent.AutoSize = true;
        lblLastEvent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblLastEvent.Location = new Point(20, 150);
        lblLastEvent.Name = "lblLastEvent";
        lblLastEvent.TabIndex = 5;
        lblLastEvent.Text = "Last event: (none)";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 190);
        Controls.Add(lblHelp);
        Controls.Add(txtBox1);
        Controls.Add(txtBox2);
        Controls.Add(txtBox3);
        Controls.Add(txtBox4);
        Controls.Add(lblLastEvent);
        KeyPreview = true;
        Name = "MainForm";
        Text = "Highlight Pad";
        KeyDown += MainForm_KeyDown;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblHelp;
    private TextBox txtBox1;
    private TextBox txtBox2;
    private TextBox txtBox3;
    private TextBox txtBox4;
    private Label lblLastEvent;
}
