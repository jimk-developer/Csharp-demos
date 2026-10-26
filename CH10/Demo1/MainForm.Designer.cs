namespace Demo1;

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
        lblRecipient = new Label();
        txtRecipient = new TextBox();
        lblShipDate = new Label();
        dtpShipDate = new DateTimePicker();
        lblInsuranceCode = new Label();
        txtInsuranceCode = new TextBox();
        lblInsuranceNote = new Label();
        btnShip = new Button();
        lstLog = new ListBox();
        lblTotal = new Label();
        SuspendLayout();
        //
        // lblRecipient
        //
        lblRecipient.AutoSize = true;
        lblRecipient.Location = new Point(20, 23);
        lblRecipient.Name = "lblRecipient";
        lblRecipient.Text = "Recipient";
        //
        // txtRecipient
        //
        txtRecipient.Location = new Point(130, 20);
        txtRecipient.Name = "txtRecipient";
        txtRecipient.Size = new Size(160, 23);
        txtRecipient.TabIndex = 0;
        //
        // lblShipDate
        //
        lblShipDate.AutoSize = true;
        lblShipDate.Location = new Point(20, 63);
        lblShipDate.Name = "lblShipDate";
        lblShipDate.Text = "Ship Date";
        //
        // dtpShipDate
        //
        dtpShipDate.Format = DateTimePickerFormat.Short;
        dtpShipDate.Location = new Point(130, 60);
        dtpShipDate.Name = "dtpShipDate";
        dtpShipDate.Size = new Size(160, 23);
        dtpShipDate.TabIndex = 1;
        //
        // lblInsuranceCode
        //
        lblInsuranceCode.AutoSize = true;
        lblInsuranceCode.Location = new Point(20, 103);
        lblInsuranceCode.Name = "lblInsuranceCode";
        lblInsuranceCode.Text = "Insurance Code";
        //
        // txtInsuranceCode
        //
        txtInsuranceCode.Location = new Point(130, 100);
        txtInsuranceCode.Name = "txtInsuranceCode";
        txtInsuranceCode.Size = new Size(160, 23);
        txtInsuranceCode.TabIndex = 2;
        //
        // lblInsuranceNote
        //
        lblInsuranceNote.AutoSize = true;
        lblInsuranceNote.ForeColor = SystemColors.GrayText;
        lblInsuranceNote.Location = new Point(20, 133);
        lblInsuranceNote.Name = "lblInsuranceNote";
        lblInsuranceNote.Text = "(Optional: adds $2.50 for an insured parcel)";
        //
        // btnShip
        //
        btnShip.Location = new Point(190, 170);
        btnShip.Name = "btnShip";
        btnShip.Size = new Size(100, 30);
        btnShip.TabIndex = 3;
        btnShip.Text = "Ship";
        btnShip.UseVisualStyleBackColor = true;
        btnShip.Click += btnShip_Click;
        //
        // lstLog
        //
        lstLog.FormattingEnabled = true;
        lstLog.HorizontalScrollbar = true;
        lstLog.Location = new Point(320, 20);
        lstLog.Name = "lstLog";
        lstLog.Size = new Size(380, 184);
        lstLog.TabIndex = 4;
        //
        // lblTotal
        //
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTotal.Location = new Point(320, 215);
        lblTotal.Name = "lblTotal";
        lblTotal.Text = "Total: $0.00";
        //
        // MainForm
        //
        AcceptButton = btnShip;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(724, 250);
        Controls.Add(lblRecipient);
        Controls.Add(txtRecipient);
        Controls.Add(lblShipDate);
        Controls.Add(dtpShipDate);
        Controls.Add(lblInsuranceCode);
        Controls.Add(txtInsuranceCode);
        Controls.Add(lblInsuranceNote);
        Controls.Add(btnShip);
        Controls.Add(lstLog);
        Controls.Add(lblTotal);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Parcel Shipping";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblRecipient;
    private TextBox txtRecipient;
    private Label lblShipDate;
    private DateTimePicker dtpShipDate;
    private Label lblInsuranceCode;
    private TextBox txtInsuranceCode;
    private Label lblInsuranceNote;
    private Button btnShip;
    private ListBox lstLog;
    private Label lblTotal;
}
