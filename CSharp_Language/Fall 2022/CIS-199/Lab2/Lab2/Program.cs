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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
