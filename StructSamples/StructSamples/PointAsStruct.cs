using System;
using System.Collections.Generic;
using System.Text;

namespace StructSamples
{
    public struct PointAsStruct
    {
        public PointAsStruct(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public void Print()
        {
            Console.WriteLine($"Point (struct) found at X={X}, Y={Y}");
        }
    }

    public class PointAsClass
    {
        public PointAsClass(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public void Print()
        {
            Console.WriteLine($"Point (class) found at X={X}, Y={Y}");
        }
    }
}
