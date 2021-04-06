using System;
using System.Numerics;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput = "919560000000000000000";
            // string userInput = "109";
            BigInteger bi = BigInteger.Parse(userInput);

            string[] partsByThree = bi.ToString("N0").Split(",");

            string str = PartToWords(partsByThree[0].PadLeft(3, '0'));
            Console.WriteLine(str);
        }

        public static string LargeNumberToWord(int value)
        {
            string[] largeNumberMap = new[] { "", "" };


            return "";
        }

        public static string PartToWords(string part)
        {
            string[] unitsMap = new[]
            { "", "one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine", "ten", "eleven",
                "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen" };

            string[] tensMap = new[]
            {"", "ten", "twenty", "thirty", "forty", "fifty",
                "sixty", "seventy", "eighty", "ninety" };

            int index;
            string result = string.Empty;

            // transform hundreds
            if (part[0] != '0')
            {
                index = Convert.ToInt32(part[0].ToString());
                result += unitsMap[index] + " hundred";
            }

            // transform teens
            string tens = string.Empty;
            if (part[1] == '1')
            {
                index = Convert.ToInt32(part[1].ToString() + part[2].ToString());
                tens = unitsMap[index];
                
                result += string.IsNullOrEmpty(result) ? "" : " and ";
                result += tens;

                return result;
            }
            else if (part[1] != '0')
            {
                index = Convert.ToInt32(part[1].ToString());
                tens = tensMap[index];
            }

            string oneDigit = string.Empty;

            if (part[2] != '0')
            { 
                index = Convert.ToInt32(part[2].ToString());
                oneDigit = unitsMap[index];
            }

            // 5 9 0
            result += !string.IsNullOrEmpty(result)
                      && !string.IsNullOrEmpty(tens) ? " and " : "";
            result += tens;

            // 5 0 1   5 and 1 
            result += !string.IsNullOrEmpty(result)
                        && string.IsNullOrEmpty(tens)
                        && !string.IsNullOrEmpty(oneDigit) ? " and " : "";

            result += !string.IsNullOrEmpty(tens)
                       && !string.IsNullOrEmpty(oneDigit) ? "-" : "";
            result += oneDigit;

            return result;
        }
    }
}
