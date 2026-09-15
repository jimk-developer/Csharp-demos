// ---------------------------------------------------------------------------
// Demo 2 - Rainfall Log (WinForms) - designer half of the partial class.
//
// This is the file Visual Studio normally writes for you when you drag
// controls onto the form. It is hand-written here so the demo can be handed
// out as plain source. You can open the form in the designer afterward and
// everything will appear as expected.
//
// Controls used: Label, TextBox, Button. Nothing else.
//
// #nullable disable matches what VS puts in generated designer files: the
// control fields are assigned in InitializeComponent, which the compiler's
// null analysis cannot see from the constructor.
// ---------------------------------------------------------------------------

#nullable disable

namespace Demo2;

partial class RainfallForm
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
        this.txtReading = new System.Windows.Forms.TextBox();
        this.btnEnter = new System.Windows.Forms.Button();
        this.lblError = new System.Windows.Forms.Label();
        this.lblCount = new System.Windows.Forms.Label();
        this.lblTotal = new System.Windows.Forms.Label();
        this.lblAverage = new System.Windows.Forms.Label();
        this.lblWettest = new System.Windows.Forms.Label();
        this.lblDry = new System.Windows.Forms.Label();
        this.SuspendLayout();

        // lblPrompt
        this.lblPrompt.AutoSize = true;
        this.lblPrompt.Location = new System.Drawing.Point(18, 18);
        this.lblPrompt.Name = "lblPrompt";
        this.lblPrompt.Text = "Please enter a rainfall reading";

        // txtReading
        this.txtReading.Location = new System.Drawing.Point(20, 42);
        this.txtReading.Name = "txtReading";
        this.txtReading.Size = new System.Drawing.Size(150, 23);
        this.txtReading.TabIndex = 0;

        // btnEnter
        this.btnEnter.Location = new System.Drawing.Point(20, 76);
        this.btnEnter.Name = "btnEnter";
        this.btnEnter.Size = new System.Drawing.Size(75, 26);
        this.btnEnter.TabIndex = 1;
        this.btnEnter.Text = "Enter";
        this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

        // lblError
        this.lblError.AutoSize = true;
        this.lblError.ForeColor = System.Drawing.Color.Firebrick;
        this.lblError.Location = new System.Drawing.Point(106, 82);
        this.lblError.Name = "lblError";
        this.lblError.Text = "";

        // lblCount
        this.lblCount.AutoSize = true;
        this.lblCount.Location = new System.Drawing.Point(18, 122);
        this.lblCount.Name = "lblCount";
        this.lblCount.Text = "Number of readings: 0";

        // lblTotal
        this.lblTotal.AutoSize = true;
        this.lblTotal.Location = new System.Drawing.Point(18, 148);
        this.lblTotal.Name = "lblTotal";
        this.lblTotal.Text = "Total rainfall: 0.00";

        // lblAverage
        this.lblAverage.AutoSize = true;
        this.lblAverage.Location = new System.Drawing.Point(18, 174);
        this.lblAverage.Name = "lblAverage";
        this.lblAverage.Text = "Average reading: 0.00";

        // lblWettest
        this.lblWettest.AutoSize = true;
        this.lblWettest.Location = new System.Drawing.Point(18, 200);
        this.lblWettest.Name = "lblWettest";
        this.lblWettest.Text = "Wettest reading: 0.00";

        // lblDry
        this.lblDry.AutoSize = true;
        this.lblDry.Location = new System.Drawing.Point(18, 226);
        this.lblDry.Name = "lblDry";
        this.lblDry.Text = "Dry days: 0";

        // RainfallForm
        this.AcceptButton = this.btnEnter;   // Enter key clicks the button
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(324, 264);
        this.Controls.Add(this.lblPrompt);
        this.Controls.Add(this.txtReading);
        this.Controls.Add(this.btnEnter);
        this.Controls.Add(this.lblError);
        this.Controls.Add(this.lblCount);
        this.Controls.Add(this.lblTotal);
        this.Controls.Add(this.lblAverage);
        this.Controls.Add(this.lblWettest);
        this.Controls.Add(this.lblDry);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "RainfallForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Rainfall Log";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblPrompt;
    private System.Windows.Forms.TextBox txtReading;
    private System.Windows.Forms.Button btnEnter;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Label lblAverage;
    private System.Windows.Forms.Label lblWettest;
    private System.Windows.Forms.Label lblDry;
}
