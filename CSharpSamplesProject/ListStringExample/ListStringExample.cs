namespace ListStringExample
{
    internal class ListStringExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of Strings");
            List<String> fortunes = new List<String> { "You will have a great day",
                "You are amazing!", 
                "What is the any key?" };

            Console.WriteLine(fortunes[2]);
            Console.WriteLine(fortunes[1][11]); // the output is a 'z'

            Console.WriteLine("2D List");
            List<List<int>> int3x4 = new List<List<int>>();
        }
    }
}