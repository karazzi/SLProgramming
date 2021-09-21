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
            var input = Console.ReadLine();
            bool palindrome;

            if (int.TryParse(input, out int tryInt))
            {
                palindrome = IsPalindrome(tryInt);
            } else if(decimal.TryParse(input, out decimal tryDec))
            {
                palindrome = IsPalindrome(tryDec);
            }
            else
            {
                palindrome = IsPalindrome(input);
            }

            if (palindrome)
            {
                Console.WriteLine($"{input} er et palindrom!");
            }
            else
            {
                Console.WriteLine($"{input} er IKKE et palindrom!");
            }
        }

        static bool IsPalindrome(string text)
        {
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

            return palindrome;
        }

        static bool IsPalindrome(int input)
        {
            string text = input.ToString();
            return IsPalindrome(text);
        }

        static bool IsPalindrome(decimal input)
        {
            string text = input.ToString();
            return IsPalindrome(text);
        }
    }
}
