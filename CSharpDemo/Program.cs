using System;

namespace CSharpDemo
{

    public class Program
    {
        static void RefMethod(int a)
        {
            a = 777;
        }

        static void RefMethod(ref int a)
        {
            // may be modified
            a = 777;
        }

        static void OutMethod(out int a)
        {
            // must be modified
            a = 123456789;
        }

        static void InMethod(in int a)
        {
            // can not be modified (read-only)
            Console.WriteLine( a );
        }

        static void RefMethod(string s)
        {
            s = "Hello ref mod.";
        }

        static void RefMethod(ref string s)
        {
            s = "Hello ref mod.";
        }

        static void sumAndProduct(int a, int b, out int sum, out int prod)
        {
            sum = a + b;
            prod = a * b; 
        }

        static void printLength(params int[] arr)
        {
            Console.WriteLine(arr.Length);
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            printLength(arr);

            printLength(1, 2, 3, 4, 5, 6, 7, 8, 9);
            printLength(1, 2);
            printLength(1, 2, 3, 4, 5);

            // ref / out / in
            int a = 7;
            RefMethod(a);
            Console.WriteLine($"a = {a}");

            string s = "Hello";
            RefMethod(s);
            Console.WriteLine($"s = {s}");

            RefMethod(ref a);
            Console.WriteLine($"a = {a}");

            RefMethod(ref s);
            Console.WriteLine($"s = {s}");

            OutMethod(out a);
            Console.WriteLine($"a(out) = {a}");

            int b = Int32.Parse("123");
            Console.WriteLine($"b = {b}");

            int c;
            Int32.TryParse("4567", out c);
            Console.WriteLine($"c = {c}");

            int x = 5, y = 3, sum, prod;

            sumAndProduct(x, y, out sum, out prod);

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"prod = {prod}");

            Console.WriteLine("\n\nHave a nice day!");
        }
    }
}
