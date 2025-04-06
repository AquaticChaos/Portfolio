/*
    CIS-199-50-4228 Lab #2
    Due 9/18/2022
    ID: F2233
    Purpose: Using Visual Studio's Form Application and Design, create a GUI where the user will
        input the price of a meal, and after pressing the button it will calculate the tip based
        on three different tax amounts defined as constants in the button's click event, then
        display these calculations in their respective output labels.
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

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double mealCost = double.Parse(mealTextBox.Text);
            const double tax1 = 15, tax2 = 18, tax3 = 20;
            double tip1 = mealCost * (tax1 / 100);
            double tip2 = mealCost * (tax2 / 100);
            double tip3 = mealCost * (tax3 / 100);

            tax1Output.Text = tip1.ToString("C", CultureInfo.CurrentCulture);
            tax2Output.Text = tip2.ToString("C", CultureInfo.CurrentCulture);
            tax3Output.Text = tip3.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
