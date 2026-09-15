// ---------------------------------------------------------------------------
// Demo 5 - Punctuation Counter (WinForms) - designer half of the partial
// class. Hand-written so the demo can be handed out as plain source; the
// form still opens normally in the Visual Studio designer.
//
// Controls used: Label, TextBox, Button. Nothing else.
// ---------------------------------------------------------------------------

#nullable disable

namespace Demo5;

partial class PunctuationForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.lblPrompt = new System.Windows.Forms.Label();
        this.txtPhrase = new System.Windows.Forms.TextBox();
        this.btnEnter = new System.Windows.Forms.Button();
        this.lblEnding = new System.Windows.Forms.Label();
        this.lblSeparators = new System.Windows.Forms.Label();
        this.lblOther = new System.Windows.Forms.Label();
        this.lblTotal = new System.Windows.Forms.Label();
        this.SuspendLayout();

        // lblPrompt
        this.lblPrompt.AutoSize = true;
        this.lblPrompt.Location = new System.Drawing.Point(18, 18);
        this.lblPrompt.Name = "lblPrompt";
        this.lblPrompt.Text = "Please enter a phrase";

        // txtPhrase
        this.txtPhrase.Location = new System.Drawing.Point(20, 42);
        this.txtPhrase.Name = "txtPhrase";
        this.txtPhrase.Size = new System.Drawing.Size(300, 23);
        this.txtPhrase.TabIndex = 0;

        // btnEnter
        this.btnEnter.Location = new System.Drawing.Point(332, 41);
        this.btnEnter.Name = "btnEnter";
        this.btnEnter.Size = new System.Drawing.Size(75, 26);
        this.btnEnter.TabIndex = 1;
        this.btnEnter.Text = "Enter";
        this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

        // lblEnding
        this.lblEnding.AutoSize = true;
        this.lblEnding.Location = new System.Drawing.Point(18, 88);
        this.lblEnding.Name = "lblEnding";
        this.lblEnding.Text = "";

        // lblSeparators
        this.lblSeparators.AutoSize = true;
        this.lblSeparators.Location = new System.Drawing.Point(18, 114);
        this.lblSeparators.Name = "lblSeparators";
        this.lblSeparators.Text = "";

        // lblOther
        this.lblOther.AutoSize = true;
        this.lblOther.Location = new System.Drawing.Point(18, 140);
        this.lblOther.Name = "lblOther";
        this.lblOther.Text = "";

        // lblTotal
        this.lblTotal.AutoSize = true;
        this.lblTotal.Location = new System.Drawing.Point(18, 174);
        this.lblTotal.Name = "lblTotal";
        this.lblTotal.Text = "";

        // PunctuationForm
        this.AcceptButton = this.btnEnter;   // Enter key clicks the button
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(430, 212);
        this.Controls.Add(this.lblPrompt);
        this.Controls.Add(this.txtPhrase);
        this.Controls.Add(this.btnEnter);
        this.Controls.Add(this.lblEnding);
        this.Controls.Add(this.lblSeparators);
        this.Controls.Add(this.lblOther);
        this.Controls.Add(this.lblTotal);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "PunctuationForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Punctuation";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblPrompt;
    private System.Windows.Forms.TextBox txtPhrase;
    private System.Windows.Forms.Button btnEnter;
    private System.Windows.Forms.Label lblEnding;
    private System.Windows.Forms.Label lblSeparators;
    private System.Windows.Forms.Label lblOther;
    private System.Windows.Forms.Label lblTotal;
}
