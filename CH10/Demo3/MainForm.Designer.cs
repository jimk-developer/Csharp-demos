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
        btnOpenChest = new Button();
        lblSlot1 = new Label();
        lblSlot2 = new Label();
        lblSlot3 = new Label();
        lblSlot4 = new Label();
        lblSlot5 = new Label();
        lblTotal = new Label();
        SuspendLayout();
        //
        // btnOpenChest
        //
        btnOpenChest.Location = new Point(20, 20);
        btnOpenChest.Name = "btnOpenChest";
        btnOpenChest.Size = new Size(120, 32);
        btnOpenChest.TabIndex = 0;
        btnOpenChest.Text = "Open Chest";
        btnOpenChest.UseVisualStyleBackColor = true;
        btnOpenChest.Click += btnOpenChest_Click;
        //
        // lblSlot1
        //
        lblSlot1.AutoSize = false;
        lblSlot1.BorderStyle = BorderStyle.FixedSingle;
        lblSlot1.Location = new Point(20, 70);
        lblSlot1.Name = "lblSlot1";
        lblSlot1.Padding = new Padding(8, 0, 0, 0);
        lblSlot1.Size = new Size(340, 36);
        lblSlot1.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblSlot2
        //
        lblSlot2.AutoSize = false;
        lblSlot2.BorderStyle = BorderStyle.FixedSingle;
        lblSlot2.Location = new Point(20, 112);
        lblSlot2.Name = "lblSlot2";
        lblSlot2.Padding = new Padding(8, 0, 0, 0);
        lblSlot2.Size = new Size(340, 36);
        lblSlot2.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblSlot3
        //
        lblSlot3.AutoSize = false;
        lblSlot3.BorderStyle = BorderStyle.FixedSingle;
        lblSlot3.Location = new Point(20, 154);
        lblSlot3.Name = "lblSlot3";
        lblSlot3.Padding = new Padding(8, 0, 0, 0);
        lblSlot3.Size = new Size(340, 36);
        lblSlot3.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblSlot4
        //
        lblSlot4.AutoSize = false;
        lblSlot4.BorderStyle = BorderStyle.FixedSingle;
        lblSlot4.Location = new Point(20, 196);
        lblSlot4.Name = "lblSlot4";
        lblSlot4.Padding = new Padding(8, 0, 0, 0);
        lblSlot4.Size = new Size(340, 36);
        lblSlot4.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblSlot5
        //
        lblSlot5.AutoSize = false;
        lblSlot5.BorderStyle = BorderStyle.FixedSingle;
        lblSlot5.Location = new Point(20, 238);
        lblSlot5.Name = "lblSlot5";
        lblSlot5.Padding = new Padding(8, 0, 0, 0);
        lblSlot5.Size = new Size(340, 36);
        lblSlot5.TextAlign = ContentAlignment.MiddleLeft;
        //
        // lblTotal
        //
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTotal.Location = new Point(20, 290);
        lblTotal.Name = "lblTotal";
        lblTotal.Text = "Chest value: $0.00";
        //
        // MainForm
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380, 330);
        Controls.Add(btnOpenChest);
        Controls.Add(lblSlot1);
        Controls.Add(lblSlot2);
        Controls.Add(lblSlot3);
        Controls.Add(lblSlot4);
        Controls.Add(lblSlot5);
        Controls.Add(lblTotal);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Treasure Chest";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnOpenChest;
    private Label lblSlot1;
    private Label lblSlot2;
    private Label lblSlot3;
    private Label lblSlot4;
    private Label lblSlot5;
    private Label lblTotal;
}
