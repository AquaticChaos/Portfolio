namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpaLabel = new System.Windows.Forms.Label();
            this.gpaTextbox = new System.Windows.Forms.TextBox();
            this.scoreTextbox = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.Label();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.decisionOutput = new System.Windows.Forms.Label();
            this.admitButton = new System.Windows.Forms.Button();
            this.acceptCountLabel = new System.Windows.Forms.Label();
            this.rejectCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(24, 18);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(169, 16);
            this.gpaLabel.TabIndex = 0;
            this.gpaLabel.Text = "Enter grade point average: ";
            // 
            // gpaTextbox
            // 
            this.gpaTextbox.Location = new System.Drawing.Point(213, 15);
            this.gpaTextbox.Name = "gpaTextbox";
            this.gpaTextbox.Size = new System.Drawing.Size(100, 22);
            this.gpaTextbox.TabIndex = 1;
            // 
            // scoreTextbox
            // 
            this.scoreTextbox.Location = new System.Drawing.Point(213, 56);
            this.scoreTextbox.Name = "scoreTextbox";
            this.scoreTextbox.Size = new System.Drawing.Size(100, 22);
            this.scoreTextbox.TabIndex = 3;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(23, 59);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(170, 16);
            this.C.TabIndex = 2;
            this.C.Text = "Enter admission test score: ";
            // 
            // decisionLabel
            // 
            this.decisionLabel.AutoSize = true;
            this.decisionLabel.Location = new System.Drawing.Point(61, 103);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(132, 16);
            this.decisionLabel.TabIndex = 4;
            this.decisionLabel.Text = "Admission Decision: ";
            // 
            // decisionOutput
            // 
            this.decisionOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionOutput.Location = new System.Drawing.Point(213, 100);
            this.decisionOutput.Name = "decisionOutput";
            this.decisionOutput.Size = new System.Drawing.Size(100, 23);
            this.decisionOutput.TabIndex = 5;
            // 
            // admitButton
            // 
            this.admitButton.Location = new System.Drawing.Point(131, 141);
            this.admitButton.Name = "admitButton";
            this.admitButton.Size = new System.Drawing.Size(75, 23);
            this.admitButton.TabIndex = 6;
            this.admitButton.Text = "Admit?";
            this.admitButton.UseVisualStyleBackColor = true;
            this.admitButton.Click += new System.EventHandler(this.admitButton_Click);
            // 
            // acceptCountLabel
            // 
            this.acceptCountLabel.AutoSize = true;
            this.acceptCountLabel.Location = new System.Drawing.Point(24, 226);
            this.acceptCountLabel.Name = "acceptCountLabel";
            this.acceptCountLabel.Size = new System.Drawing.Size(84, 16);
            this.acceptCountLabel.TabIndex = 7;
            this.acceptCountLabel.Text = "Accepted:   0";
            // 
            // rejectCountLabel
            // 
            this.rejectCountLabel.AutoSize = true;
            this.rejectCountLabel.Location = new System.Drawing.Point(210, 226);
            this.rejectCountLabel.Name = "rejectCountLabel";
            this.rejectCountLabel.Size = new System.Drawing.Size(81, 16);
            this.rejectCountLabel.TabIndex = 8;
            this.rejectCountLabel.Text = "Rejected:   0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 251);
            this.Controls.Add(this.rejectCountLabel);
            this.Controls.Add(this.acceptCountLabel);
            this.Controls.Add(this.admitButton);
            this.Controls.Add(this.decisionOutput);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.scoreTextbox);
            this.Controls.Add(this.C);
            this.Controls.Add(this.gpaTextbox);
            this.Controls.Add(this.gpaLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.TextBox gpaTextbox;
        private System.Windows.Forms.TextBox scoreTextbox;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label decisionLabel;
        private System.Windows.Forms.Label decisionOutput;
        private System.Windows.Forms.Button admitButton;
        private System.Windows.Forms.Label acceptCountLabel;
        private System.Windows.Forms.Label rejectCountLabel;
    }
}

