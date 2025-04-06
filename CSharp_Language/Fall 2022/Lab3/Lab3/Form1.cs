/*
    CIS-199-50-4228 Lab #3
    Due: 9/25/2022
    ID: F2233
    Purpose: The purpose of this lab is to calculate the diameter, surface area, and 
        volume of a sphere based on a user-inputted radius, all done in a GUI.
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

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double radi = Convert.ToDouble(radiTextbox.Text); //Radius value inputted by user

            //Define & Calculate Diameter
            double diam = 2 * radi;

            //Define & Calculate Surface Area
            double area = 4 * Math.PI * Math.Pow(radi, 2);

            //Define & Calculate Volume
            double volume = (4 * Math.PI * Math.Pow(radi, 3)) / 3;

            //Set Output Labels to Above Values
            diamOutput.Text = diam.ToString("#.00");
            areaOutput.Text = area.ToString("#.00");
            voluOutput.Text = volume.ToString("#.00");
        }
    }
}
