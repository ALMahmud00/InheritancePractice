using System;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape shape = new Shape();
            shape.DisplayInfo();

            Console.WriteLine("\n");

            Circle circle = new Circle();
            circle.DisplayInfo();

            Console.WriteLine("\n");

            Cylinder cylinder = new Cylinder();
            cylinder.DisplayInfo();

            Console.WriteLine("\n");

            Rectangle rectangle = new Rectangle();
            rectangle.DisplayInfo();

            Console.WriteLine("\n");

            Square square = new Square();
            square.DisplayInfo();




            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");




        }
    }
}
