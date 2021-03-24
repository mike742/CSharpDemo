﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo
{
    class Customer
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
        /*
        public Customer()
        {
            _firstName = "n/a";
            _lastName = "n/a";
        }
        */
        public Customer() : this("n/a", "n/a") { }

        /*
        public void PrintFullName()
        {
            Console.WriteLine($"{_firstName} {_lastName}");
        }
        */

        public void PrintFullName() =>
            Console.WriteLine($"{_lastName} {_firstName}");

        /*
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
        */
        public string GetFullName() => _firstName + " " + _lastName;
    }
}