/*
    CIS-199-50-4228 Lab/Program/Exam #
    Due: 10/30/2022
    ID: F2233
    Purpose: The purpose of this lab is to use nested for loops to write astericks (stars)
        to the console based on a labelled pattern A-D (align left increment, left decrement, 
        right decrement, then right increment)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_STAR = 10; //Maximum amount of stars on a line per pattern
            int space = 0; //How many spaces to write for patterns C and D

            //PATTERN A, align left increment
            Console.WriteLine("Pattern A\n");
            for(int i = 0; i < MAX_STAR; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*"); //Write j amount of stars based on i
                }
                Console.WriteLine(); //Write to next line, repeat above
            }

            //PATTERN B, align left decrement
            Console.WriteLine("\nPattern B\n");
            for (int i = MAX_STAR; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*"); //Write j amount of stars based on i
                }
                Console.WriteLine(); //Write to next line, repeat above
            }

            //PATTERN C, align right decrement
            Console.WriteLine("\nPattern D\n");
            for (int i = MAX_STAR; i > 0; i--)
            {
                space = MAX_STAR - i; //Calculate how many spaces to write per line
                for(int k = 0; k < space; k++) //Write k amount of spaces based on above variable
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++) //Write j amount of stars based on i
                {
                    Console.Write("*");
                }
                Console.WriteLine(); //Write to next line, repeat above
            }

            //PATTERN D, align right increment
            Console.WriteLine("\nPattern C\n");
            for (int i = 0; i < MAX_STAR; i++)
            {
                space = MAX_STAR - i; //Calculate how many spaces to write per line
                for (int k = 0; k < space - 1; k++) //Write k amount of spaces based on above variable
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++) //Write j amount of stars based on i
                {
                    Console.Write("*");
                }
                Console.WriteLine(); //Write to next line, repeat above
            }
        }
    }
}
