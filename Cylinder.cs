using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
    class Cylinder : Circle
    {
        private double height = 1.0;

        public Cylinder() 
        {
                    
        }

        public Cylinder(double height)
        {
            this.height = height;
        }
        public Cylinder(double height, double radius)
        {
            this.height = height;
            this.radius = radius;
        }
        public Cylinder(double height, double radius, string color, bool filled)
        {
            this.height = height;
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }
        public double GetArea()
        {
            return 2 * 3.14 * radius * (height + radius);
        }
        public double GetPerimeter()
        {
            return 2 * 3.14 * radius;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Cylinder Area: " + (2 * 3.14 * radius * (height + radius)));
            Console.WriteLine("Cylinder Perimeter: " + (2 * 3.14 * radius));
        }


    }
}
