using System;
using System.Collections.Generic;

namespace CSharpDemo
{
    class Student
    {
        private int id;
        public int passMark;

        /*
        private string _name;

        public string Name
        {
            set => _name = value;
            get => _name;
        }
        */

        public string Name { get; set; }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("id cannot be negative");
                }
                id = value;
            }

            get => id;
        }

        public void SomeMethod()
        {
            Name = "Lucy";
        }

        public void SomeMethod2()
        {
            Console.WriteLine("private name = " + Name);
        }

        /*
        public void SetId(int newId)
        {
            if (newId <= 0)
            {
                throw new Exception("id cannot be negative");
            }

            id = newId;
        }
        
        public int GetId()
        {
            return id;
        }
        */
    }


    class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Area { get; set; }
    }

    class Rectangle : Shape
    {
        public Rectangle(int w, int h)
        {
            Height = h;
            Width = w;
            Area = h * w;
        }
    }

    class Square : Shape
    {
        public Square(int side)
        {
            Height = side;
            Width = side;
            Area = side * side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Shape r = new Rectangle(40, 30);
            Console.WriteLine("area = " + r.Area);

            Shape s = new Square(30);
            Console.WriteLine("area square = " + s.Area);
            */

            List<Shape> list = new List<Shape>();

            Shape sh1 = new Rectangle(5, 7);
            list.Add( sh1 );

            Shape sh2 = new Square(7);
            list.Add( sh2 );

            // r.



            Student s1 = new Student();

            // s1.id = -101;
            // s1.SetId(101);
            // Console.WriteLine(s1.GetId());

            // s1.name = null;

            // s1.Name = null;
            // s1.Name = "Lucy";
            // Console.WriteLine("students name is " +  s1.Name);

            s1.Name = "Mary";



            s1.passMark = 0;
        }
    }
}
