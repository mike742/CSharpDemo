﻿using System;
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

        public void Info()
        {
            Console.WriteLine("base: This is a shape");
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int w, int h)
        {
            Height = h;
            Width = w;
            Area = h * w;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine("This is a Rectangle");
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

    class ShapeVirtual
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Area { get; set; }

        public virtual void Info()
        {
            Console.WriteLine("base: This is a shapeVirtual");
        }
    }

    class RectangleVirtual : ShapeVirtual
    {
        public RectangleVirtual(int w, int h)
        {
            Height = h;
            Width = w;
            Area = h * w;
        }

        public override void Info()
        {
            // base.Info();
            Console.WriteLine("This is a RectangleVirtual");
        }
    }


    public abstract class ShapeAbstract
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Area { get; set; }

        public abstract void Info();
    }

    class RectangleAbstract : ShapeAbstract
    {
        public RectangleAbstract(int w, int h)
        {
            Height = h;
            Width = w;
            Area = h * w;
        }

        public override void Info()
        {
            throw new NotImplementedException();
        }
    }

    interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }

    interface IFaxContent
    {
        bool FaxContent(string content);
    }

    interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }

    class HPLaserJet : IPrintScanContent, IFaxContent, IPrintDuplex
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax done");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy done");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print done");
            return true;
        }

        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("PrintDuplex done");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan done");
            return true;
        }
    }

    class CannonMG2470 : IPrintScanContent
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy done");
            return true;
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }


    interface IHumanCashier
    {
        void StartShift();
        void TakeBreak();
        void CompleteShift();
        void DispaseChange();
    }


    interface ICashier
    {
        void ScanItem();
        void TakePayment();
    }
    class SeflServeMachine : ICashier
    {
        public void ScanItem()
        {
            throw new NotImplementedException();
        }

        public void TakePayment()
        {
            throw new NotImplementedException();
        }
    }

    class HumanCachier : ICashier, IHumanCashier
    {
        public void CompleteShift()
        {
            throw new NotImplementedException();
        }

        public void DispaseChange()
        {
            throw new NotImplementedException();
        }

        public void ScanItem()
        {
            throw new NotImplementedException();
        }

        public void StartShift()
        {
            throw new NotImplementedException();
        }

        public void TakeBreak()
        {
            throw new NotImplementedException();
        }

        public void TakePayment()
        {
            throw new NotImplementedException();
        }
    }

    interface IAnimal
    {
        // private int _age;
        public int Age { set; get; }
        public string Species { set; get; }
        string GetDescription();
        void RequestUniqueCharacteristic();
    }

    class Program
    {
        static void Main(string[] args)
        {


            ShapeAbstract sha = new RectangleAbstract(77, 99);

            ShapeVirtual shv = new RectangleVirtual(77, 88);
            shv.Info();

            Shape r = new Rectangle(40, 30);
            Console.WriteLine("area = " + r.Area);
            r.Info();


            /*
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
