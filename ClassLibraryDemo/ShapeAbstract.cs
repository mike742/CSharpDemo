using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryDemo
{
    public abstract class ShapeAbstract
    {
        public int Height { set; get; }
        public int Width { set; get; }
        public double Area { set; get; }

        public abstract void Info();
    }
}
