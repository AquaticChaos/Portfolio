/*
    CIS-199-50-4228 Lab #1
    Due 9/4/2022
    ID: F2233
    Purpose: This program will display, using the Console.WriteLine command, 
        my grading ID, hobbies, and favorite book and movie.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("{0,-18}{1,-18}","Grading ID:", "F2233");
            WriteLine("{0,-18}{1,-18}", "Hobbies:", "LEGO & Video Games");
            WriteLine("{0,-18}{1,-18}", "Favorite Book:", "Five Nights at Freddy's: The Silver Eyes");
            WriteLine("{0,-18}{1,-18}", "Favortie Movie:", "Sonic The Hedgehog (2020)");

            /*I'm not entirely sure what my favorite movie or book is since I rarely watch/read either,
                so I went with the ones I remember liking the most off the top of my head.*/
        }
    }
}
