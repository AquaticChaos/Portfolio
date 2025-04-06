/*
    CIS-199-50-4228 Program #1
    Due: 
    ID: F2233
    Purpose: The purpose of this program is to calculate area as well as the cost of 
        painting, coating, labor, and the overall cost based on the width, height, 
        number of colors, price of paint, number of coats/layers, and whether to 
        illuiminate it based on user input. All of which done in a GUI to make it
        easy to understand.
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

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Define input variables
            double width, height, paint;
            int colors, coatNum, illumToggle;

            //Define above using textboxes
            width = Convert.ToDouble(widthTextbox.Text);
            height = Convert.ToDouble(heightTextbox.Text);
            paint = Convert.ToDouble(paintTextbox.Text);
            colors = int.Parse(colorTextbox.Text);
            coatNum = int.Parse(coatnumTextbox.Text);
            illumToggle = int.Parse(illumTextbox.Text);

            //Define output variables & extra values
            double area, laborCost, paintCost, coatingCost, totalCost;
            double lightCost = 75.00, sqftCost = 6.50, extraCost = .10, colorCost = 8.50, coatCost = 10.00; 

            //Define above using input variables
            area = width * height;
            laborCost = (illumToggle * lightCost) + (area * sqftCost);
            paintCost = (area * paint) * (1 + extraCost) + (colors * colorCost);
            coatingCost = coatNum * coatCost;
            totalCost = laborCost + paintCost + coatingCost;

            //Change output labels to output variables
            areaOutput.Text = area.ToString("#.0");
            paintingOutput.Text = paintCost.ToString("C", CultureInfo.CurrentCulture);
            coatsOutput.Text = coatingCost.ToString("C", CultureInfo.CurrentCulture);
            laborOutput.Text = laborCost.ToString("C", CultureInfo.CurrentCulture);
            totalOutput.Text = totalCost.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
