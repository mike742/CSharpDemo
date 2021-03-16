using System;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            string userPos = "developer";

            Console.WriteLine("Hello " + userName); // concatination
            Console.WriteLine("Hello {0} {1} {0}", userName, userPos);
            Console.WriteLine($"Hello {userName} {userPos}");
            */

            int i = 77;
            long l = i;
            float f = l;
            double d = 3.14;

            // c++ -> c++++ #
            // c -> c++ -> c++++ #
            // i = (int)d;
            string str = "314";
            // i = Int32.Parse(str);
            i = Convert.ToInt32(d);


            Console.WriteLine($"i = {i}");
            Console.WriteLine($"l = {l}");
            Console.WriteLine($"f = {f}");
            Console.WriteLine($"d = {d}");


            /*
                sbyte, byte, short, ushort, int, uint, long, ulong, float, double, 
                and decimal.
            */
            Console.WriteLine("\n\n");
            Console.WriteLine("|  Type  | Bytes of Memory |   Min   |   Max   |");
            Console.WriteLine("================================================");
            Console.WriteLine("| sbyte  | " + sizeof(sbyte) + " | " +
                        sbyte.MinValue + " | " + sbyte.MaxValue + " |"            
                    );
            Console.WriteLine("| byte  | " + sizeof(byte) + " | " +
                        byte.MinValue + " | " + byte.MaxValue + " |"
                     );
            Console.WriteLine("| float  | " + sizeof(float) + " | " +
                        float.MinValue + " | " + float.MaxValue + " |"
                     );
            Console.WriteLine("| double  | " + sizeof(double) + " | " +
                        double.MinValue + " | " + double.MaxValue + " |"
                     );
            Console.WriteLine("| long  | " + sizeof(long) + " | " +
                      long.MinValue + " | " + long.MaxValue + " |"
                   );
            Console.WriteLine("| decimal  | " + sizeof(decimal) + " | " +
                        decimal.MinValue + " | " + decimal.MaxValue + " |"
                     );

            Console.WriteLine("\n\n");
            int length = 100;

            for (int j = 1; j <= length; j++)
            {
                Console.Write(j);

                if (j == 100)
                {
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(", ");
                }

                if (j % 15 == 0) // 15 30 45 60 75 90
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
