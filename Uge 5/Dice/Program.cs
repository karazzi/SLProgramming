using System;
using Dice.Models;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program startet!");

            Die die = new Die();
            die.Roll();
            Console.WriteLine(die.GetValue());

            DieCup dieCup = new DieCup();

            dieCup.Roll();
            Console.WriteLine(dieCup.GetValue());
            Console.WriteLine(dieCup.ToString());
        }
    }
}
