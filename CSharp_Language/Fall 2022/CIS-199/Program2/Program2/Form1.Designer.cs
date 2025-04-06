namespace Program2
{
    partial class Prog2
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
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.manuTextbox = new System.Windows.Forms.TextBox();
            this.manuLabel = new System.Windows.Forms.Label();
            this.healthInsurLabel = new System.Windows.Forms.Label();
            this.healthInsurCombo = new System.Windows.Forms.ComboBox();
            this.carInsurCombo = new System.Windows.Forms.ComboBox();
            this.carInsurLabel = new System.Windows.Forms.Label();
            this.smokeGroup = new System.Windows.Forms.GroupBox();
            this.smokeYesRadio = new System.Windows.Forms.RadioButton();
            this.smokeNoRadio = new System.Windows.Forms.RadioButton();
            this.accidentGroup = new System.Windows.Forms.GroupBox();
            this.accidentNoRadio = new System.Windows.Forms.RadioButton();
            this.accidentYesRadio = new System.Windows.Forms.RadioButton();
            this.calcButton = new System.Windows.Forms.Button();
            this.healthCostLabel = new System.Windows.Forms.Label();
            this.healthCostOutput = new System.Windows.Forms.Label();
            this.carCostOutput = new System.Windows.Forms.Label();
            this.carCostLabel = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.smokeGroup.SuspendLayout();
            this.accidentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(227, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(221, 16);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Cardinal Insurance Policy Calculator";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(88, 51);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(100, 16);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Enter your age: ";
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(194, 48);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(100, 22);
            this.ageTextbox.TabIndex = 2;
            // 
            // manuTextbox
            // 
            this.manuTextbox.Location = new System.Drawing.Point(541, 48);
            this.manuTextbox.Name = "manuTextbox";
            this.manuTextbox.Size = new System.Drawing.Size(100, 22);
            this.manuTextbox.TabIndex = 4;
            // 
            // manuLabel
            // 
            this.manuLabel.AutoSize = true;
            this.manuLabel.Location = new System.Drawing.Point(379, 51);
            this.manuLabel.Name = "manuLabel";
            this.manuLabel.Size = new System.Drawing.Size(156, 16);
            this.manuLabel.TabIndex = 3;
            this.manuLabel.Text = "Manufacture Year of Car: ";
            // 
            // healthInsurLabel
            // 
            this.healthInsurLabel.AutoSize = true;
            this.healthInsurLabel.Location = new System.Drawing.Point(12, 106);
            this.healthInsurLabel.Name = "healthInsurLabel";
            this.healthInsurLabel.Size = new System.Drawing.Size(176, 16);
            this.healthInsurLabel.TabIndex = 5;
            this.healthInsurLabel.Text = "Health Insurance Coverage: ";
            // 
            // healthInsurCombo
            // 
            this.healthInsurCombo.FormattingEnabled = true;
            this.healthInsurCombo.Items.AddRange(new object[] {
            "None",
            "EPO",
            "PPO",
            "HDP"});
            this.healthInsurCombo.Location = new System.Drawing.Point(194, 102);
            this.healthInsurCombo.Name = "healthInsurCombo";
            this.healthInsurCombo.Size = new System.Drawing.Size(121, 24);
            this.healthInsurCombo.TabIndex = 6;
            // 
            // carInsurCombo
            // 
            this.carInsurCombo.FormattingEnabled = true;
            this.carInsurCombo.Items.AddRange(new object[] {
            "None",
            "Full",
            "Liability"});
            this.carInsurCombo.Location = new System.Drawing.Point(541, 102);
            this.carInsurCombo.Name = "carInsurCombo";
            this.carInsurCombo.Size = new System.Drawing.Size(121, 24);
            this.carInsurCombo.TabIndex = 8;
            // 
            // carInsurLabel
            // 
            this.carInsurLabel.AutoSize = true;
            this.carInsurLabel.Location = new System.Drawing.Point(377, 106);
            this.carInsurLabel.Name = "carInsurLabel";
            this.carInsurLabel.Size = new System.Drawing.Size(158, 16);
            this.carInsurLabel.TabIndex = 7;
            this.carInsurLabel.Text = "Car Insurance Coverage: ";
            // 
            // smokeGroup
            // 
            this.smokeGroup.Controls.Add(this.smokeNoRadio);
            this.smokeGroup.Controls.Add(this.smokeYesRadio);
            this.smokeGroup.Location = new System.Drawing.Point(145, 153);
            this.smokeGroup.Name = "smokeGroup";
            this.smokeGroup.Size = new System.Drawing.Size(152, 60);
            this.smokeGroup.TabIndex = 9;
            this.smokeGroup.TabStop = false;
            this.smokeGroup.Text = "Do you smoke?";
            // 
            // smokeYesRadio
            // 
            this.smokeYesRadio.AutoSize = true;
            this.smokeYesRadio.Location = new System.Drawing.Point(21, 30);
            this.smokeYesRadio.Name = "smokeYesRadio";
            this.smokeYesRadio.Size = new System.Drawing.Size(52, 20);
            this.smokeYesRadio.TabIndex = 0;
            this.smokeYesRadio.Text = "Yes";
            this.smokeYesRadio.UseVisualStyleBackColor = true;
            // 
            // smokeNoRadio
            // 
            this.smokeNoRadio.AutoSize = true;
            this.smokeNoRadio.Checked = true;
            this.smokeNoRadio.Location = new System.Drawing.Point(91, 30);
            this.smokeNoRadio.Name = "smokeNoRadio";
            this.smokeNoRadio.Size = new System.Drawing.Size(46, 20);
            this.smokeNoRadio.TabIndex = 1;
            this.smokeNoRadio.TabStop = true;
            this.smokeNoRadio.Text = "No";
            this.smokeNoRadio.UseVisualStyleBackColor = true;
            // 
            // accidentGroup
            // 
            this.accidentGroup.Controls.Add(this.accidentNoRadio);
            this.accidentGroup.Controls.Add(this.accidentYesRadio);
            this.accidentGroup.Location = new System.Drawing.Point(332, 153);
            this.accidentGroup.Name = "accidentGroup";
            this.accidentGroup.Size = new System.Drawing.Size(198, 60);
            this.accidentGroup.TabIndex = 10;
            this.accidentGroup.TabStop = false;
            this.accidentGroup.Text = "Car accident in the past year?";
            // 
            // accidentNoRadio
            // 
            this.accidentNoRadio.AutoSize = true;
            this.accidentNoRadio.Checked = true;
            this.accidentNoRadio.Location = new System.Drawing.Point(117, 30);
            this.accidentNoRadio.Name = "accidentNoRadio";
            this.accidentNoRadio.Size = new System.Drawing.Size(46, 20);
            this.accidentNoRadio.TabIndex = 1;
            this.accidentNoRadio.TabStop = true;
            this.accidentNoRadio.Text = "No";
            this.accidentNoRadio.UseVisualStyleBackColor = true;
            // 
            // accidentYesRadio
            // 
            this.accidentYesRadio.AutoSize = true;
            this.accidentYesRadio.Location = new System.Drawing.Point(36, 30);
            this.accidentYesRadio.Name = "accidentYesRadio";
            this.accidentYesRadio.Size = new System.Drawing.Size(52, 20);
            this.accidentYesRadio.TabIndex = 0;
            this.accidentYesRadio.Text = "Yes";
            this.accidentYesRadio.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(244, 235);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(186, 23);
            this.calcButton.TabIndex = 11;
            this.calcButton.Text = "Calculate Policy Premiums";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // healthCostLabel
            // 
            this.healthCostLabel.AutoSize = true;
            this.healthCostLabel.Location = new System.Drawing.Point(181, 292);
            this.healthCostLabel.Name = "healthCostLabel";
            this.healthCostLabel.Size = new System.Drawing.Size(200, 16);
            this.healthCostLabel.TabIndex = 12;
            this.healthCostLabel.Text = "Health Coverage Cost per Year: ";
            // 
            // healthCostOutput
            // 
            this.healthCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthCostOutput.Location = new System.Drawing.Point(393, 289);
            this.healthCostOutput.Name = "healthCostOutput";
            this.healthCostOutput.Size = new System.Drawing.Size(100, 23);
            this.healthCostOutput.TabIndex = 13;
            // 
            // carCostOutput
            // 
            this.carCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carCostOutput.Location = new System.Drawing.Point(393, 329);
            this.carCostOutput.Name = "carCostOutput";
            this.carCostOutput.Size = new System.Drawing.Size(100, 23);
            this.carCostOutput.TabIndex = 15;
            // 
            // carCostLabel
            // 
            this.carCostLabel.AutoSize = true;
            this.carCostLabel.Location = new System.Drawing.Point(199, 332);
            this.carCostLabel.Name = "carCostLabel";
            this.carCostLabel.Size = new System.Drawing.Size(182, 16);
            this.carCostLabel.TabIndex = 14;
            this.carCostLabel.Text = "Car Coverage Cost per Year: ";
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutput.Location = new System.Drawing.Point(393, 369);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(100, 23);
            this.totalCostOutput.TabIndex = 17;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(212, 372);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(169, 16);
            this.totalCostLabel.TabIndex = 16;
            this.totalCostLabel.Text = "Total Policy Cost per Year: ";
            // 
            // Prog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 407);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.carCostOutput);
            this.Controls.Add(this.carCostLabel);
            this.Controls.Add(this.healthCostOutput);
            this.Controls.Add(this.healthCostLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.accidentGroup);
            this.Controls.Add(this.smokeGroup);
            this.Controls.Add(this.carInsurCombo);
            this.Controls.Add(this.carInsurLabel);
            this.Controls.Add(this.healthInsurCombo);
            this.Controls.Add(this.healthInsurLabel);
            this.Controls.Add(this.manuTextbox);
            this.Controls.Add(this.manuLabel);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Prog2";
            this.Text = "Insurance Policy Calculator";
            this.smokeGroup.ResumeLayout(false);
            this.smokeGroup.PerformLayout();
            this.accidentGroup.ResumeLayout(false);
            this.accidentGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.TextBox manuTextbox;
        private System.Windows.Forms.Label manuLabel;
        private System.Windows.Forms.Label healthInsurLabel;
        private System.Windows.Forms.ComboBox healthInsurCombo;
        private System.Windows.Forms.ComboBox carInsurCombo;
        private System.Windows.Forms.Label carInsurLabel;
        private System.Windows.Forms.GroupBox smokeGroup;
        private System.Windows.Forms.RadioButton smokeNoRadio;
        private System.Windows.Forms.RadioButton smokeYesRadio;
        private System.Windows.Forms.GroupBox accidentGroup;
        private System.Windows.Forms.RadioButton accidentNoRadio;
        private System.Windows.Forms.RadioButton accidentYesRadio;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label healthCostLabel;
        private System.Windows.Forms.Label healthCostOutput;
        private System.Windows.Forms.Label carCostOutput;
        private System.Windows.Forms.Label carCostLabel;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label totalCostLabel;
    }
}

