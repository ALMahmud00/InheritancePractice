using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class Square : Rectangle
    {
        protected double side;

        public Square()
        {
            side = 1.0;
        }
        public Square(double side)
        {
            this.side = side;
        }
        public Square(double side, string color, bool filled)
        {
            this.side = side;
            this.color = color;
            this.filled = filled;
        }

        public double GetArea()
        {
            return side * side;
        }
        public double GetPerimeter()
        {
            return 4 * side;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Square Area: " + side*side);
            Console.WriteLine("Square Perimeter: " + 4 * side);
            Console.WriteLine("Square Color: " + color);
            Console.WriteLine("Square Fill: " + filled);
        }

    }
}
