using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTester
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle() // default constructor
        {
            Radius = 0;
        }

        public Circle(double Radius)    // constructor with argument(s)
        {
            this.Radius = Radius;
        }

        public Circle(Circle C) // copy constructor
        {
            Radius = C.Radius;
        }

        public double Circumference()
        {
            return Math.PI * Radius * 2.0;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override String ToString()
        {
            String output = String.Format("Radius:    {0, 8:0.000}\n", Radius);
            output += String.Format("Perimeter: {0, 8:0.000}\n", Circumference());
            output += String.Format("Area:      {0, 8:0.000}\n", this.Area());
            return output;
        }
    }
}
