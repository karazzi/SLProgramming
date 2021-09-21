using System;

namespace InchConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ratio = 2.54;
            double inches = 3;
            double centimeter = inches * ratio;

            Console.WriteLine($"{inches:F2} inches er {centimeter:F2} centimeter");
        }
    }
}
