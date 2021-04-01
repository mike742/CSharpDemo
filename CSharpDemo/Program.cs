using System;
using System.Numerics;
using System.Text;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = string.Empty;

            str = "Hello"; // "Hello" -> 
            str += " ";    // "Hello " ->
            str += "Strings"; // -> 

            // Console.WriteLine("str = " + str);
            //str = string.Empty; 

            StringBuilder sb = new StringBuilder();

            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("StringBuilder");
            sb.Append("!");

            // Console.WriteLine("sb = " + sb);


            string str2 = @"I do not like them
In a house.
I do not like them
With a mouse.
I do not like them
Here or there.
I do not like them
Anywhere.
I do not like green eggs and ham.
I do not like them, Sam - I - am.";

            //str2 = str2.Replace("not ", "");

            // Console.WriteLine(str2);

            StringBuilder sb2 = new StringBuilder(str2);
            sb2.Replace("not ", "");

            // Console.WriteLine(sb2);

            string userInput = "9845600000000000000";
            BigInteger bi = BigInteger.Parse(userInput);

            // Console.WriteLine( bi.ToString("N0") );

            string[] partsByThree =  bi.ToString("N0").Split(",");
            Console.WriteLine("partsByThree.Length = " + partsByThree.Length);

            foreach (string part in partsByThree)
            {
                Console.WriteLine(part.PadLeft(3, '0') ); // 001 // 014 // 123
            }


            PartToWords(partsByThree[0].PadLeft(3, '0'));
        }

        public static void PartToWords(string part)
        {
            string[] unitsMap = new[] 
            { "", "one", "two", "three", "four", "five", 
                "six", "seven", "eight", "nine" };
            
            int ind = Convert.ToInt32(part[2].ToString());

            Console.WriteLine(unitsMap[ind]);
        }
    }
}
