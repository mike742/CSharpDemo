using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CustomerClassLibrary;

namespace DotNetCore
{

    class ABC
    {

        static void Main(string[] args)
        {
            /*
            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Enter key has been pushed");
            }
            else if (cki.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Esc key has been pushed");
            }
            */

            string pn1 = "204 123-4567";
            string pn2 = "204 123-4568";
            string pn3 = "204 123-4577";
            string pn4 = "204 123-4555";
            string pn5 = "204 123-9764";
            string pn6 = "204 123-1124";
            // ddd ddd-dddd
            string em1 = "mark.smithgmail.com";
            //llll.llllll@llllll.lll
            string url = "https://";

            /*
             string path1 = "c:\\project\\c_sharp\\bizzBazz";
             string path2 = @"c:\project\c_sharp\bizzBazz\n";

            Console.WriteLine("path1 = " + path1);
            Console.WriteLine("path2 = " + path2);
            */
            // a
            string pattern = @"\baaa\b"; // <aaa>
            string inputStr = "aaa";

            //Console.WriteLine(Regex.IsMatch(inputStr, pattern));

            /*
            Regex re = new Regex(@"^\d{3} \d{3}-\d{4}$");
            inputStr = "204 123-4567";
            Console.WriteLine(re.IsMatch(inputStr));
            */
            PrintIsMatch("204 123-4567", @"[0-9]{3} \d{3}-\d{4}");
            PrintIsMatch("BOOK", @"[a-zA-Z]{4}");

            PrintIsMatch("cats", @"[a-z]{3,}");
            PrintIsMatch("many-cats", @"[a-z\-]{3,12}");
            PrintIsMatch("many1cats", @"[a-z0-9]{3,12}");

            PrintIsMatch("Mark_Smith", @"\w{5,32}"); // [0-9a-zA-Z_]

            PrintIsMatch("   ", @"\s{3,}"); // white spaces

            PrintIsMatch(" ", @"[a-z]+"); // + - {1,}
        }

        public static void PrintIsMatch(string value, string pattern)
        {
            Regex re = new Regex($"^{pattern}$");
            Console.WriteLine($"{value} and {pattern}: {re.IsMatch(value)}");
        }
    }
}
