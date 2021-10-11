using System;
using Figurer.Models;

namespace Figurer
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(2, 5);
            Rectangle rectangle = new Rectangle(2, 5);

            Console.WriteLine($"Areal af trekant: {triangle.GetArea()}");
            Console.WriteLine($"Areal af firkant: {rectangle.GetArea()}");
        }
    }
}
