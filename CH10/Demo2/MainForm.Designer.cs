namespace Demo2;

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
        lblSize = new Label();
        txtSize = new TextBox();
        grpCrust = new GroupBox();
        radRegular = new RadioButton();
        radStuffed = new RadioButton();
        radDeepDish = new RadioButton();
        grpCheese = new GroupBox();
        radMozzarella = new RadioButton();
        radCheddar = new RadioButton();
        radPepperJack = new RadioButton();
        grpSauce = new GroupBox();
        radMarinara = new RadioButton();
        radAlfredo = new RadioButton();
        radBbq = new RadioButton();
        btnCalculate = new Button();
        lblCost = new Label();
        lblDescription = new Label();
        grpCrust.SuspendLayout();
        grpCheese.SuspendLayout();
        grpSauce.SuspendLayout();
        SuspendLayout();
        //
        // lblSize
        //
        lblSize.AutoSize = true;
        lblSize.Location = new Point(20, 23);
        lblSize.Name = "lblSize";
        lblSize.Text = "Size (inches)";
        //
        // txtSize
        //
        txtSize.Location = new Point(110, 20);
        txtSize.Name = "txtSize";
        txtSize.Size = new Size(80, 23);
        txtSize.TabIndex = 0;
        txtSize.Text = "14";
        //
        // grpCrust
        //
        grpCrust.Controls.Add(radRegular);
        grpCrust.Controls.Add(radStuffed);
        grpCrust.Controls.Add(radDeepDish);
        grpCrust.Location = new Point(20, 60);
        grpCrust.Name = "grpCrust";
        grpCrust.Size = new Size(400, 60);
        grpCrust.TabIndex = 1;
        grpCrust.TabStop = false;
        grpCrust.Text = "Crust";
        //
        // radRegular
        //
        radRegular.AutoSize = true;
        radRegular.Checked = true;
        radRegular.Location = new Point(15, 25);
        radRegular.Name = "radRegular";
        radRegular.TabIndex = 0;
        radRegular.TabStop = true;
        radRegular.Text = "Regular";
        radRegular.UseVisualStyleBackColor = true;
        radRegular.CheckedChanged += Crust_CheckedChanged;
        //
        // radStuffed
        //
        radStuffed.AutoSize = true;
        radStuffed.Location = new Point(100, 25);
        radStuffed.Name = "radStuffed";
        radStuffed.TabIndex = 1;
        radStuffed.Text = "Stuffed Crust (+$2.00)";
        radStuffed.UseVisualStyleBackColor = true;
        radStuffed.CheckedChanged += Crust_CheckedChanged;
        //
        // radDeepDish
        //
        radDeepDish.AutoSize = true;
        radDeepDish.Location = new Point(255, 25);
        radDeepDish.Name = "radDeepDish";
        radDeepDish.TabIndex = 2;
        radDeepDish.Text = "Deep Dish (+$3.50)";
        radDeepDish.UseVisualStyleBackColor = true;
        radDeepDish.CheckedChanged += Crust_CheckedChanged;
        //
        // grpCheese
        //
        grpCheese.Controls.Add(radMozzarella);
        grpCheese.Controls.Add(radCheddar);
        grpCheese.Controls.Add(radPepperJack);
        grpCheese.Location = new Point(20, 130);
        grpCheese.Name = "grpCheese";
        grpCheese.Size = new Size(180, 110);
        grpCheese.TabIndex = 2;
        grpCheese.TabStop = false;
        grpCheese.Text = "Cheese";
        //
        // radMozzarella
        //
        radMozzarella.AutoSize = true;
        radMozzarella.Checked = true;
        radMozzarella.Location = new Point(15, 25);
        radMozzarella.Name = "radMozzarella";
        radMozzarella.TabIndex = 0;
        radMozzarella.TabStop = true;
        radMozzarella.Text = "Mozzarella";
        radMozzarella.UseVisualStyleBackColor = true;
        //
        // radCheddar
        //
        radCheddar.AutoSize = true;
        radCheddar.Location = new Point(15, 50);
        radCheddar.Name = "radCheddar";
        radCheddar.TabIndex = 1;
        radCheddar.Text = "Cheddar";
        radCheddar.UseVisualStyleBackColor = true;
        //
        // radPepperJack
        //
        radPepperJack.AutoSize = true;
        radPepperJack.Location = new Point(15, 75);
        radPepperJack.Name = "radPepperJack";
        radPepperJack.TabIndex = 2;
        radPepperJack.Text = "Pepper Jack";
        radPepperJack.UseVisualStyleBackColor = true;
        //
        // grpSauce
        //
        grpSauce.Controls.Add(radMarinara);
        grpSauce.Controls.Add(radAlfredo);
        grpSauce.Controls.Add(radBbq);
        grpSauce.Location = new Point(220, 130);
        grpSauce.Name = "grpSauce";
        grpSauce.Size = new Size(200, 110);
        grpSauce.TabIndex = 3;
        grpSauce.TabStop = false;
        grpSauce.Text = "Sauce";
        //
        // radMarinara
        //
        radMarinara.AutoSize = true;
        radMarinara.Checked = true;
        radMarinara.Location = new Point(15, 25);
        radMarinara.Name = "radMarinara";
        radMarinara.TabIndex = 0;
        radMarinara.TabStop = true;
        radMarinara.Text = "Marinara";
        radMarinara.UseVisualStyleBackColor = true;
        //
        // radAlfredo
        //
        radAlfredo.AutoSize = true;
        radAlfredo.Location = new Point(15, 50);
        radAlfredo.Name = "radAlfredo";
        radAlfredo.TabIndex = 1;
        radAlfredo.Text = "Alfredo";
        radAlfredo.UseVisualStyleBackColor = true;
        //
        // radBbq
        //
        radBbq.AutoSize = true;
        radBbq.Location = new Point(15, 75);
        radBbq.Name = "radBbq";
        radBbq.TabIndex = 2;
        radBbq.Text = "BBQ";
        radBbq.UseVisualStyleBackColor = true;
        //
        // btnCalculate
        //
        btnCalculate.Location = new Point(20, 260);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Size = new Size(100, 30);
        btnCalculate.TabIndex = 4;
        btnCalculate.Text = "Calculate";
        btnCalculate.UseVisualStyleBackColor = true;
        btnCalculate.Click += btnCalculate_Click;
        //
        // lblCost
        //
        lblCost.AutoSize = true;
        lblCost.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblCost.Location = new Point(220, 258);
        lblCost.Name = "lblCost";
        lblCost.Text = "Cost: $0.00";
        //
        // lblDescription
        //
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(20, 305);
        lblDescription.Name = "lblDescription";
        lblDescription.Text = "";
        //
        // MainForm
        //
        AcceptButton = btnCalculate;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 340);
        Controls.Add(lblSize);
        Controls.Add(txtSize);
        Controls.Add(grpCrust);
        Controls.Add(grpCheese);
        Controls.Add(grpSauce);
        Controls.Add(btnCalculate);
        Controls.Add(lblCost);
        Controls.Add(lblDescription);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pizza Shop";
        grpCrust.ResumeLayout(false);
        grpCrust.PerformLayout();
        grpCheese.ResumeLayout(false);
        grpCheese.PerformLayout();
        grpSauce.ResumeLayout(false);
        grpSauce.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblSize;
    private TextBox txtSize;
    private GroupBox grpCrust;
    private RadioButton radRegular;
    private RadioButton radStuffed;
    private RadioButton radDeepDish;
    private GroupBox grpCheese;
    private RadioButton radMozzarella;
    private RadioButton radCheddar;
    private RadioButton radPepperJack;
    private GroupBox grpSauce;
    private RadioButton radMarinara;
    private RadioButton radAlfredo;
    private RadioButton radBbq;
    private Button btnCalculate;
    private Label lblCost;
    private Label lblDescription;
}
