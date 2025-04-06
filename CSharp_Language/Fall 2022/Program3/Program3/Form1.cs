/*
    CIS-199-50-4228 Program #3
    Due: 11/13/2022 (Formerly 11/10/2022)
    ID: F2233
    Purpose: To calculate the loan interest, credit rating, and down payment based on
        user input of credit score & loan amount and type through the use of parallel arrays and
        range matching.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class program3Form : Form
    {
        public program3Form()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Values used for later assuming no errors.
            string outputCSRating = "Null";
            double outputCSInterest = -1, outputLTBaseRate = -1, outputLADownPerc = -1;

            //For displaying percentage and currency
            CultureInfo ci = new CultureInfo("en-us");

            //Arrays to compare input credit score to max & min values...
            int[] creditScoreMin = {300, 580, 670, 740, 800}; //Allowed minimum of 300
            int[] creditScoreMax = {579, 669, 739, 799, 850}; //Allowed minimum of 300
            //And calculate the rating & loan interest amounts.
            string[] creditScoreRating = {"Poor", "Fair", "Good", "Very Good", "Excellent"};
            double[] creditScoreInterest = {0.08014, 0.07373, 0.07063, 0.06149, 0.059};

            //Inputted loan type won't need arrays, a simple case-switch will suffice later.

            //Similarly, arrays to compare input loan amount to min & max values...
            double[] loanAmountMin = {1, 500, 2000, 10000, 100000}; //Allowed minimum of $1
            double[] loanAmountMax = {499, 1999, 9999, 99999, 500000}; //Allowed maximum of $500K
            //And again calculate the down payment percent.
            double[] loanAmountDown = {0, .1, .15, .1, .05};

            //Check if anything is wrong, display message at end if so display message with problems.
            Boolean isAllValid = true;
            string errorText = "Please check over the following and try again:\n";



            //Inputted loan type
            if (loanTypeCombo.SelectedIndex >= 0) //If selection made...
            {
                switch(loanTypeCombo.Text)
                {
                    case "Home":
                        outputLTBaseRate = 1; break; //100%
                    case "Auto":
                        outputLTBaseRate = 1.3; break; //130%
                    case "Unsecured":
                        outputLTBaseRate = 2; break; //200%
                    default:
                        isAllValid = false;
                        errorText += "\nAn invalid loan type was selected";
                        break; //Failsafe if somehow none of above
                }
            } else
            { //If no selection made
                isAllValid = false;
                errorText += "\nA loan type was not selected.";
            }

            //Inputted credit score
            if (Int32.TryParse(creditScoreTextbox.Text, out int creditScoreInput)) //If int...
            {
                Boolean creditScoreInRange = false;
                for (int i = 0; i < loanAmountMin.Length; i++) //Go through array loop, arrays have same length
                {
                    if (creditScoreInput >= creditScoreMin[i] && creditScoreInput <= creditScoreMax[i])
                    { //Found range? Exit for-loop early and set values for later.
                        creditScoreInRange = true;
                        outputCSRating = creditScoreRating[i];
                        outputCSInterest = creditScoreInterest[i];
                        break;
                    }
                }

                if (!creditScoreInRange)
                {
                    isAllValid = false;
                    errorText += "\nThe provided credit score is outside the range 300 - 850.";
                }
            }
            else //If not int...
            {
                //Error found, add to error text that number not given
                isAllValid = false;
                errorText += "\nA number was not given for your credit score.";
            }


            //Inputted loan amount
            if (double.TryParse(loanAmountTextbox.Text, out double loanAmountInput))
            { //If valid input
                Boolean loanAmountInRange = false;
                for(int i = 0; i < loanAmountMin.Length; i++) //Go through array loop, arrays have same length
                {
                    if(loanAmountInput >= loanAmountMin[i] && loanAmountInput  <= loanAmountMax[i])
                    { //Found range? Exit for-loop early and set values for later.
                        loanAmountInRange = true;
                        outputLADownPerc = loanAmountDown[i];
                        break;
                    }
                    
                }

                if (!loanAmountInRange)
                {
                    isAllValid = false;
                    errorText += "\nThe provided loan amount is outside the range 1 - 500,000.";
                }
            } else
            {//If invalid input
                isAllValid = false;
                errorText += "\nAn invalid loan amount was made.";
            }

            if(isAllValid) //No errors?
            {
                //Calculate final loan interest from credit score & loan type, display as percent
                double outputInterestFinal = outputCSInterest * outputLTBaseRate;
                loanInterestOutput.Text = outputInterestFinal.ToString("P", ci);

                //Display credit rating recieved from input credit score
                creditRatingOutput.Text = outputCSRating; //No need to do ToString, already one.

                //Calculate down payment from loan amount, display as currency
                double downPaymentFinal = outputLADownPerc * loanAmountInput;
                downPaymentOutput.Text = downPaymentFinal.ToString("C", ci);
            }
            else //Errors found, show message.
                 {MessageBox.Show(errorText);}
        }
    }
}
