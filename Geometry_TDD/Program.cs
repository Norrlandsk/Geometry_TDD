using Geometry_TDD.Shapes;
using System;
using System.Collections.Generic;

namespace Geometry_TDD
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calc = new Calculator();

            var circle = new Circle(5);
            var rectangle = new Rectangle(10, 5);
            var square = new Square(5);
            var triangle = new Triangle(10, 5);

            Console.WriteLine(calc.GetArea(circle));
            Console.WriteLine(calc.GetArea(rectangle));
            Console.WriteLine(calc.GetArea(square));
            Console.WriteLine(calc.GetArea(triangle));

            Console.WriteLine(calc.GetPerimeter(circle));
            Console.WriteLine(calc.GetPerimeter(rectangle));
            Console.WriteLine(calc.GetPerimeter(square));
            Console.WriteLine(calc.GetPerimeter(triangle));

            var shapeList = new List<IShape>()
            {
                new Circle(5),new Rectangle(10,5),new Square(5), new Triangle(10,5)
            };
            Console.WriteLine(Calculator.GetPerimeter(shapeList));
        }
    }
}