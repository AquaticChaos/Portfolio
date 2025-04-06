/*
    CIS-199-50-4228 Lab #5
    Due: 10/16/2022
    ID: F2233
    Purpose: To gather multiple given temperatures within a range (-20 to 130 here) by the user, 
        then find the average/mean after the user inputs the exit value (999 in this case)
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperVal = 0; //The variable input by the user
            int inputTally = 0; //How many temperatures were inputted (to find mean)
            int totalVal = 0; //The total value of every temperature value inputted (to find mean)

            const int EXITVAL = 999; //If this input, exit the loop & calculate
            const int MINVAL = -20, MAXVAL = 130; //Minimum & maximum temperature value (inclusive)

            Console.WriteLine("Enter temperatures from {0} to {1} ({2} to stop)", 
                    MINVAL, MAXVAL, EXITVAL);


            while(temperVal != EXITVAL) //Start loop, continue while value not exit value
            {
                Console.Write("Enter temperature: ");

                //Check if input value is valid, set to a boolean
                Boolean isValid = int.TryParse(Console.ReadLine(), out temperVal);

                if (isValid && temperVal >= MINVAL && temperVal <= MAXVAL)
                {
                    //If valid number & within range, add to total & increment tally
                    totalVal += temperVal;
                    inputTally++;
                }
                else if (isValid && temperVal == EXITVAL)
                {/*If valid number & equal to exit value, exit while loop*/}
                else { //If not numerical, or outside of valid range
                    Console.WriteLine("Valid temperatures range from {0} to {1}." + 
                        " Please reenter temperature", MINVAL, MAXVAL);
                }
            }

            //Display tally & average after exiting loop
            Console.WriteLine("You entered {0} valid temperatures.", inputTally);
            double meanVal = Math.Round((double)totalVal / inputTally, 1);
            Console.WriteLine("The mean temperature is {0} degrees", meanVal);
        }
    }
}
