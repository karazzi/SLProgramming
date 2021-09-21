using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv et heltal: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string text = "";

                if (i % 3 == 0)
                {
                    text += "Fizz";
                }

                if (i % 5 == 0)
                {
                    text += "Buzz";
                }

                if (i % 7 == 0)
                {
                    text += "Jazz";
                }

                if (!String.IsNullOrEmpty(text))
                {
                    Console.WriteLine(text);
                }
            }
        }
    }
}
