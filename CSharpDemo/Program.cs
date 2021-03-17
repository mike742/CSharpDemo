using System;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            try
            {
                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An IndexOutOfRangeException has occured: {0} {1} {2} {1}", 
                        e.Message, 77, 123);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception has occured: {0}", e.Message);
            }
            */

            /*
            int[] arr2 = { 19, 3, 75, 52 };

            try
            {
                for (int i = 0; i < arr2.Length - 1; i++)
                {
                    Console.WriteLine(arr2[i] / arr2[i + 1]);
                }

                // throw new ArgumentOutOfRangeException;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("not-finally block");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            */

            Console.WriteLine("Enter a number between 0 and 255: ");
            string n1 = Console.ReadLine();

            Console.WriteLine("Enter another number between 0 and 255: ");
            string n2 = Console.ReadLine();

            try
            {
                int num1 = Int32.Parse(n1);
                int num2 = Int32.Parse(n2);

                if (!(num1 >= 0 && num1 <= 255) || !(num2 >= 0 && num2 <= 255))
                {
                    throw new ArgumentOutOfRangeException();
                }
                /*
                else if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                */
                else
                {
                    Console.WriteLine("\n" + num1 + " divided by " + num2
                        + " is " + (num1 / num2));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nFormatException: Input string ....");
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("\nDivideByZeroException: " + e.Message);
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\nArgumentOutOfRangeException: Number(s) is out of range");
            }

            Console.WriteLine("\n\nHave a nice day!");
        }
    }
}
