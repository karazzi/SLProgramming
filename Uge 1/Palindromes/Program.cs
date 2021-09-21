using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv et ord, du vil teste om er et palindrom: ");
            string text = Console.ReadLine();

            string trimmedText = Regex.Replace(text.ToLower(), @"[^0-9a-zA-Z]+", "");
            bool palindrome = false;

            for (int i = trimmedText.Length; i > 0; i--)
            {
                if (trimmedText.Substring(i - 1, 1) != trimmedText.Substring(trimmedText.Length - i, 1))
                {
                    break;
                }

                if (i == 1)
                {
                    palindrome = true;
                }
            }

            if (palindrome)
            {
                Console.WriteLine($"{text} er et palindrom!");
            }
            else
            {
                Console.WriteLine($"{text} er IKKE et palindrom!");
            }
        }
    }
}
