/*
 * Student ID: 5262256
 * Program: 1
 * Due date: 9/23/24
 * Course Section: CIS-200-75-4248
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Start
{
    public partial class DeskChairForm : Form
    {
        public DeskChairForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US, false").TextInfo;

            if (this.ValidateChildren()) //If all other values are valid...
            {
                
                //Set the form's desk chair values accordingly
                Price = decimal.Parse(priceTextbox.Text);
                Category = categoryTextbox.Text;
                Weight = double.Parse(weightTextbox.Text);
                Seats = int.Parse(seatTextbox.Text);
                Legs = int.Parse(legTextbox.Text);
                Spin = spinCheckBox.Checked;

                //Set the form's desk chair object accordingly
                DeskChair = new DeskChair(Price, Category, Weight, Seats, Legs, Spin);
                
                //Set dialogresult to OK, close form
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        //Textbox Validated functions
        private void inputValidated(object sender, EventArgs e)
        {
            errorProvider.SetError(this, "");//Validated, clear error
        }

        //Decimal Textbox Validating function (Price)
        private void decimalValidating(object sender, CancelEventArgs e)
        {
            TextBox senderTB = (TextBox)sender;
            if (decimal.TryParse(senderTB.Text, out decimal decValue) && senderTB.Text != "")
            {//If textbox's text is a valid double and not blank...
                e.Cancel = false;//...Validating is successful
            }
            else
            {
                errorProvider.SetError(senderTB, "Please enter a decimal currency value");
                e.Cancel = true;//...Validating is unsuccessful, show error
            }
        }

        //String Textbox Validating function (Category)
        private void stringTBValidating(object sender, CancelEventArgs e)
        {
            TextBox senderTB = (TextBox)sender;
            if (!string.IsNullOrWhiteSpace(senderTB.Text))
            {//If textbox's text is a valid string and not blank/null/whitespace...
                e.Cancel = false;//...Validating is successful
            }
            else
            {
                errorProvider.SetError(senderTB, "Please enter a valid value");
                e.Cancel = true;//...Validating is unsuccessful
            }
        }

        //Weight TextBox Validating function (Weight)
        private void doubleValidating(object sender, CancelEventArgs e)
        {
            TextBox senderTB = (TextBox)sender;
            if (double.TryParse(senderTB.Text, out double dobValue) && senderTB.Text != "")
            {//If textbox's text is a valid double, not blank, and greater than zero...
                e.Cancel = false;//...Validating is successful
            }
            else
            {
                errorProvider.SetError(senderTB, "Please enter a valid value");
                e.Cancel = true;//...Validating is unsuccessful, show error
            }
        }

        //Int TextBox Validating function (Seat, Leg)
        private void intValidating(object sender, CancelEventArgs e)
        {
            TextBox senderTB = (TextBox)sender;
            if (int.TryParse(senderTB.Text, out int intValue) && senderTB.Text != "" && intValue > 0)
            {//If textbox's text is a valid int, not blank, and greater than zero...
                e.Cancel = false;//...Validating is successful
            }
            else
            {
                errorProvider.SetError(senderTB, "Please enter a valid value greater than 0");
                e.Cancel = true;//...Validating is unsuccessful, show error
            }
        }

        //No validation needed for Spin boolean, will always be either checked (True) or unchecked (False)

        //Get-set variables for DeskChair object
        public decimal Price { get; set; }
        public string Category { get; set; }
        public double Weight { get; set; }
        public int Seats { get; set; }
        public int Legs { get; set; }

        public bool Spin {  get; set; }

        public DeskChair DeskChair { get; set; }
    }
}
