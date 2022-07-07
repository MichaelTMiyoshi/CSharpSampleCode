/*	Name:  (Put your name here)
	Problem:  (Put the whole problem statement here, or use your own words.)
        Declare, initialize, output string variables.
	Pseudocode:  (State your algorithm in English here.)
        Declare and initialize and output string variable
	Notes:  (Put any notes about your thoughts here.)
        Copy Git commit message to maintenance log.
	Maintenance log:    (You can copy your detailed Git commit messages.)
        Date:		Done:
        (Date here) (What you did here)
        07/07/2022	Sample code created (variables and constants)
*/
using System;

namespace SimpleStringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string firstName = "michael";
            Console.WriteLine(firstName[4]);
            firstName[0] = 'M';         // does not work.  strings are immutable
            Console.WriteLine(firstName);
            firstName = "X";            // changes the string to single char string
            Console.WriteLine(firstName);
            firstName = "Dillon";       // changes the string to multiple char string
            Console.WriteLine(firstName);
            firstName = "Michael";      // capitalize the first letter by changing the whole string
            Console.WriteLine(firstName);
        }
    }
}
