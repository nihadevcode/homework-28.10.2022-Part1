using System;
using System.Collections.Generic;
using System.Text;

namespace _28._10._2022_Part1.Helpers.Extensions
{
    public static class Extensions
    {
        public static int Factorial(this int number)
        {
            int counter, fact;

            Console.WriteLine("Please enter the number you wish to factorize");
            number = int.Parse(Console.ReadLine());
            fact = number;

            for (counter = number - 1; counter >= 1; counter--)
            {
                fact = fact * counter;
            }
            Console.WriteLine("The number you entered was {0} and it's factorial is {1}", number, fact);
            return fact;
        }
    }
}
