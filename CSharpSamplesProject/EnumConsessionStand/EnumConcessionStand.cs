namespace EnumConcessionStand
{
    internal class EnumConcessionStand
    {
        enum Sizes { None, Small, Medium, Large, Jumbo }
        static void Main(string[] args)
        {
            Console.WriteLine("Concession Stand");
            Sizes drink = Sizes.None, popcorn = Sizes.None;
            double total = 0;

            Console.WriteLine("Welcome to the concession stand.");
            Console.WriteLine("We have drinks and popcorn available.");
            Console.WriteLine("Drinks and popcorn come in Small, Medium, Large, and Jumbo sizes.");
            Console.WriteLine("Choose your drink size.");
            Console.WriteLine("\t0. None\n\t1. Small $1.50\n\t2. Medium $2.50\n\t3. Large $4.00\n\t4. Jumbo $6.00");
            drink = (Sizes)Convert.ToInt32(Console.ReadLine());
            Console.Write(">> ");
            switch(drink)
            {
                case Sizes.None:
                    Console.WriteLine("You have chosen not to get a drink.");
                    break;
                case Sizes.Small:
                    total += 1.5;
                    break;
                case Sizes.Medium:
                    total += 2.5;
                    break;
                case Sizes.Large:
                    total += 4.0;
                    break;
                case Sizes.Jumbo:
                    total += 6.0;
                    break;
                default:
                    Console.WriteLine("Not a choice");
                    break;
            }

            Console.WriteLine("Total: {0,10:C2}", total);
        }
    }
}