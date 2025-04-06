/*
    CIS-199-50-4228 Lab #7
    Due: 11/13/2022
    ID: F2233
    Purpose: To create a square pattern (same length in rows and columns) of astericks/stars from user
        input of the specified length using a nested for-loop and primarily a void method. Void methods 
        help with cleaning up, organizing, and re-using code.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean isValid = false; //Set boolean for exiting while loop
            while (!isValid) //Exit loop only when valid input made
            {
                Console.WriteLine("How many rows and columns of astericks would you like?");

                if (Int32.TryParse(Console.ReadLine(), out int inputVal)) //Is input an integer?
                {
                    if (inputVal > 0) //Greater than 0?
                    { 
                        ShowSquareOfStars(inputVal); 
                        isValid = true;
                        //Integer greater than zero, call method with input as parameter & exit while loop.
                    } 
                    else { 
                        Console.WriteLine("Number must be greater than zero. Please try again."); 
                        //Less than or equal to 0, repeat while loop.
                    }

                }
                else
                {
                    Console.WriteLine("Invalid number, please try again.");
                    //Not an integer, repeat while loop.
                }
            }
        }

        static void ShowSquareOfStars(int numStars)
        {
            for(int i = 1; i <= numStars; i++) //Control rows
            {
                for(int j = 1; j <= numStars; j++) //Control columns
                {
                    Console.Write("*"); //Write asatericks on line/row
                }

                Console.WriteLine(""); //Move to next line/row.
            }
        }
    }
}
