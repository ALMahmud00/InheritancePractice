using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePractice
{
   class Shape
    {
        protected string color;
        protected bool filled;

        public Shape()
        {
            color = "red";
            filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Shape Color : " + color);
            Console.WriteLine("Shape Filled : " + filled);
        }


    }
}
