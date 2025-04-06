namespace Lab2
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
            this.mealLabel = new System.Windows.Forms.Label();
            this.mealTextBox = new System.Windows.Forms.TextBox();
            this.tax1Label = new System.Windows.Forms.Label();
            this.tax1Output = new System.Windows.Forms.Label();
            this.tax2Output = new System.Windows.Forms.Label();
            this.tax2Label = new System.Windows.Forms.Label();
            this.tax3Output = new System.Windows.Forms.Label();
            this.tax3Label = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(13, 28);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(131, 16);
            this.mealLabel.TabIndex = 0;
            this.mealLabel.Text = "Enter the meal price: ";
            // 
            // mealTextBox
            // 
            this.mealTextBox.Location = new System.Drawing.Point(160, 25);
            this.mealTextBox.Name = "mealTextBox";
            this.mealTextBox.Size = new System.Drawing.Size(100, 22);
            this.mealTextBox.TabIndex = 1;
            // 
            // tax1Label
            // 
            this.tax1Label.AutoSize = true;
            this.tax1Label.Location = new System.Drawing.Point(105, 72);
            this.tax1Label.Name = "tax1Label";
            this.tax1Label.Size = new System.Drawing.Size(39, 16);
            this.tax1Label.TabIndex = 2;
            this.tax1Label.Text = "15%: ";
            // 
            // tax1Output
            // 
            this.tax1Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tax1Output.Location = new System.Drawing.Point(160, 69);
            this.tax1Output.Name = "tax1Output";
            this.tax1Output.Size = new System.Drawing.Size(100, 23);
            this.tax1Output.TabIndex = 3;
            // 
            // tax2Output
            // 
            this.tax2Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tax2Output.Location = new System.Drawing.Point(160, 114);
            this.tax2Output.Name = "tax2Output";
            this.tax2Output.Size = new System.Drawing.Size(100, 23);
            this.tax2Output.TabIndex = 5;
            // 
            // tax2Label
            // 
            this.tax2Label.AutoSize = true;
            this.tax2Label.Location = new System.Drawing.Point(105, 117);
            this.tax2Label.Name = "tax2Label";
            this.tax2Label.Size = new System.Drawing.Size(39, 16);
            this.tax2Label.TabIndex = 4;
            this.tax2Label.Text = "18%: ";
            // 
            // tax3Output
            // 
            this.tax3Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tax3Output.Location = new System.Drawing.Point(160, 159);
            this.tax3Output.Name = "tax3Output";
            this.tax3Output.Size = new System.Drawing.Size(100, 23);
            this.tax3Output.TabIndex = 7;
            // 
            // tax3Label
            // 
            this.tax3Label.AutoSize = true;
            this.tax3Label.Location = new System.Drawing.Point(105, 162);
            this.tax3Label.Name = "tax3Label";
            this.tax3Label.Size = new System.Drawing.Size(39, 16);
            this.tax3Label.TabIndex = 6;
            this.tax3Label.Text = "20%: ";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(86, 201);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(104, 23);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate Tip";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 232);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.tax3Output);
            this.Controls.Add(this.tax3Label);
            this.Controls.Add(this.tax2Output);
            this.Controls.Add(this.tax2Label);
            this.Controls.Add(this.tax1Output);
            this.Controls.Add(this.tax1Label);
            this.Controls.Add(this.mealTextBox);
            this.Controls.Add(this.mealLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.TextBox mealTextBox;
        private System.Windows.Forms.Label tax1Label;
        private System.Windows.Forms.Label tax1Output;
        private System.Windows.Forms.Label tax2Output;
        private System.Windows.Forms.Label tax2Label;
        private System.Windows.Forms.Label tax3Output;
        private System.Windows.Forms.Label tax3Label;
        private System.Windows.Forms.Button calcButton;
    }
}

