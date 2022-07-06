/*	Name:  Michael T. Miyoshi
	Problem:  Declare and initialize variables.
	Pseudocode:  
        Output message to the screen
        Declare and initialize variable and constant
	Notes:  Copy Git commit message to maintenance log.
	Maintenance log:
        Date:		Done:
        07/06/2022	Sample code created (variables and constants)
*/
using System;

namespace FirstIdentifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  // output to the screen
            int someVariable = 0;
            const double someConstant = 10.0;
            int someChar = 'q';
        }
    }
}
