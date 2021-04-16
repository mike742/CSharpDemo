using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DbModel.northwindContext();
            var customersList = context.Customers.ToList();

            
            foreach (var item in customersList)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.City}");
            }
            
            // Helper.Serializer.ToJson(customersList, "customers.json");
            // Helper.Serializer.ToXml(customersList, "customers.xml");
            // Helper.Serializer.ToBinary(customersList, "customers.dat");

            // FileInfo

            List<SerializedFile> fileList = new List<SerializedFile>
            {
                new SerializedFile
                { 
                    Name = "customers.json",
                    Size = new FileInfo("customers.json").Length
                },
                new SerializedFile
                {
                    Name = "customers.xml",
                    Size = new FileInfo("customers.xml").Length
                },
                new SerializedFile
                {
                    Name = "customers.dat",
                    Size = new FileInfo("customers.dat").Length
                }
            };

            fileList.Sort();

            Console.WriteLine("========================================");
            foreach (var item in fileList)
            {
                Console.WriteLine($"{item.Name} has {item.Size} bytes");
            }
            Console.WriteLine("========================================");
            
            
            /*
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // var res = from i in numbers
            //           where i % 2 == 0
            //           select i;

            var res = numbers.Where(i => i % 2 == 0);

            foreach (var item in res)
            {
                Console.Write(  item + " " );
            }
            */
            string city = "New York";
            var cusCityList = customersList.Where(c => c.City.Equals(city)); // city == "NY"

            var cities = customersList.Select(c => c.City).Distinct().ToList();
            // List<string> citiesList = cities.ToList();
            cities.Sort();
            cities.Reverse();
            
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            //List<string> testList = new List<string> { "b", "e", "c", "d", "a" };
            //testList.Sort();

            // testList.ForEach( s => Console.WriteLine(s) );

            // cities
            string joined = string.Join(", ", cities.ToArray());
            Console.WriteLine("joined = " + joined);


            // cities.ToList().ForEach( c => Console.WriteLine(c) );

            // Console.WriteLine("========================================");
            // foreach (var item in cusCityList)
            // {
            //     Console.WriteLine($"{item.LastName} {item.FirstName} - {item.City}");
            // }
        }
    }


    public class SerializedFile : IComparable<SerializedFile>
    {
        public string Name { get; set; }
        public long Size { get; set; }

        public int CompareTo([AllowNull] SerializedFile other)
        {
            return Size.CompareTo(other.Size);
        }
    }
}
