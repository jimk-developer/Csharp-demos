namespace Demo1
{
    partial class StateCapitalForm
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
            lblPrompt = new Label();
            txtState = new TextBox();
            btnFind = new Button();
            lblResult = new Label();
            txtCapital = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            //
            // lblPrompt
            //
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(12, 15);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(230, 15);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "What state do you want the capital of?";
            //
            // txtState
            //
            txtState.Location = new Point(12, 40);
            txtState.Name = "txtState";
            txtState.Size = new Size(250, 23);
            txtState.TabIndex = 1;
            //
            // btnFind
            //
            btnFind.Location = new Point(275, 39);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 25);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            //
            // lblResult
            //
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResult.Location = new Point(12, 80);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(440, 50);
            lblResult.TabIndex = 3;
            //
            // txtCapital
            //
            txtCapital.Location = new Point(12, 140);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(250, 23);
            txtCapital.TabIndex = 4;
            txtCapital.Visible = false;
            //
            // btnAdd
            //
            btnAdd.Location = new Point(275, 139);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 25);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            //
            // Form1
            //
            AcceptButton = btnFind;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 185);
            Controls.Add(btnAdd);
            Controls.Add(txtCapital);
            Controls.Add(lblResult);
            Controls.Add(btnFind);
            Controls.Add(txtState);
            Controls.Add(lblPrompt);
            Name = "Form1";
            Text = "State Capitals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtState;
        private Button btnFind;
        private Label lblResult;
        private TextBox txtCapital;
        private Button btnAdd;
    }
}
