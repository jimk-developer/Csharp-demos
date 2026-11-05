namespace Guide12Examples.Examples;

partial class Example09ModalDialogForm
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
        nameLabel = new Label();
        nameTextBox = new TextBox();
        infoLabel = new Label();
        okButton = new Button();
        cancelButton = new Button();
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(12, 17);
        nameLabel.Name = "nameLabel";
        nameLabel.TabIndex = 0;
        nameLabel.Text = "&Student name:";
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(110, 13);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(238, 23);
        nameTextBox.TabIndex = 1;
        // 
        // infoLabel
        // 
        infoLabel.ForeColor = Color.DimGray;
        infoLabel.Location = new Point(12, 46);
        infoLabel.Name = "infoLabel";
        infoLabel.Size = new Size(336, 44);
        infoLabel.TabIndex = 2;
        infoLabel.Text = "This form was opened with ShowDialog(), so it is MODAL.\r\nTry clicking the example form behind it: you can't until this closes.";
        // 
        // okButton
        // 
        okButton.DialogResult = DialogResult.OK;
        okButton.Location = new Point(166, 98);
        okButton.Name = "okButton";
        okButton.Size = new Size(88, 30);
        okButton.TabIndex = 3;
        okButton.Text = "OK";
        okButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(260, 98);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(88, 30);
        cancelButton.TabIndex = 4;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // Example09ModalDialogForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(360, 140);
        Controls.Add(cancelButton);
        Controls.Add(okButton);
        Controls.Add(infoLabel);
        Controls.Add(nameTextBox);
        Controls.Add(nameLabel);
        AcceptButton = okButton;
        CancelButton = cancelButton;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Example09ModalDialogForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Sign in  -  opened with ShowDialog()";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label nameLabel;
    private TextBox nameTextBox;
    private Label infoLabel;
    private Button okButton;
    private Button cancelButton;
}
