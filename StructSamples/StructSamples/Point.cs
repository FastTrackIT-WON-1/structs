using System;

namespace StructSamples
{
    public struct Point
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; }

        public int Y { get; }

        public int this[string axis]
        {
            get
            {
                if (string.Equals(axis, "X", StringComparison.OrdinalIgnoreCase))
                {
                    return this.X;
                }
                else if (string.Equals(axis, "Y", StringComparison.OrdinalIgnoreCase))
                {
                    return this.Y;
                }

                return 0;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Point found at X={X}, Y={Y}");
        }
    }
}
