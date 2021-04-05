using System;
using System.Numerics;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //string userInput = "919560000000000000000";
            string userInput = "727";
            BigInteger bi = BigInteger.Parse(userInput);

            string[] partsByThree = bi.ToString("N0").Split(",");

            foreach (string part in partsByThree)
            {
                Console.WriteLine(part.PadLeft(3, '0')); // 001 // 014 // 123
            }


            PartToWords(partsByThree[0].PadLeft(3, '0'));
        }

        public static void PartToWords(string part)
        {
            string[] unitsMap = new[]
            { "", "one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine", "ten", "eleven",
                "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen" };

            string[] tensMap = new[]
            {"", "ten", "twenty", "thirty", "forty", "fifty",
                "sixty", "seventy", "eighty", "ninety" };

            Console.WriteLine("=======================");
            Console.WriteLine(part);

            int index;
            string result = string.Empty;

            // transform hundreds
            if (part[0] != '0')
            {
                index = Convert.ToInt32(part[0].ToString());
                result += unitsMap[index] + " hundred";
            }

            // 011 012 013 ... 018 019 -> 020 031 040.... 080 091 || 109
            // transform teens
            string tens = string.Empty;
            if (part[1] == '1')
            {
                index = Convert.ToInt32(part[1].ToString() + part[2].ToString());
                tens = unitsMap[index];
                
                result += string.IsNullOrEmpty(result) ? "" : " and ";
                result += tens;
            }
            else if (part[1] != '0')
            {
                index = Convert.ToInt32(part[1].ToString());
                tens = tensMap[index];
            }

            Console.WriteLine(" tens = " + tens);

            string oneDigit = string.Empty;

            // "999"
            if (part[2] != '0')
            { 
                index = Convert.ToInt32(part[2].ToString());
                oneDigit = unitsMap[index];
            }

            Console.WriteLine(" oneDigit = " + oneDigit);

            Console.WriteLine("=======================");
            //int ind = Convert.ToInt32(part[2].ToString());

            // result!!!!

            Console.WriteLine(result);
        }
    }
}
