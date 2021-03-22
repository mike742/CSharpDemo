using System;

namespace CSharpDemo
{
    public class Program
    {
        public static string PrimeFactors(int number)
        {
            // F10
            string res = string.Empty; 
            
            for (int i = 2; i <= number; ++i)
            {
                while (number % i == 0) 
                {
                    res = res + i + " "; 
                    number = number / i; 
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            // F5
            Console.WriteLine(PrimeFactors(6));

            /*
                6  / 2
                3  / 2! /3
                1
                -----------
                "2 x 3"

                50 / 2
                25 /2! /3! /4! /5
                5  /2! /3! /4! /5
                ---------------
                "2 x 5 x 5"
             */

            
            Console.WriteLine("\n\nHave a nice day!");
        }
    }
}
