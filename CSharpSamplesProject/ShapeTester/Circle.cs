using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTester
{
    public class Circle
    {
        public double radius { get; set; }

        public Circle()
        {
            radius = 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(Circle C)
        {
            radius = C.radius;
        }

        public double Circumference()
        {
            return Math.PI * radius * 2.0;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public override String ToString()
        {
            String output = String.Format("Radius:    {0, 8:0.000}\n", radius);
            output += String.Format("Perimeter: {0, 8:0.000}\n", Circumference());
            output += String.Format("Area:      {0, 8:0.000}\n", this.Area());
            return output;
        }
    }
}
