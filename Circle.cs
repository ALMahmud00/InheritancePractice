using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class Circle : Shape
    {
        protected double radius;

        public Circle()
        {
            radius = 1.0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.radius = radius;
            this.color = color;
        }
        public double GetArea()
        {
           return 3.14 * radius * radius;      
        }

        public double GetPerimeter() 
        {
            return 2 * 3.14 * radius;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Circle Area: "+ (3.14 * radius * radius));
            Console.WriteLine("Circle Perimeter: " + (2* 3.14 * radius));
            Console.WriteLine("Circle Color: " + color);
            Console.WriteLine("Circle Fill: " + filled);
        }

    }
}
