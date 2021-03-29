using System;
using System.Collections.Generic;
using CustomerClassLibrary;

namespace DotNetCore
{
    interface IAnimal
    {
        int Age { set; get; }
        string Species { get; }

        /*
        public void SetAge()
        {
            Console.Write("How old is it? ");
            Age =  Convert.ToInt32( Console.ReadLine() );
        }
        */
        void RequestUniqueCharacteristic();
        string GetDescription();
    }

    public class Lion : IAnimal
    {
        private string _maneColour;
        public int Age { get; set; }
        public string Species { get => "Lion"; }

        public string GetDescription()
        {
            return Species + " " + Age + " " + _maneColour;
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("What colour is its mane? ");
            _maneColour = Console.ReadLine();
        }
    }

    class ABC
    {


        // Java - Project -> packages
        // .Net - Solution -> projects
        // SolutionName
        //               ->  BizzBuzz -> Program
        //                              
        //               -> theZoo    -> Program and classes
        static void Main(string[] args)
        {
            IAnimal l = new Lion();
            // l.SetAge();
            Console.Write("How old is it? ");
            l.Age = Convert.ToInt32(Console.ReadLine());
            l.RequestUniqueCharacteristic();
            
            Console.WriteLine(l.GetDescription());

            List<IAnimal> animals = new List<IAnimal>();

            animals.Add(l);
            animals.Add(l);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetDescription());
            }

            /*
            Customer c1 = new Customer("Mark", "Smith");
            Location l1 = new Location("Main St.123, Winnipeg");

            Console.WriteLine(c1.GetFullName());
            */
            
        }
    }
}
