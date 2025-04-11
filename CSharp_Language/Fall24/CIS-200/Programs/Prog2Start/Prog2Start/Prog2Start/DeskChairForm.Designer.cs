namespace Prog2Start
{
    partial class DeskChairForm
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
            submitButton = new Button();
            legLabel = new Label();
            legTextbox = new TextBox();
            seatLabel = new Label();
            seatTextbox = new TextBox();
            weightLabel = new Label();
            weightTextbox = new TextBox();
            categoryLabel = new Label();
            categoryTextbox = new TextBox();
            priceLabel = new Label();
            priceTextbox = new TextBox();
            spinCheckBox = new CheckBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(107, 261);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 41;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // legLabel
            // 
            legLabel.AutoSize = true;
            legLabel.Location = new Point(42, 191);
            legLabel.Name = "legLabel";
            legLabel.Size = new Size(73, 20);
            legLabel.TabIndex = 38;
            legLabel.Text = "# of Legs:";
            // 
            // legTextbox
            // 
            legTextbox.Location = new Point(141, 188);
            legTextbox.Name = "legTextbox";
            legTextbox.Size = new Size(125, 27);
            legTextbox.TabIndex = 37;
            legTextbox.Validating += intValidating;
            legTextbox.Validated += inputValidated;
            // 
            // seatLabel
            // 
            seatLabel.AutoSize = true;
            seatLabel.Location = new Point(42, 146);
            seatLabel.Name = "seatLabel";
            seatLabel.Size = new Size(78, 20);
            seatLabel.TabIndex = 36;
            seatLabel.Text = "# of Seats:";
            // 
            // seatTextbox
            // 
            seatTextbox.Location = new Point(141, 143);
            seatTextbox.Name = "seatTextbox";
            seatTextbox.Size = new Size(125, 27);
            seatTextbox.TabIndex = 35;
            seatTextbox.Validating += intValidating;
            seatTextbox.Validated += inputValidated;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(42, 101);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(95, 20);
            weightLabel.TabIndex = 34;
            weightLabel.Text = "Weight (lbs.):";
            // 
            // weightTextbox
            // 
            weightTextbox.Location = new Point(141, 98);
            weightTextbox.Name = "weightTextbox";
            weightTextbox.Size = new Size(125, 27);
            weightTextbox.TabIndex = 33;
            weightTextbox.Validating += doubleValidating;
            weightTextbox.Validated += inputValidated;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(42, 56);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(72, 20);
            categoryLabel.TabIndex = 32;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextbox
            // 
            categoryTextbox.Location = new Point(141, 53);
            categoryTextbox.Name = "categoryTextbox";
            categoryTextbox.Size = new Size(125, 27);
            categoryTextbox.TabIndex = 31;
            categoryTextbox.Validating += stringTBValidating;
            categoryTextbox.Validated += inputValidated;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(42, 11);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 20);
            priceLabel.TabIndex = 30;
            priceLabel.Text = "Price:";
            // 
            // priceTextbox
            // 
            priceTextbox.Location = new Point(141, 8);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.Size = new Size(125, 27);
            priceTextbox.TabIndex = 29;
            priceTextbox.Validating += decimalValidating;
            priceTextbox.Validated += inputValidated;
            // 
            // spinCheckBox
            // 
            spinCheckBox.AutoSize = true;
            spinCheckBox.Location = new Point(121, 231);
            spinCheckBox.Name = "spinCheckBox";
            spinCheckBox.Size = new Size(67, 24);
            spinCheckBox.TabIndex = 42;
            spinCheckBox.Text = "Spin?";
            spinCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // DeskChairForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 298);
            Controls.Add(spinCheckBox);
            Controls.Add(submitButton);
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
            Name = "DeskChairForm";
            Text = "DeskChairForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button submitButton;
        private Label legLabel;
        private TextBox legTextbox;
        private Label seatLabel;
        private TextBox seatTextbox;
        private Label weightLabel;
        private TextBox weightTextbox;
        private Label categoryLabel;
        private TextBox categoryTextbox;
        private Label priceLabel;
        private TextBox priceTextbox;
        private CheckBox spinCheckBox;
        private ErrorProvider errorProvider;
    }
}