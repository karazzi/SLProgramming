using System;

namespace InteractiveInchConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ratio = 2.54;
            
            Console.Write("Skriv inches der skal omregnes til centimeter: ");
            double inches = Convert.ToDouble(Console.ReadLine());

            double centimeter = inches * ratio;

            Console.WriteLine($"{inches:F2} inches er {centimeter:F2} centimeter");
        }
    }
}
