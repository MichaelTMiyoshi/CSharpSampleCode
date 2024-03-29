﻿/*	Name:  (Put your name here)
	Problem:  (Put the whole problem statement here, or use your own words.)
        Declare and initialize variables.
	Pseudocode:  (State your algorithm in English here.)
        Output message to the screen
        Declare and initialize variable and constant
	Notes:  (Put any notes about your thoughts here.)
        Copy Git commit message to maintenance log.
	Maintenance log:    (You can copy your detailed Git commit messages.)
        Date:		Done:
        (Date here) (What you did here)
        07/06/2022	Sample code created (variables and constants)
        07/07/2022  Output variables.  Added formatting and a bool.
*/
// This is a comment
using System;

namespace FirstIdentifiers
{
    internal class Identifiers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  // output to the screen
            int someVariable = 0;
            const double someConstant = 10.0;
            const double c = 300_000_000; //3e8;
            char someChar = 'q';
            string someString = "Goodbye...";
            bool someBool = true;
            Console.WriteLine("someVariable = " + someVariable);
            Console.WriteLine("someConstant = " + someConstant);
            Console.WriteLine("someChar = " + someChar);
            Console.WriteLine("someString = " + someString);
            Console.WriteLine(String.Format("someConstant (3 decimal places) = {0:0.000}", someConstant));
            Console.WriteLine(String.Format("c (scientific notation) = {0:#.##e+00}", c));
            Console.WriteLine("someConstant (3 decimal places) = {0:0.000}", someConstant);
            Console.WriteLine("c (scientific notation) = {0:#.##e+00}", c);

            // some additional code
            someVariable = 14;
            //someConstant = 15;  // this will cause an error
            someChar = 'x';
            someString = "for now.";
            Console.WriteLine("someVariable = " + someVariable);
            Console.WriteLine("someConstant = " + someConstant);
            Console.WriteLine(String.Format("c = {0:#.00e+0}", c));
            Console.WriteLine("c = {0:#.00e+0}", c);
            Console.WriteLine("someChar = " + someChar);
            Console.WriteLine("someString = " + someString);
            Console.WriteLine("someBool = " + someBool);
        }
    }
}
