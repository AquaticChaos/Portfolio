/*
    CIS-199-50-4228 Program #2
    Due: 10/20/2022
    ID: F2233
    Purpose: To calculate the cost of health and car insurance (and the overall total) based on
        coverage method (if any), age, manufactured car's year, and whether the user had smoked 
        or been in an accident before. All of which is calculated and then shown to the user.

        (Insurance Coverages, Smoke, Accident options have a set default to prevent errors)
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

namespace Program2
{
    public partial class Prog2 : Form
    {
        public Prog2()
        {
            InitializeComponent();
            //Insurance rate is per month, should be calculated into per year ( * 12)
            healthInsurCombo.SelectedIndex = 0; //Set default value to "none," keep index in range
            //0 = "None", 1 = "EPO", 2 = "PPO", 3 = "HDP"

            carInsurCombo.SelectedIndex = 0; //Set default value to "none," keep index in range
            //0 = "None", 1 = "Full", 2 = "Liability"
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int age, manuYear; //Age of user, manufacture year of car, input by user
            int healthInsur, carInsur; //Type of health & car coverage based on combo index
            Boolean didSmoke, hadAccident; //Whether user has smoked or been in accident; default "No"

            Boolean ageValid = Int32.TryParse(ageTextbox.Text, out age); //Set age if valid
            Boolean manuYearValid = Int32.TryParse(manuTextbox.Text, out manuYear); //Set year if valid

            healthInsur = healthInsurCombo.SelectedIndex; //Set healthInsur based on index of combo
            carInsur = carInsurCombo.SelectedIndex; //Set carInsur based on index of combo
            //Checking if the two Insurances are in range will be covered further down

            //If "Yes" is checked, set true. If "No" or nothing is (somehow) checked, set false
            if (smokeYesRadio.Checked) { didSmoke = true; } else { didSmoke = false; }
            if (accidentYesRadio.Checked) { hadAccident = true; } else { hadAccident = false; }



            //If any values not set properly, set boolean to true & add to error message
            Boolean errorExists = false;
            string errorMessage = "The following errors have occured:\n";
            if (!ageValid) 
            { errorExists = true; errorMessage += "\nAge is not set to a valid value"; }
            if (!manuYearValid) 
            { errorExists = true; errorMessage += "\nCar's manufactured year is not set to a valid value"; }

            double healthInsurRate = 0, carInsurRate = 0;
            switch(healthInsur) //Calculate base rate based on health insurance coverage
            {
                case 0: healthInsurRate = 0.00; break; //"None"
                case 1: healthInsurRate = 100.00; break; //"EPO"
                case 2: healthInsurRate = 75.00; break; //"PPO"
                case 3: healthInsurRate = 25.00; break; //"HDP"
                default:
                    errorExists = true;
                    errorMessage += "\nHealth Insurance Coverage not set to a valid type";
                    break; //If somehow not set
            }
            switch (carInsur) //Calculate base rate based on car insurance coverage
            {
                case 0: carInsurRate = 0.00; break; //"None"
                case 1: carInsurRate = 115.00; break; //"Full"
                case 2: carInsurRate = 60.00; break; //"Liability"
                default:
                    errorExists = true;
                    errorMessage += "\nCar Insurance Coverage not set to a valid type";
                    break; //If somehow not set
            }
            
            const double SMOKERATE = 30.00; //If user smokes, add 30 to health insurance
            const double ACCIDENTFACTOR = 1.30; //If user had accident, multiply base car insurance rate by 1.3
            const double YOUTHRATE = 10.00; //If younger than 25, add 10 to car insurance
            const double NEWCARRATE = 15.00; //If car made 2012 or later, add 15 to car insurance

            //Check if any errors
            if(errorExists)
            {
                //If errors exist, show them in message box
                MessageBox.Show(errorMessage + "\n\nPlease make sure the above are set properly, then try again");
            } else
            {
                //If no errors exist, calculate health, car, & total insurance cost

                //Health insurance
                double healthInsurCost = healthInsurRate;
                if (didSmoke) { healthInsurCost += SMOKERATE; } //If user smokes
                healthInsurCost = healthInsurCost * 12; //Monthly to yearly

                //Car insurance
                double carInsurCost = 0;
                if (age < 25) { carInsurCost += YOUTHRATE; } //If user younger than 25
                if (manuYear >= 2012) { carInsurCost += NEWCARRATE; }// If car made 2012 or later
                if (hadAccident) { carInsurCost += carInsurRate * ACCIDENTFACTOR; } //If user had accident before
                else { carInsurCost += carInsurRate; } //If user hasn't had accident before
                carInsurCost = carInsurCost * 12; //Monthly to yearly

                //Total insurance cost
                double totalInsurCost = healthInsurCost + carInsurCost;

                healthCostOutput.Text = healthInsurCost.ToString("C", CultureInfo.CurrentCulture);
                carCostOutput.Text = carInsurCost.ToString("C", CultureInfo.CurrentCulture);
                totalCostOutput.Text = totalInsurCost.ToString("C", CultureInfo.CurrentCulture);
            }
        }
    }
}
