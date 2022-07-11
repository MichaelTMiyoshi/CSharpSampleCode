/*	Name:  (Put your name here)
	Problem:  (Put the whole problem statement here, or use your own words.)
        Find the number of vans needed for a given number of people.
	Pseudocode:  (State your algorithm in English here.)
        Output app title to the screen
        Output instructions to the screen
        Declare and initialize variables
        Get input from the user
        Determine number of vans by dividing people by capacity
        Determine number of people walking by finding remainder (modulus)
        Output results to the screen in a way the user can read
	Notes:  (Put any notes about your thoughts here)
        The people walking is the same division as finding the vans
        Except that you use the modulus to find the remainder
	Maintenance log:
		Date:		Done:
		(Date here)	(What you did here)
*/
using System;

namespace CharterVans
{
    internal class CharterVans
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Charter Vans");
            Console.WriteLine("You are going to charter vans.");
            Console.WriteLine("Each van holds 7 people.");
            Console.WriteLine("Input the number of people going and");
            Console.WriteLine("the app will tell you the number of vans needed");
            Console.WriteLine("and how many people will need to walk.");
            Console.WriteLine("Only full vans will be chartered.\n");

            Console.Write("Input the number of people going: ");
            int people = Convert.ToInt32(Console.ReadLine());

            int vans;
            const int vanCapacity = 7;
            vans = people / vanCapacity;
            int peopleWalking = people % vanCapacity;
            if(peopleWalking != 0)
            {
                vans++;
            }

            Console.WriteLine("You will need to charter " + vans + " vans.");
            //Console.WriteLine("And " + peopleWalking + " will walk.");
        }
    }
}
