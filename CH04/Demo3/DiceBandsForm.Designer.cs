namespace Demo3
{
    partial class DiceBandsForm
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
            btnLow = new Button();
            btnMiddle = new Button();
            btnHigh = new Button();
            lblRoll = new Label();
            lblPlayerScore = new Label();
            lblWinner = new Label();
            lblComputerScore = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnLow
            // 
            btnLow.Location = new Point(45, 46);
            btnLow.Name = "btnLow";
            btnLow.Size = new Size(75, 23);
            btnLow.TabIndex = 0;
            btnLow.Text = "Low (1-2)";
            btnLow.UseVisualStyleBackColor = true;
            btnLow.Click += btnLow_Click;
            // 
            // btnMiddle
            // 
            btnMiddle.Location = new Point(151, 46);
            btnMiddle.Name = "btnMiddle";
            btnMiddle.Size = new Size(90, 23);
            btnMiddle.TabIndex = 1;
            btnMiddle.Text = "Middle (3-4)";
            btnMiddle.UseVisualStyleBackColor = true;
            btnMiddle.Click += btnMiddle_Click;
            // 
            // btnHigh
            // 
            btnHigh.Location = new Point(268, 46);
            btnHigh.Name = "btnHigh";
            btnHigh.Size = new Size(75, 23);
            btnHigh.TabIndex = 2;
            btnHigh.Text = "High (5-6)";
            btnHigh.UseVisualStyleBackColor = true;
            btnHigh.Click += btnHigh_Click;
            // 
            // lblRoll
            // 
            lblRoll.AutoSize = true;
            lblRoll.Location = new Point(49, 110);
            lblRoll.Name = "lblRoll";
            lblRoll.Size = new Size(38, 15);
            lblRoll.TabIndex = 3;
            lblRoll.Text = "label1";
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(49, 155);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(38, 15);
            lblPlayerScore.TabIndex = 4;
            lblPlayerScore.Text = "label2";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Location = new Point(49, 194);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(38, 15);
            lblWinner.TabIndex = 5;
            lblWinner.Text = "label3";
            // 
            // lblComputerScore
            // 
            lblComputerScore.AutoSize = true;
            lblComputerScore.Location = new Point(203, 155);
            lblComputerScore.Name = "lblComputerScore";
            lblComputerScore.Size = new Size(38, 15);
            lblComputerScore.TabIndex = 6;
            lblComputerScore.Text = "label4";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(55, 241);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // DiceBandsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(lblComputerScore);
            Controls.Add(lblWinner);
            Controls.Add(lblPlayerScore);
            Controls.Add(lblRoll);
            Controls.Add(btnHigh);
            Controls.Add(btnMiddle);
            Controls.Add(btnLow);
            Name = "DiceBandsForm";
            Text = "Dice Bands";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLow;
        private Button btnMiddle;
        private Button btnHigh;
        private Label lblRoll;
        private Label lblPlayerScore;
        private Label lblWinner;
        private Label lblComputerScore;
        private Button btnReset;
    }
}
