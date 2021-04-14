using System;

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
        }
    }
}
