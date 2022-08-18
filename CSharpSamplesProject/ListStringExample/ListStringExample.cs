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
            List<List<int>> int3x4 = new List<List<int>> { new List<int> { 0, 1, 2, 3},
                                                           new List<int> {4, 5, 6, 7 },
                                                           new List<int> {8, 9, 10, 11 }};

            for (int r = 0; r < int3x4.Count; r++)
            {
                for(int c = 0; c < int3x4[r].Count; c++)
                {
                    Console.Write("{0,5}", int3x4[r][c]);
                }
                Console.WriteLine();
            }

            int3x4.Clear();
            Console.WriteLine("Empty List\n\n");
            for (int r = 0; r < int3x4.Count; r++)
            {
                for (int c = 0; c < int3x4[r].Count; c++)
                {
                    Console.Write("{0,5}", int3x4[r][c]);
                }
                Console.WriteLine();
            }

            for(int r = 0; r < 5; r++)
            {
                List<int> inner = new List<int>();
                for (int c = 0; c < 6; c++)
                {
                    inner.Add(r * c);
                }
                int3x4.Add(inner);
            }
            Console.WriteLine("newly created 2D List (5x6)");
            for (int r = 0; r < int3x4.Count; r++)
            {
                for (int c = 0; c < int3x4[r].Count; c++)
                {
                    Console.Write("{0,5}", int3x4[r][c]);
                }
                Console.WriteLine();
            }

        }
    }
}