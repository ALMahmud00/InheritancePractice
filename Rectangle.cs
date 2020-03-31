using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
     class Rectangle : Shape
    {
        protected double width;
        protected double length;

        public Rectangle()
        {
            width = 1.0;
            length = 1.0;
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled)
        {
            this.width = width;
            this.length = length;
            this.color = color;
            this.filled = filled;
        }

        public double GetArea()
        {
            return width * length;
        }
        public double GetPerimeter()
        {
            return 2 * (width + length);
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Reactangle Area: " + width * length);
            Console.WriteLine("Rectangle Perimeter: "+ 2 * (width + length));
            Console.WriteLine("Rectangle Color: " + color);
            Console.WriteLine("Rectangle Fill: " + filled);
        }

    }
}
