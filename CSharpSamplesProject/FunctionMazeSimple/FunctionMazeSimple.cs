﻿namespace FunctionMazeSimple
{
    internal class FunctionMazeSimple
    {
        static void Main(string[] args)
        {
            Instructions();
            String name = Console.ReadLine();

            int room = 1;

            do
            {
                switch (room)
                {
                    case 1:
                        room = Room1(name);
                        break;
                    case 2:
                        room = Room2(name, room);
                        break;
                }
            } while (room != 3);

            room = Room3(name);
        }
        static void Instructions()
        {
            Console.WriteLine("Simple Maze.");
            Console.Write("Input your name: ");
            return;
        }
        static int Room1(String name)
        {
            Console.Write(name + ", enter 2: ");
            int room = 1;
            char ans = Convert.ToChar(Console.ReadLine());
            if(ans == '2')
            {
                room = 2;
            }
            else
            {
                Console.WriteLine("Not an option, try again.");
            }
            return room;
        }
        static int Room2(String name, int door)
        {
            Console.WriteLine(name + ", you may go to 1 or 3");
            Console.Write("Choose: ");
            int ans = Convert.ToInt32(Console.ReadLine());
            if(ans == 1 || ans == 3)
            {
                door = ans;
            }
            else
            {
                Console.WriteLine("Not an option, try again.");
            }
            return door;
        }
        static int Room3(String name)
        {
            Console.WriteLine(name + ", you won!\n");
            Console.WriteLine("Press any key to continue: ");
            return 3;
        }
    }
}