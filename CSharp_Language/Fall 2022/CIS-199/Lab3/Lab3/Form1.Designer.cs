namespace Lab3
{
    partial class Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.radiLabel = new System.Windows.Forms.Label();
            this.radiTextbox = new System.Windows.Forms.TextBox();
            this.diamLabel = new System.Windows.Forms.Label();
            this.diamOutput = new System.Windows.Forms.Label();
            this.areaOutput = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.voluOutput = new System.Windows.Forms.Label();
            this.voluLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.sphereImage1 = new System.Windows.Forms.PictureBox();
            this.sphereImage2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sphereImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // radiLabel
            // 
            this.radiLabel.AutoSize = true;
            this.radiLabel.Location = new System.Drawing.Point(164, 79);
            this.radiLabel.Name = "radiLabel";
            this.radiLabel.Size = new System.Drawing.Size(117, 16);
            this.radiLabel.TabIndex = 0;
            this.radiLabel.Text = "Radius of Sphere: ";
            // 
            // radiTextbox
            // 
            this.radiTextbox.Location = new System.Drawing.Point(281, 76);
            this.radiTextbox.Name = "radiTextbox";
            this.radiTextbox.Size = new System.Drawing.Size(100, 22);
            this.radiTextbox.TabIndex = 1;
            // 
            // diamLabel
            // 
            this.diamLabel.AutoSize = true;
            this.diamLabel.Location = new System.Drawing.Point(11, 194);
            this.diamLabel.Name = "diamLabel";
            this.diamLabel.Size = new System.Drawing.Size(68, 16);
            this.diamLabel.TabIndex = 2;
            this.diamLabel.Text = "Diameter: ";
            // 
            // diamOutput
            // 
            this.diamOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diamOutput.Location = new System.Drawing.Point(102, 191);
            this.diamOutput.Name = "diamOutput";
            this.diamOutput.Size = new System.Drawing.Size(100, 23);
            this.diamOutput.TabIndex = 3;
            // 
            // areaOutput
            // 
            this.areaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaOutput.Location = new System.Drawing.Point(102, 255);
            this.areaOutput.Name = "areaOutput";
            this.areaOutput.Size = new System.Drawing.Size(100, 23);
            this.areaOutput.TabIndex = 5;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(11, 258);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(91, 16);
            this.areaLabel.TabIndex = 4;
            this.areaLabel.Text = "Surface Area: ";
            // 
            // voluOutput
            // 
            this.voluOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voluOutput.Location = new System.Drawing.Point(102, 318);
            this.voluOutput.Name = "voluOutput";
            this.voluOutput.Size = new System.Drawing.Size(100, 23);
            this.voluOutput.TabIndex = 7;
            // 
            // voluLabel
            // 
            this.voluLabel.AutoSize = true;
            this.voluLabel.Location = new System.Drawing.Point(11, 321);
            this.voluLabel.Name = "voluLabel";
            this.voluLabel.Size = new System.Drawing.Size(59, 16);
            this.voluLabel.TabIndex = 6;
            this.voluLabel.Text = "Volume: ";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(295, 104);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // sphereImage1
            // 
            this.sphereImage1.Image = ((System.Drawing.Image)(resources.GetObject("sphereImage1.Image")));
            this.sphereImage1.Location = new System.Drawing.Point(8, 12);
            this.sphereImage1.Name = "sphereImage1";
            this.sphereImage1.Size = new System.Drawing.Size(150, 150);
            this.sphereImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sphereImage1.TabIndex = 9;
            this.sphereImage1.TabStop = false;
            // 
            // sphereImage2
            // 
            this.sphereImage2.Image = ((System.Drawing.Image)(resources.GetObject("sphereImage2.Image")));
            this.sphereImage2.Location = new System.Drawing.Point(220, 191);
            this.sphereImage2.Name = "sphereImage2";
            this.sphereImage2.Size = new System.Drawing.Size(150, 150);
            this.sphereImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sphereImage2.TabIndex = 10;
            this.sphereImage2.TabStop = false;
            // 
            // Lab3
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.sphereImage2);
            this.Controls.Add(this.sphereImage1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.voluOutput);
            this.Controls.Add(this.voluLabel);
            this.Controls.Add(this.areaOutput);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.diamOutput);
            this.Controls.Add(this.diamLabel);
            this.Controls.Add(this.radiTextbox);
            this.Controls.Add(this.radiLabel);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.sphereImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiLabel;
        private System.Windows.Forms.TextBox radiTextbox;
        private System.Windows.Forms.Label diamLabel;
        private System.Windows.Forms.Label diamOutput;
        private System.Windows.Forms.Label areaOutput;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label voluOutput;
        private System.Windows.Forms.Label voluLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.PictureBox sphereImage1;
        private System.Windows.Forms.PictureBox sphereImage2;
    }
}

