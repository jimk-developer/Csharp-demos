namespace Guide12Examples.Examples;

partial class Example09SettingsForm
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
        infoLabel = new Label();
        themeGroupBox = new GroupBox();
        defaultThemeRadioButton = new RadioButton();
        warmThemeRadioButton = new RadioButton();
        calmThemeRadioButton = new RadioButton();
        closeButton = new Button();
        themeGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // infoLabel
        // 
        infoLabel.Location = new Point(12, 12);
        infoLabel.Name = "infoLabel";
        infoLabel.Size = new Size(336, 40);
        infoLabel.TabIndex = 0;
        infoLabel.Text = "This form was opened with Show(), so it is NON-MODAL.\r\nYou can still click buttons on the example form behind it.";
        // 
        // themeGroupBox
        // 
        themeGroupBox.Controls.Add(defaultThemeRadioButton);
        themeGroupBox.Controls.Add(warmThemeRadioButton);
        themeGroupBox.Controls.Add(calmThemeRadioButton);
        themeGroupBox.Location = new Point(12, 58);
        themeGroupBox.Name = "themeGroupBox";
        themeGroupBox.Size = new Size(336, 108);
        themeGroupBox.TabIndex = 1;
        themeGroupBox.TabStop = false;
        themeGroupBox.Text = "Background color of the example form";
        // 
        // defaultThemeRadioButton
        // 
        defaultThemeRadioButton.AutoSize = true;
        defaultThemeRadioButton.Checked = true;
        defaultThemeRadioButton.Location = new Point(16, 24);
        defaultThemeRadioButton.Name = "defaultThemeRadioButton";
        defaultThemeRadioButton.TabIndex = 2;
        defaultThemeRadioButton.TabStop = true;
        defaultThemeRadioButton.Tag = "Default";
        defaultThemeRadioButton.Text = "&Default";
        defaultThemeRadioButton.UseVisualStyleBackColor = true;
        defaultThemeRadioButton.CheckedChanged += ThemeRadioButton_CheckedChanged;
        // 
        // warmThemeRadioButton
        // 
        warmThemeRadioButton.AutoSize = true;
        warmThemeRadioButton.Location = new Point(16, 50);
        warmThemeRadioButton.Name = "warmThemeRadioButton";
        warmThemeRadioButton.TabIndex = 3;
        warmThemeRadioButton.TabStop = true;
        warmThemeRadioButton.Tag = "Warm";
        warmThemeRadioButton.Text = "&Warm";
        warmThemeRadioButton.UseVisualStyleBackColor = true;
        warmThemeRadioButton.CheckedChanged += ThemeRadioButton_CheckedChanged;
        // 
        // calmThemeRadioButton
        // 
        calmThemeRadioButton.AutoSize = true;
        calmThemeRadioButton.Location = new Point(16, 76);
        calmThemeRadioButton.Name = "calmThemeRadioButton";
        calmThemeRadioButton.TabIndex = 4;
        calmThemeRadioButton.TabStop = true;
        calmThemeRadioButton.Tag = "Calm";
        calmThemeRadioButton.Text = "&Calm blue";
        calmThemeRadioButton.UseVisualStyleBackColor = true;
        calmThemeRadioButton.CheckedChanged += ThemeRadioButton_CheckedChanged;
        // 
        // closeButton
        // 
        closeButton.Location = new Point(248, 176);
        closeButton.Name = "closeButton";
        closeButton.Size = new Size(100, 30);
        closeButton.TabIndex = 5;
        closeButton.Text = "C&lose";
        closeButton.UseVisualStyleBackColor = true;
        closeButton.Click += closeButton_Click;
        // 
        // Example09SettingsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(360, 218);
        Controls.Add(closeButton);
        Controls.Add(themeGroupBox);
        Controls.Add(infoLabel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Example09SettingsForm";
        StartPosition = FormStartPosition.Manual;
        Text = "Settings  -  opened with Show()";
        themeGroupBox.ResumeLayout(false);
        themeGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label infoLabel;
    private GroupBox themeGroupBox;
    private RadioButton defaultThemeRadioButton;
    private RadioButton warmThemeRadioButton;
    private RadioButton calmThemeRadioButton;
    private Button closeButton;
}
