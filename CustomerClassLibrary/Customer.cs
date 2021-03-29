using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerClassLibrary
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        private static string ClassInfo;

        static Customer()
        {
            ClassInfo = "Our class has name Customer";
        }

        public static string GetClassInfo() => ClassInfo;

        public Customer(string firstName, string lastName)
        {
            Console.WriteLine("ctor with params has been called");

            _firstName = firstName;
            _lastName = lastName;
        }
        
        public Customer() : this("n/a", "n/a") { }

        
        public void PrintFullName() =>
            Console.WriteLine($"{_lastName} {_firstName}");

       
        public string GetFullName() => _firstName + " " + _lastName;
    }
}
