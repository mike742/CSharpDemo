using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text.Json;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 018,456,000,000,000,000,000
            // 18,000,000
            string userInput = "185050000000000000000000000"; 
            BigInteger bi = BigInteger.Parse(userInput);

            Console.WriteLine(  ToWords(bi) );

            /*
            string file = "LargeNumbers.txt";
            string content = File.ReadAllText(file);
            Console.WriteLine(content);
            */

            /*
            string[] unitsMap = new[]
            { "", "one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine", "ten", "eleven",
                "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen" };

            File.WriteAllLines("unitsMap.txt", unitsMap);
            

            string[] tensMap = new[]
            {"", "ten", "twenty", "thirty", "forty", "fifty",
                "sixty", "seventy", "eighty", "ninety" };
            File.WriteAllLines("tensMap.txt", tensMap);
            */

            string path = @"sourse/LargeNumbers.txt";

            Console.WriteLine( File.Exists(path) );
            Console.WriteLine( Path.GetFileName(path) );

            Console.WriteLine(Path.GetFileNameWithoutExtension(path)+".json");

            Console.WriteLine(Path.GetExtension(path));

            string path2 = @"d:/temp/index.html";
            Console.WriteLine("root : " + Path.GetPathRoot(path2));

            Console.WriteLine("dir name : " + Path.GetDirectoryName(path));

            string combPath = Path.Combine("source", "web", "ver #1", "Unix", "file.txt");

            Console.WriteLine("combPath : " + combPath);

            for (int i = 0; i < 10; i++)
            {
                string result = Path.GetRandomFileName();
                string tempPath = Path.GetTempPath();
                Console.WriteLine( $"Random {i} : {tempPath}{result}" );
            }
        }

        public static string[] ReadFromFile(string path)
        {
            string[] names = File.ReadAllLines(path);

            return names;
        }

        public static string ToWords(BigInteger number)
        {
            string[] partsByThree = number.ToString("N0").Split(",");
            string res = string.Empty;

            for (int i = 0; i < partsByThree.Length; i++)
            {
                if (partsByThree[i] != "000") {
                    res += !string.IsNullOrEmpty(res) ? " " : "";
                    res += PartToWords(partsByThree[i]);
                    res += " " + LargeNumberToWord(partsByThree.Length - i - 1);
                }
            }

            return res;
        }

        public static string LargeNumberToWord(int value)
        {
            string[] largeMap = ReadFromFile(@"sourse/LargeNumbers.txt");

            return largeMap[value];
        }

        public static string PartToWords(string part)
        {
            part = part.PadLeft(3, '0');

            string[] unitsMap = ReadFromFile(@"sourse/unitsMap.txt");
            string[] tensMap = ReadFromFile(@"sourse/tensMap.txt");
            int index;
            string result = string.Empty;

            // transform hundreds
            if (part[0] != '0') // 1 2 3 4 .. 9
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
                
                // 015
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

            // 21 45 79
            result += !string.IsNullOrEmpty(tens)
                       && !string.IsNullOrEmpty(oneDigit) ? "-" : "";
            result += oneDigit;

            return result;
        }
    }
}
