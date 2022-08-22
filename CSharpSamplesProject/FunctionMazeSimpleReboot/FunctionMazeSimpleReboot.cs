namespace FunctionMazeSimpleReboot
{
    internal class FunctionMazeSimpleReboot
    {
        static void Main(string[] args)
        {
            Instructions();
            String name = Console.ReadLine();

            int location = 1;

            do
            {
                switch (location)
                {
                    case 1:
                        location = FirstRoom(name);
                        break;
                    case 2:
                        location = SecondRoom(name, location);
                        break;
                }
            } while (location != 3);

            location = ThirdRoom(name);
        }
        static void Instructions()
        {
            Console.WriteLine("Simple Maze.");
            Console.Write("Input your name: ");
            return;
        }
        static int FirstRoom(String name)
        {
            Console.Write(name + ", enter 2: ");
            int room = 1;
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == '2')
            {
                room = 2;
            }
            else
            {
                Console.WriteLine("Not an option, try again.");
            }
            return room;
        }
        static int SecondRoom(String name, int door)
        {
            Console.WriteLine(name + ", you may go to 1 or 3");
            Console.Write("Choose: ");
            int ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1 || ans == 3)
            {
                door = ans;
            }
            else
            {
                Console.WriteLine("Not an option, try again.");
            }
            return door;
        }
        static int ThirdRoom(String name)
        {
            Console.WriteLine(name + ", you won!\n");
            Console.WriteLine("Press any key to continue: ");
            return 3;
        }
    }
}