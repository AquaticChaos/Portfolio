namespace Prog2Start
{
    partial class CouchForm
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
            components = new System.ComponentModel.Container();
            priceTextbox = new TextBox();
            priceLabel = new Label();
            categoryLabel = new Label();
            categoryTextbox = new TextBox();
            weightLabel = new Label();
            weightTextbox = new TextBox();
            seatLabel = new Label();
            seatTextbox = new TextBox();
            legLabel = new Label();
            legTextbox = new TextBox();
            coMaterialLabel = new Label();
            cushionGroup = new GroupBox();
            cuMaterialCombo = new ComboBox();
            label10 = new Label();
            heightLabel = new Label();
            heightTextbox = new TextBox();
            widthLabel = new Label();
            widthTextbox = new TextBox();
            lengthLabel = new Label();
            lengthTextbox = new TextBox();
            submitButton = new Button();
            coMaterialCombo = new ComboBox();
            errorProvider = new ErrorProvider(components);
            cushionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // priceTextbox
            // 
            priceTextbox.Location = new Point(111, 6);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.Size = new Size(125, 27);
            priceTextbox.TabIndex = 0;
            priceTextbox.Validating += decimalValidating;
            priceTextbox.Validated += inputValidated;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(12, 9);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 20);
            priceLabel.TabIndex = 1;
            priceLabel.Text = "Price:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(12, 54);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(72, 20);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextbox
            // 
            categoryTextbox.Location = new Point(111, 51);
            categoryTextbox.Name = "categoryTextbox";
            categoryTextbox.Size = new Size(125, 27);
            categoryTextbox.TabIndex = 2;
            categoryTextbox.Validating += stringTBValidating;
            categoryTextbox.Validated += inputValidated;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(12, 99);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(95, 20);
            weightLabel.TabIndex = 5;
            weightLabel.Text = "Weight (lbs.):";
            // 
            // weightTextbox
            // 
            weightTextbox.Location = new Point(111, 96);
            weightTextbox.Name = "weightTextbox";
            weightTextbox.Size = new Size(125, 27);
            weightTextbox.TabIndex = 4;
            weightTextbox.Validating += doubleValidating;
            weightTextbox.Validated += inputValidated;
            // 
            // seatLabel
            // 
            seatLabel.AutoSize = true;
            seatLabel.Location = new Point(12, 144);
            seatLabel.Name = "seatLabel";
            seatLabel.Size = new Size(78, 20);
            seatLabel.TabIndex = 7;
            seatLabel.Text = "# of Seats:";
            // 
            // seatTextbox
            // 
            seatTextbox.Location = new Point(111, 141);
            seatTextbox.Name = "seatTextbox";
            seatTextbox.Size = new Size(125, 27);
            seatTextbox.TabIndex = 6;
            seatTextbox.Validating += intValidating;
            seatTextbox.Validated += inputValidated;
            // 
            // legLabel
            // 
            legLabel.AutoSize = true;
            legLabel.Location = new Point(12, 189);
            legLabel.Name = "legLabel";
            legLabel.Size = new Size(73, 20);
            legLabel.TabIndex = 9;
            legLabel.Text = "# of Legs:";
            // 
            // legTextbox
            // 
            legTextbox.Location = new Point(111, 186);
            legTextbox.Name = "legTextbox";
            legTextbox.Size = new Size(125, 27);
            legTextbox.TabIndex = 8;
            legTextbox.Validating += intValidating;
            legTextbox.Validated += inputValidated;
            // 
            // coMaterialLabel
            // 
            coMaterialLabel.AutoSize = true;
            coMaterialLabel.Location = new Point(12, 234);
            coMaterialLabel.Name = "coMaterialLabel";
            coMaterialLabel.Size = new Size(67, 20);
            coMaterialLabel.TabIndex = 11;
            coMaterialLabel.Text = "Material:";
            // 
            // cushionGroup
            // 
            cushionGroup.Controls.Add(cuMaterialCombo);
            cushionGroup.Controls.Add(label10);
            cushionGroup.Controls.Add(heightLabel);
            cushionGroup.Controls.Add(heightTextbox);
            cushionGroup.Controls.Add(widthLabel);
            cushionGroup.Controls.Add(widthTextbox);
            cushionGroup.Controls.Add(lengthLabel);
            cushionGroup.Controls.Add(lengthTextbox);
            cushionGroup.Location = new Point(279, 9);
            cushionGroup.Name = "cushionGroup";
            cushionGroup.Size = new Size(298, 224);
            cushionGroup.TabIndex = 21;
            cushionGroup.TabStop = false;
            cushionGroup.Text = "Cushion";
            // 
            // cuMaterialCombo
            // 
            cuMaterialCombo.FormattingEnabled = true;
            cuMaterialCombo.Items.AddRange(new object[] { "Leather", "Textile" });
            cuMaterialCombo.Location = new Point(133, 171);
            cuMaterialCombo.Name = "cuMaterialCombo";
            cuMaterialCombo.Size = new Size(125, 28);
            cuMaterialCombo.TabIndex = 29;
            cuMaterialCombo.Validating += stringCushionValidating;
            cuMaterialCombo.Validated += inputValidated;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 174);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 26;
            label10.Text = "Material:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(41, 127);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(86, 20);
            heightLabel.TabIndex = 25;
            heightLabel.Text = "Height (in.):";
            // 
            // heightTextbox
            // 
            heightTextbox.Location = new Point(133, 124);
            heightTextbox.Name = "heightTextbox";
            heightTextbox.Size = new Size(125, 27);
            heightTextbox.TabIndex = 24;
            heightTextbox.Validating += doubleMaxValidating;
            heightTextbox.Validated += inputValidated;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(41, 80);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(81, 20);
            widthLabel.TabIndex = 23;
            widthLabel.Text = "Width (in.):";
            // 
            // widthTextbox
            // 
            widthTextbox.Location = new Point(133, 77);
            widthTextbox.Name = "widthTextbox";
            widthTextbox.Size = new Size(125, 27);
            widthTextbox.TabIndex = 22;
            widthTextbox.Validating += doubleMaxValidating;
            widthTextbox.Validated += inputValidated;
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(41, 33);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(86, 20);
            lengthLabel.TabIndex = 21;
            lengthLabel.Text = "Length (in.):";
            // 
            // lengthTextbox
            // 
            lengthTextbox.Location = new Point(133, 30);
            lengthTextbox.Name = "lengthTextbox";
            lengthTextbox.Size = new Size(125, 27);
            lengthTextbox.TabIndex = 20;
            lengthTextbox.Validating += doubleMaxValidating;
            lengthTextbox.Validated += inputValidated;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(245, 265);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 27;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // coMaterialCombo
            // 
            coMaterialCombo.FormattingEnabled = true;
            coMaterialCombo.Items.AddRange(new object[] { "Leather", "Textile" });
            coMaterialCombo.Location = new Point(111, 231);
            coMaterialCombo.Name = "coMaterialCombo";
            coMaterialCombo.Size = new Size(125, 28);
            coMaterialCombo.TabIndex = 28;
            coMaterialCombo.Validating += stringCouchValidating;
            coMaterialCombo.Validated += inputValidated;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // CouchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 301);
            Controls.Add(coMaterialCombo);
            Controls.Add(submitButton);
            Controls.Add(cushionGroup);
            Controls.Add(coMaterialLabel);
            Controls.Add(legLabel);
            Controls.Add(legTextbox);
            Controls.Add(seatLabel);
            Controls.Add(seatTextbox);
            Controls.Add(weightLabel);
            Controls.Add(weightTextbox);
            Controls.Add(categoryLabel);
            Controls.Add(categoryTextbox);
            Controls.Add(priceLabel);
            Controls.Add(priceTextbox);
            Name = "CouchForm";
            Text = "CouchForm";
            cushionGroup.ResumeLayout(false);
            cushionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox priceTextbox;
        private Label priceLabel;
        private Label categoryLabel;
        private TextBox categoryTextbox;
        private Label weightLabel;
        private TextBox weightTextbox;
        private Label seatLabel;
        private TextBox seatTextbox;
        private Label legLabel;
        private TextBox legTextbox;
        private Label coMaterialLabel;
        private GroupBox cushionGroup;
        private Label label10;
        private Label heightLabel;
        private TextBox heightTextbox;
        private Label widthLabel;
        private TextBox widthTextbox;
        private Label lengthLabel;
        private TextBox lengthTextbox;
        private Button submitButton;
        private ComboBox cuMaterialCombo;
        private ComboBox coMaterialCombo;
        private ErrorProvider errorProvider;
    }
}