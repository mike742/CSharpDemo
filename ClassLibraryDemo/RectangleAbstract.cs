using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public class RectangleAbstract : ShapeAbstract
    {
        public RectangleAbstract(int height, int width)
        {
            Height = height;
            Width = width;
            Area = height * width;
        }

        public override void Info() // can be new
        {
            Console.WriteLine("This is a Rectangle");
        }

        public void RectangleMethod()
        {
            Console.WriteLine("RectangleMethod()");
        }

    }
}
