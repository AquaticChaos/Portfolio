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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Prog2Start
{
    public partial class CouchForm : Form
    {
        public CouchForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US, false").TextInfo;

            if (this.ValidateChildren()) //If all other values are valid...
            {
                //Set the form's couch values accordingly
                Price = decimal.Parse(priceTextbox.Text);
                Category = categoryTextbox.Text;
                Weight = double.Parse(weightTextbox.Text);
                Seats = int.Parse(seatTextbox.Text);
                Legs = int.Parse(legTextbox.Text);
                couchMaterial = textInfo.ToTitleCase(coMaterialCombo.Text.ToLower());

                //Set the form's cushion values accordingly
                Length = double.Parse(lengthTextbox.Text);
                Width = double.Parse(widthTextbox.Text);
                Height = double.Parse(heightTextbox.Text);
                cushionMaterial = textInfo.ToTitleCase(cuMaterialCombo.Text.ToLower());

                //Set the form's cushion and couch objects accordingly
                Cushion = new Cushion(cushionMaterial, Length, Width, Height);
                Couch = new Couch(Price, Category, Weight, Seats, Legs, couchMaterial, Cushion);

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

        //String Couch ControlBox Validating function (Material)
        private void stringCouchValidating(object sender, CancelEventArgs e)
        {
            ComboBox senderCB = (ComboBox)sender;
            if (!string.IsNullOrWhiteSpace(senderCB.Text))
            {//If textbox's text is a valid string and not blank/null/whitespace...
                if (senderCB.Text.ToLower() == "leather" || senderCB.Text.ToLower() == "textile")
                {
                    e.Cancel = false;//...And either leather or textile, validating is successful
                }
                else
                {
                    errorProvider.SetError(senderCB, "Please enter either Leather or Textile");
                    e.Cancel = true;//...And is something other than leather or textile, validating is unsuccessful, show error
                }
            }
            else
            {
                errorProvider.SetError(senderCB, "Please enter a valid value");
                e.Cancel = true;//...Validating is unsuccessful, show error
            }
        }

        //String Cushion ControlBox Validating function (Material)
        private void stringCushionValidating(object sender, CancelEventArgs e)
        {
            ComboBox senderCB = (ComboBox)sender;
            if (!string.IsNullOrWhiteSpace(senderCB.Text))
            {//If textbox's text is a valid string and not blank/null/whitespace...
                if (senderCB.Text.ToLower() == "foam" || senderCB.Text.ToLower() == "stuffing")
                {
                    e.Cancel = false;//...And either foam or stuffing, validating is successful
                }
                else
                {
                    errorProvider.SetError(senderCB, "Please enter either Foam or Stuffing");
                    e.Cancel = true;//...And is something other than foam or stuffing, validating is unsuccessful, show error
                }
            }
            else
            {
                errorProvider.SetError(senderCB, "Please enter a valid value");
                e.Cancel = true;//...Validating is unsuccessful, show error
            }
        }

        //Double TextBox Validating function with additional validation (Length, Width, Height)
        private void doubleMaxValidating(object sender, CancelEventArgs e)
        {
            TextBox senderTB = (TextBox)sender;
            if (double.TryParse(senderTB.Text, out double dobValue) && senderTB.Text != "")
            {//If textbox's text is a valid double and not blank...
                if (dobValue > 0 && dobValue <= 24) { e.Cancel = false; } //...And b/w 0-24, validating is successful
                else
                {
                    errorProvider.SetError(senderTB, "Please enter a number between 0 and 24");
                    e.Cancel = true; //If negative or over 24, validating is unsuccessful, show error
                }
            }
            else
            {
                errorProvider.SetError(senderTB, "Please enter a valid value");
                e.Cancel = true; //If not double or blank, validating is unsuccessful, show error
            }
        }


        //Get-set variables for Couch object
        public decimal Price { get; set; }
        public string Category { get; set; }
        public double Weight { get; set; }
        public int Seats { get; set; }
        public int Legs { get; set; }
        public string couchMaterial { get; set; }
        public Cushion Cushion { get; set; }
        public Couch Couch { get; set; }

        //Get-set variables for Cushion object
        public string cushionMaterial { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
