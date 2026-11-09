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
        lblChoose = new Label();
        cboPets = new ComboBox();
        lblName = new Label();
        lblSpecies = new Label();
        lblAge = new Label();
        lblDescription = new Label();
        SuspendLayout();
        // 
        // lblChoose
        // 
        lblChoose.AutoSize = true;
        lblChoose.Location = new Point(20, 20);
        lblChoose.Name = "lblChoose";
        lblChoose.TabIndex = 0;
        lblChoose.Text = "Choose a pet:";
        // 
        // cboPets
        // 
        cboPets.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPets.Location = new Point(20, 42);
        cboPets.Name = "cboPets";
        cboPets.Size = new Size(200, 23);
        cboPets.TabIndex = 1;
        cboPets.SelectedIndexChanged += cboPets_SelectedIndexChanged;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblName.Location = new Point(20, 85);
        lblName.Name = "lblName";
        lblName.TabIndex = 2;
        // 
        // lblSpecies
        // 
        lblSpecies.AutoSize = true;
        lblSpecies.Location = new Point(20, 120);
        lblSpecies.Name = "lblSpecies";
        lblSpecies.TabIndex = 3;
        // 
        // lblAge
        // 
        lblAge.AutoSize = true;
        lblAge.Location = new Point(20, 145);
        lblAge.Name = "lblAge";
        lblAge.TabIndex = 4;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(20, 170);
        lblDescription.Name = "lblDescription";
        lblDescription.TabIndex = 5;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 220);
        Controls.Add(lblChoose);
        Controls.Add(cboPets);
        Controls.Add(lblName);
        Controls.Add(lblSpecies);
        Controls.Add(lblAge);
        Controls.Add(lblDescription);
        Name = "MainForm";
        Text = "Pet Lookup";
        Load += MainForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblChoose;
    private ComboBox cboPets;
    private Label lblName;
    private Label lblSpecies;
    private Label lblAge;
    private Label lblDescription;
}
