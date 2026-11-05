namespace Guide12Examples.Examples;

partial class Example06GraphicsForm
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
        photoPictureBox = new PictureBox();
        sizeModeGroupBox = new GroupBox();
        normalRadioButton = new RadioButton();
        stretchRadioButton = new RadioButton();
        centerRadioButton = new RadioButton();
        zoomRadioButton = new RadioButton();
        loadImageButton = new Button();
        imageInfoLabel = new Label();
        designerPictureBox = new PictureBox();
        stepsLabel = new Label();
        openImageDialog = new OpenFileDialog();
        sizeModeGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // headerLabel
        // 
        headerLabel.BackColor = Color.FromArgb(30, 27, 46);
        headerLabel.Dock = DockStyle.Top;
        headerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        headerLabel.ForeColor = Color.FromArgb(254, 215, 170);
        headerLabel.Location = new Point(0, 0);
        headerLabel.Name = "headerLabel";
        headerLabel.Padding = new Padding(12, 0, 0, 0);
        headerLabel.Size = new Size(784, 50);
        headerLabel.TabIndex = 0;
        headerLabel.Text = "Guide 12  |  Section 6  |  Graphics";
        headerLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // photoPictureBox
        // 
        photoPictureBox.BackColor = Color.White;
        photoPictureBox.BorderStyle = BorderStyle.FixedSingle;
        photoPictureBox.Location = new Point(12, 60);
        photoPictureBox.Name = "photoPictureBox";
        photoPictureBox.Size = new Size(400, 300);
        photoPictureBox.TabIndex = 1;
        photoPictureBox.TabStop = false;
        // 
        // sizeModeGroupBox
        // 
        sizeModeGroupBox.Controls.Add(normalRadioButton);
        sizeModeGroupBox.Controls.Add(stretchRadioButton);
        sizeModeGroupBox.Controls.Add(centerRadioButton);
        sizeModeGroupBox.Controls.Add(zoomRadioButton);
        sizeModeGroupBox.Location = new Point(424, 56);
        sizeModeGroupBox.Name = "sizeModeGroupBox";
        sizeModeGroupBox.Size = new Size(348, 148);
        sizeModeGroupBox.TabIndex = 2;
        sizeModeGroupBox.TabStop = false;
        sizeModeGroupBox.Text = "photoPictureBox.SizeMode";
        // 
        // normalRadioButton
        // 
        normalRadioButton.AutoSize = true;
        normalRadioButton.Checked = true;
        normalRadioButton.Location = new Point(16, 26);
        normalRadioButton.Name = "normalRadioButton";
        normalRadioButton.TabIndex = 3;
        normalRadioButton.TabStop = true;
        normalRadioButton.Tag = "Normal";
        normalRadioButton.Text = "&Normal (top-left, cropped)";
        normalRadioButton.UseVisualStyleBackColor = true;
        normalRadioButton.CheckedChanged += SizeModeRadioButton_CheckedChanged;
        // 
        // stretchRadioButton
        // 
        stretchRadioButton.AutoSize = true;
        stretchRadioButton.Location = new Point(16, 54);
        stretchRadioButton.Name = "stretchRadioButton";
        stretchRadioButton.TabIndex = 4;
        stretchRadioButton.TabStop = true;
        stretchRadioButton.Tag = "StretchImage";
        stretchRadioButton.Text = "&StretchImage (fills, may distort)";
        stretchRadioButton.UseVisualStyleBackColor = true;
        stretchRadioButton.CheckedChanged += SizeModeRadioButton_CheckedChanged;
        // 
        // centerRadioButton
        // 
        centerRadioButton.AutoSize = true;
        centerRadioButton.Location = new Point(16, 82);
        centerRadioButton.Name = "centerRadioButton";
        centerRadioButton.TabIndex = 5;
        centerRadioButton.TabStop = true;
        centerRadioButton.Tag = "CenterImage";
        centerRadioButton.Text = "&CenterImage (centered, cropped)";
        centerRadioButton.UseVisualStyleBackColor = true;
        centerRadioButton.CheckedChanged += SizeModeRadioButton_CheckedChanged;
        // 
        // zoomRadioButton
        // 
        zoomRadioButton.AutoSize = true;
        zoomRadioButton.Location = new Point(16, 110);
        zoomRadioButton.Name = "zoomRadioButton";
        zoomRadioButton.TabIndex = 6;
        zoomRadioButton.TabStop = true;
        zoomRadioButton.Tag = "Zoom";
        zoomRadioButton.Text = "&Zoom (fits, keeps proportions)";
        zoomRadioButton.UseVisualStyleBackColor = true;
        zoomRadioButton.CheckedChanged += SizeModeRadioButton_CheckedChanged;
        // 
        // loadImageButton
        // 
        loadImageButton.Location = new Point(424, 214);
        loadImageButton.Name = "loadImageButton";
        loadImageButton.Size = new Size(200, 32);
        loadImageButton.TabIndex = 7;
        loadImageButton.Text = "&Load an image file...";
        loadImageButton.UseVisualStyleBackColor = true;
        loadImageButton.Click += loadImageButton_Click;
        // 
        // imageInfoLabel
        // 
        imageInfoLabel.BorderStyle = BorderStyle.FixedSingle;
        imageInfoLabel.Font = new Font("Consolas", 9F);
        imageInfoLabel.Location = new Point(424, 256);
        imageInfoLabel.Name = "imageInfoLabel";
        imageInfoLabel.Size = new Size(348, 104);
        imageInfoLabel.TabIndex = 8;
        imageInfoLabel.Text = "(no image loaded)";
        // 
        // designerPictureBox
        // 
        designerPictureBox.BackColor = Color.White;
        designerPictureBox.BorderStyle = BorderStyle.FixedSingle;
        designerPictureBox.Location = new Point(12, 374);
        designerPictureBox.Name = "designerPictureBox";
        designerPictureBox.Size = new Size(120, 90);
        designerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        designerPictureBox.TabIndex = 9;
        designerPictureBox.TabStop = false;
        // 
        // stepsLabel
        // 
        stepsLabel.Location = new Point(144, 372);
        stepsLabel.Name = "stepsLabel";
        stepsLabel.Size = new Size(628, 96);
        stepsLabel.TabIndex = 10;
        stepsLabel.Text = "TRY IT IN THE DESIGNER (no code needed) with the empty designerPictureBox at the left:\r\n  1. A PictureBox was dragged from the Toolbox onto the Form (always the first step).\r\n  2. In the Properties window, find Image. Its value reads (none). Click (none), then click the ellipsis (...) button.\r\n  3. The Select Resource dialog opens. Click Import, choose a JPEG, GIF, PNG, BMP, or ICO file, and click OK.\r\n  4. Set SizeMode to Zoom so the whole picture fits.";
        // 
        // openImageDialog
        // 
        openImageDialog.Filter = "Image files|*.jpg;*.jpeg;*.gif;*.png;*.bmp;*.ico|All files|*.*";
        openImageDialog.Title = "Choose an image for the PictureBox";
        // 
        // Example06GraphicsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 476);
        Controls.Add(stepsLabel);
        Controls.Add(designerPictureBox);
        Controls.Add(imageInfoLabel);
        Controls.Add(loadImageButton);
        Controls.Add(sizeModeGroupBox);
        Controls.Add(photoPictureBox);
        Controls.Add(headerLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Example06GraphicsForm";
        Text = "Example 06 - Graphics";
        Load += Example06GraphicsForm_Load;
        sizeModeGroupBox.ResumeLayout(false);
        sizeModeGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private PictureBox photoPictureBox;
    private GroupBox sizeModeGroupBox;
    private RadioButton normalRadioButton;
    private RadioButton stretchRadioButton;
    private RadioButton centerRadioButton;
    private RadioButton zoomRadioButton;
    private Button loadImageButton;
    private Label imageInfoLabel;
    private PictureBox designerPictureBox;
    private Label stepsLabel;
    private OpenFileDialog openImageDialog;
}
