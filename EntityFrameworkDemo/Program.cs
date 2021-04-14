using System;
using System.Collections.Generic;
using System.IO;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DbModel.northwindContext();
            var customersList = context.Customers;

            foreach (var item in customersList)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.JobTitle}");
            }

            // Helper.Serializer.ToJson(customersList, "customers.json");
            // Helper.Serializer.ToXml(customersList, "customers.xml");
            Helper.Serializer.ToBinary(customersList, "customers.dat");

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
                }
            };

            Console.WriteLine("========================================");
            foreach (var item in fileList)
            {
                Console.WriteLine($"{item.Name} has {item.Size} bytes");
            }
        }
    }


    public class SerializedFile
    {
        public string Name { get; set; }
        public long Size { get; set; }
    }
}
