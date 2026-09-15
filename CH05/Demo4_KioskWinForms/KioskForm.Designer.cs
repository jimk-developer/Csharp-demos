// ---------------------------------------------------------------------------
// Demo 4 - Campus Kiosk Donations (WinForms) - designer half of the partial
// class. Hand-written so the demo can be handed out as plain source; the
// form still opens normally in the Visual Studio designer.
//
// Controls used: Label, TextBox, Button. Nothing else.
// ---------------------------------------------------------------------------

#nullable disable

namespace Demo4;

partial class KioskForm
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
        this.lblAmountPrompt = new System.Windows.Forms.Label();
        this.txtAmount = new System.Windows.Forms.TextBox();
        this.lblKioskPrompt = new System.Windows.Forms.Label();
        this.btnAtrium = new System.Windows.Forms.Button();
        this.btnBookstore = new System.Windows.Forms.Button();
        this.btnCommons = new System.Windows.Forms.Button();
        this.lblError = new System.Windows.Forms.Label();
        this.lblAtrium = new System.Windows.Forms.Label();
        this.lblBookstore = new System.Windows.Forms.Label();
        this.lblCommons = new System.Windows.Forms.Label();
        this.lblGrand = new System.Windows.Forms.Label();
        this.lblLeader = new System.Windows.Forms.Label();
        this.SuspendLayout();

        // lblAmountPrompt
        this.lblAmountPrompt.AutoSize = true;
        this.lblAmountPrompt.Location = new System.Drawing.Point(18, 18);
        this.lblAmountPrompt.Name = "lblAmountPrompt";
        this.lblAmountPrompt.Text = "How much was the donation?";

        // txtAmount
        this.txtAmount.Location = new System.Drawing.Point(20, 42);
        this.txtAmount.Name = "txtAmount";
        this.txtAmount.Size = new System.Drawing.Size(150, 23);
        this.txtAmount.TabIndex = 0;

        // lblKioskPrompt
        this.lblKioskPrompt.AutoSize = true;
        this.lblKioskPrompt.Location = new System.Drawing.Point(18, 78);
        this.lblKioskPrompt.Name = "lblKioskPrompt";
        this.lblKioskPrompt.Text = "Which kiosk?";

        // btnAtrium
        this.btnAtrium.Location = new System.Drawing.Point(20, 102);
        this.btnAtrium.Name = "btnAtrium";
        this.btnAtrium.Size = new System.Drawing.Size(96, 28);
        this.btnAtrium.TabIndex = 1;
        this.btnAtrium.Text = "Atrium";
        this.btnAtrium.Click += new System.EventHandler(this.btnAtrium_Click);

        // btnBookstore
        this.btnBookstore.Location = new System.Drawing.Point(122, 102);
        this.btnBookstore.Name = "btnBookstore";
        this.btnBookstore.Size = new System.Drawing.Size(96, 28);
        this.btnBookstore.TabIndex = 2;
        this.btnBookstore.Text = "Bookstore";
        this.btnBookstore.Click += new System.EventHandler(this.btnBookstore_Click);

        // btnCommons
        this.btnCommons.Location = new System.Drawing.Point(224, 102);
        this.btnCommons.Name = "btnCommons";
        this.btnCommons.Size = new System.Drawing.Size(96, 28);
        this.btnCommons.TabIndex = 3;
        this.btnCommons.Text = "Commons";
        this.btnCommons.Click += new System.EventHandler(this.btnCommons_Click);

        // lblError
        this.lblError.AutoSize = true;
        this.lblError.ForeColor = System.Drawing.Color.Firebrick;
        this.lblError.Location = new System.Drawing.Point(18, 142);
        this.lblError.Name = "lblError";
        this.lblError.Text = "";

        // lblAtrium
        this.lblAtrium.AutoSize = true;
        this.lblAtrium.Location = new System.Drawing.Point(18, 174);
        this.lblAtrium.Name = "lblAtrium";
        this.lblAtrium.Text = "Atrium Donations: $0.00 (0)";

        // lblBookstore
        this.lblBookstore.AutoSize = true;
        this.lblBookstore.Location = new System.Drawing.Point(18, 200);
        this.lblBookstore.Name = "lblBookstore";
        this.lblBookstore.Text = "Bookstore Donations: $0.00 (0)";

        // lblCommons
        this.lblCommons.AutoSize = true;
        this.lblCommons.Location = new System.Drawing.Point(18, 226);
        this.lblCommons.Name = "lblCommons";
        this.lblCommons.Text = "Commons Donations: $0.00 (0)";

        // lblGrand
        this.lblGrand.AutoSize = true;
        this.lblGrand.Location = new System.Drawing.Point(18, 258);
        this.lblGrand.Name = "lblGrand";
        this.lblGrand.Text = "Grand Total: $0.00";

        // lblLeader
        this.lblLeader.AutoSize = true;
        this.lblLeader.Location = new System.Drawing.Point(18, 284);
        this.lblLeader.Name = "lblLeader";
        this.lblLeader.Text = "";

        // KioskForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(344, 320);
        this.Controls.Add(this.lblAmountPrompt);
        this.Controls.Add(this.txtAmount);
        this.Controls.Add(this.lblKioskPrompt);
        this.Controls.Add(this.btnAtrium);
        this.Controls.Add(this.btnBookstore);
        this.Controls.Add(this.btnCommons);
        this.Controls.Add(this.lblError);
        this.Controls.Add(this.lblAtrium);
        this.Controls.Add(this.lblBookstore);
        this.Controls.Add(this.lblCommons);
        this.Controls.Add(this.lblGrand);
        this.Controls.Add(this.lblLeader);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "KioskForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Kiosk Donations";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblAmountPrompt;
    private System.Windows.Forms.TextBox txtAmount;
    private System.Windows.Forms.Label lblKioskPrompt;
    private System.Windows.Forms.Button btnAtrium;
    private System.Windows.Forms.Button btnBookstore;
    private System.Windows.Forms.Button btnCommons;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Label lblAtrium;
    private System.Windows.Forms.Label lblBookstore;
    private System.Windows.Forms.Label lblCommons;
    private System.Windows.Forms.Label lblGrand;
    private System.Windows.Forms.Label lblLeader;
}
