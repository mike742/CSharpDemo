using System;
using System.Numerics;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput = "919560000000000000000";
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

            // 014
            // transform teens
            string tens = string.Empty;
            if (part[1] == '1')
            {
                index = Convert.ToInt32(part[1].ToString() + part[2].ToString());
                // Console.WriteLine("index = " + index);
                //Console.WriteLine("unitsMap[index] = " + unitsMap[index]);
                tens = unitsMap[index];
                result += string.IsNullOrEmpty(result) ? "" : " and ";
                result += tens;
            }

            Console.WriteLine("=======================");
            //int ind = Convert.ToInt32(part[2].ToString());

            Console.WriteLine(result);
        }
    }
}
