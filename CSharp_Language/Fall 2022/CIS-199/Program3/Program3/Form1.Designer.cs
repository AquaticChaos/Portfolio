namespace Program3
{
    partial class program3Form
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
            this.loanTypeCombo = new System.Windows.Forms.ComboBox();
            this.loanTypeLabel = new System.Windows.Forms.Label();
            this.creditScoreLabel = new System.Windows.Forms.Label();
            this.creditScoreTextbox = new System.Windows.Forms.TextBox();
            this.loanAmountTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.loanInterestLabel = new System.Windows.Forms.Label();
            this.loanInterestOutput = new System.Windows.Forms.Label();
            this.creditRatingOutput = new System.Windows.Forms.Label();
            this.creditRatingLabel = new System.Windows.Forms.Label();
            this.downPaymentOutput = new System.Windows.Forms.Label();
            this.downPaymentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loanTypeCombo
            // 
            this.loanTypeCombo.FormattingEnabled = true;
            this.loanTypeCombo.Items.AddRange(new object[] {
            "Home",
            "Auto",
            "Unsecured"});
            this.loanTypeCombo.Location = new System.Drawing.Point(153, 25);
            this.loanTypeCombo.Name = "loanTypeCombo";
            this.loanTypeCombo.Size = new System.Drawing.Size(121, 24);
            this.loanTypeCombo.TabIndex = 0;
            // 
            // loanTypeLabel
            // 
            this.loanTypeLabel.AutoSize = true;
            this.loanTypeLabel.Location = new System.Drawing.Point(69, 28);
            this.loanTypeLabel.Name = "loanTypeLabel";
            this.loanTypeLabel.Size = new System.Drawing.Size(75, 16);
            this.loanTypeLabel.TabIndex = 1;
            this.loanTypeLabel.Text = "Loan Type:";
            // 
            // creditScoreLabel
            // 
            this.creditScoreLabel.AutoSize = true;
            this.creditScoreLabel.Location = new System.Drawing.Point(60, 78);
            this.creditScoreLabel.Name = "creditScoreLabel";
            this.creditScoreLabel.Size = new System.Drawing.Size(84, 16);
            this.creditScoreLabel.TabIndex = 3;
            this.creditScoreLabel.Text = "Credit Score:";
            // 
            // creditScoreTextbox
            // 
            this.creditScoreTextbox.Location = new System.Drawing.Point(153, 76);
            this.creditScoreTextbox.Name = "creditScoreTextbox";
            this.creditScoreTextbox.Size = new System.Drawing.Size(121, 22);
            this.creditScoreTextbox.TabIndex = 4;
            // 
            // loanAmountTextbox
            // 
            this.loanAmountTextbox.Location = new System.Drawing.Point(153, 125);
            this.loanAmountTextbox.Name = "loanAmountTextbox";
            this.loanAmountTextbox.Size = new System.Drawing.Size(121, 22);
            this.loanAmountTextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loan Amount: ";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(100, 172);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(118, 56);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate Interest";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // loanInterestLabel
            // 
            this.loanInterestLabel.AutoSize = true;
            this.loanInterestLabel.Location = new System.Drawing.Point(53, 256);
            this.loanInterestLabel.Name = "loanInterestLabel";
            this.loanInterestLabel.Size = new System.Drawing.Size(86, 16);
            this.loanInterestLabel.TabIndex = 8;
            this.loanInterestLabel.Text = "Loan Interest:";
            // 
            // loanInterestOutput
            // 
            this.loanInterestOutput.BackColor = System.Drawing.SystemColors.Control;
            this.loanInterestOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loanInterestOutput.Location = new System.Drawing.Point(153, 253);
            this.loanInterestOutput.Name = "loanInterestOutput";
            this.loanInterestOutput.Size = new System.Drawing.Size(121, 23);
            this.loanInterestOutput.TabIndex = 9;
            // 
            // creditRatingOutput
            // 
            this.creditRatingOutput.BackColor = System.Drawing.SystemColors.Control;
            this.creditRatingOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditRatingOutput.Location = new System.Drawing.Point(153, 289);
            this.creditRatingOutput.Name = "creditRatingOutput";
            this.creditRatingOutput.Size = new System.Drawing.Size(121, 23);
            this.creditRatingOutput.TabIndex = 11;
            // 
            // creditRatingLabel
            // 
            this.creditRatingLabel.AutoSize = true;
            this.creditRatingLabel.Location = new System.Drawing.Point(52, 292);
            this.creditRatingLabel.Name = "creditRatingLabel";
            this.creditRatingLabel.Size = new System.Drawing.Size(87, 16);
            this.creditRatingLabel.TabIndex = 10;
            this.creditRatingLabel.Text = "Credit Rating:";
            // 
            // downPaymentOutput
            // 
            this.downPaymentOutput.BackColor = System.Drawing.SystemColors.Control;
            this.downPaymentOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downPaymentOutput.Location = new System.Drawing.Point(153, 325);
            this.downPaymentOutput.Name = "downPaymentOutput";
            this.downPaymentOutput.Size = new System.Drawing.Size(121, 23);
            this.downPaymentOutput.TabIndex = 13;
            // 
            // downPaymentLabel
            // 
            this.downPaymentLabel.AutoSize = true;
            this.downPaymentLabel.Location = new System.Drawing.Point(39, 328);
            this.downPaymentLabel.Name = "downPaymentLabel";
            this.downPaymentLabel.Size = new System.Drawing.Size(100, 16);
            this.downPaymentLabel.TabIndex = 12;
            this.downPaymentLabel.Text = "Down Payment:";
            // 
            // program3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 374);
            this.Controls.Add(this.downPaymentOutput);
            this.Controls.Add(this.downPaymentLabel);
            this.Controls.Add(this.creditRatingOutput);
            this.Controls.Add(this.creditRatingLabel);
            this.Controls.Add(this.loanInterestOutput);
            this.Controls.Add(this.loanInterestLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.loanAmountTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditScoreTextbox);
            this.Controls.Add(this.creditScoreLabel);
            this.Controls.Add(this.loanTypeLabel);
            this.Controls.Add(this.loanTypeCombo);
            this.Name = "program3Form";
            this.Text = "Loan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox loanTypeCombo;
        private System.Windows.Forms.Label loanTypeLabel;
        private System.Windows.Forms.Label creditScoreLabel;
        private System.Windows.Forms.TextBox creditScoreTextbox;
        private System.Windows.Forms.TextBox loanAmountTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label loanInterestLabel;
        private System.Windows.Forms.Label loanInterestOutput;
        private System.Windows.Forms.Label creditRatingOutput;
        private System.Windows.Forms.Label creditRatingLabel;
        private System.Windows.Forms.Label downPaymentOutput;
        private System.Windows.Forms.Label downPaymentLabel;
    }
}

