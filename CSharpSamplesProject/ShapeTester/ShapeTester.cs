using System;
namespace ShapeTester
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Tester");
            Circle c = new Circle();
            c.Radius = 10.0;
            Console.WriteLine(c);
            Circle c1 = new Circle(c);
            Console.WriteLine(c1);
            c1.Radius = 5.0;
            Console.WriteLine("c1's new radius = " + c1.Radius + "\n");
            Circle c2 = new Circle(15.0);
            Console.WriteLine(c2);
            //Square s = new Square();
        }
    }
}