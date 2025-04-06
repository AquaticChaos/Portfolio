namespace Program1
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.paintTextbox = new System.Windows.Forms.TextBox();
            this.paintLabel = new System.Windows.Forms.Label();
            this.colorTextbox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.illumTextbox = new System.Windows.Forms.TextBox();
            this.illumLabel = new System.Windows.Forms.Label();
            this.coatnumTextbox = new System.Windows.Forms.TextBox();
            this.coatnumLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.areaOutput = new System.Windows.Forms.Label();
            this.paintingOutput = new System.Windows.Forms.Label();
            this.paintingLabel = new System.Windows.Forms.Label();
            this.coatsOutput = new System.Windows.Forms.Label();
            this.coatsLabel = new System.Windows.Forms.Label();
            this.laborOutput = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(226, 21);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(199, 16);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to the Mural Calculator";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(49, 77);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(135, 16);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width of the Mural (ft): ";
            // 
            // widthTextbox
            // 
            this.widthTextbox.Location = new System.Drawing.Point(207, 74);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(100, 22);
            this.widthTextbox.TabIndex = 2;
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(207, 107);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(100, 22);
            this.heightTextbox.TabIndex = 4;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(46, 110);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(140, 16);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Height of the Mural (ft): ";
            // 
            // paintTextbox
            // 
            this.paintTextbox.Location = new System.Drawing.Point(207, 181);
            this.paintTextbox.Name = "paintTextbox";
            this.paintTextbox.Size = new System.Drawing.Size(100, 22);
            this.paintTextbox.TabIndex = 8;
            // 
            // paintLabel
            // 
            this.paintLabel.AutoSize = true;
            this.paintLabel.Location = new System.Drawing.Point(43, 184);
            this.paintLabel.Name = "paintLabel";
            this.paintLabel.Size = new System.Drawing.Size(147, 16);
            this.paintLabel.TabIndex = 7;
            this.paintLabel.Text = "Price Per sq. ft Of Paint: ";
            // 
            // colorTextbox
            // 
            this.colorTextbox.Location = new System.Drawing.Point(207, 144);
            this.colorTextbox.Name = "colorTextbox";
            this.colorTextbox.Size = new System.Drawing.Size(100, 22);
            this.colorTextbox.TabIndex = 6;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(28, 147);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(176, 16);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Number of Colors For Mural: ";
            // 
            // illumTextbox
            // 
            this.illumTextbox.Location = new System.Drawing.Point(207, 247);
            this.illumTextbox.Name = "illumTextbox";
            this.illumTextbox.Size = new System.Drawing.Size(100, 22);
            this.illumTextbox.TabIndex = 12;
            // 
            // illumLabel
            // 
            this.illumLabel.AutoSize = true;
            this.illumLabel.Location = new System.Drawing.Point(62, 242);
            this.illumLabel.Name = "illumLabel";
            this.illumLabel.Size = new System.Drawing.Size(109, 32);
            this.illumLabel.TabIndex = 11;
            this.illumLabel.Text = "Illuminate Mural? \r\n(1 = Yes, 0 = No): ";
            // 
            // coatnumTextbox
            // 
            this.coatnumTextbox.Location = new System.Drawing.Point(207, 217);
            this.coatnumTextbox.Name = "coatnumTextbox";
            this.coatnumTextbox.Size = new System.Drawing.Size(100, 22);
            this.coatnumTextbox.TabIndex = 10;
            // 
            // coatnumLabel
            // 
            this.coatnumLabel.AutoSize = true;
            this.coatnumLabel.Location = new System.Drawing.Point(38, 220);
            this.coatnumLabel.Name = "coatnumLabel";
            this.coatnumLabel.Size = new System.Drawing.Size(156, 16);
            this.coatnumLabel.TabIndex = 9;
            this.coatnumLabel.Text = "Number of Coats (1 or 2): ";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(150, 301);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(83, 23);
            this.calcButton.TabIndex = 13;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(398, 77);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(119, 16);
            this.areaLabel.TabIndex = 14;
            this.areaLabel.Text = "Total Area in sq. ft: ";
            // 
            // areaOutput
            // 
            this.areaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaOutput.Location = new System.Drawing.Point(523, 74);
            this.areaOutput.Name = "areaOutput";
            this.areaOutput.Size = new System.Drawing.Size(100, 23);
            this.areaOutput.TabIndex = 15;
            // 
            // paintingOutput
            // 
            this.paintingOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintingOutput.Location = new System.Drawing.Point(523, 144);
            this.paintingOutput.Name = "paintingOutput";
            this.paintingOutput.Size = new System.Drawing.Size(100, 23);
            this.paintingOutput.TabIndex = 17;
            // 
            // paintingLabel
            // 
            this.paintingLabel.AutoSize = true;
            this.paintingLabel.Location = new System.Drawing.Point(412, 147);
            this.paintingLabel.Name = "paintingLabel";
            this.paintingLabel.Size = new System.Drawing.Size(91, 16);
            this.paintingLabel.TabIndex = 16;
            this.paintingLabel.Text = "Painting Cost: ";
            // 
            // coatsOutput
            // 
            this.coatsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coatsOutput.Location = new System.Drawing.Point(523, 181);
            this.coatsOutput.Name = "coatsOutput";
            this.coatsOutput.Size = new System.Drawing.Size(100, 23);
            this.coatsOutput.TabIndex = 19;
            // 
            // coatsLabel
            // 
            this.coatsLabel.AutoSize = true;
            this.coatsLabel.Location = new System.Drawing.Point(420, 184);
            this.coatsLabel.Name = "coatsLabel";
            this.coatsLabel.Size = new System.Drawing.Size(75, 16);
            this.coatsLabel.TabIndex = 18;
            this.coatsLabel.Text = "Coats Cost:";
            // 
            // laborOutput
            // 
            this.laborOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborOutput.Location = new System.Drawing.Point(523, 217);
            this.laborOutput.Name = "laborOutput";
            this.laborOutput.Size = new System.Drawing.Size(100, 23);
            this.laborOutput.TabIndex = 21;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(418, 220);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(78, 16);
            this.laborLabel.TabIndex = 20;
            this.laborLabel.Text = "Labor Cost: ";
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Location = new System.Drawing.Point(523, 301);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 23;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(422, 304);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(71, 16);
            this.totalLabel.TabIndex = 22;
            this.totalLabel.Text = "Total Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 344);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.laborOutput);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.coatsOutput);
            this.Controls.Add(this.coatsLabel);
            this.Controls.Add(this.paintingOutput);
            this.Controls.Add(this.paintingLabel);
            this.Controls.Add(this.areaOutput);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.illumTextbox);
            this.Controls.Add(this.illumLabel);
            this.Controls.Add(this.coatnumTextbox);
            this.Controls.Add(this.coatnumLabel);
            this.Controls.Add(this.paintTextbox);
            this.Controls.Add(this.paintLabel);
            this.Controls.Add(this.colorTextbox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthTextbox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox paintTextbox;
        private System.Windows.Forms.Label paintLabel;
        private System.Windows.Forms.TextBox colorTextbox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox illumTextbox;
        private System.Windows.Forms.Label illumLabel;
        private System.Windows.Forms.TextBox coatnumTextbox;
        private System.Windows.Forms.Label coatnumLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label areaOutput;
        private System.Windows.Forms.Label paintingOutput;
        private System.Windows.Forms.Label paintingLabel;
        private System.Windows.Forms.Label coatsOutput;
        private System.Windows.Forms.Label coatsLabel;
        private System.Windows.Forms.Label laborOutput;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label totalLabel;
    }
}

