using System;

namespace StructSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(100, 150);
            Console.WriteLine($"X={p.X}, Y={p.Y}");
            int x = p["X"];
            int y = p["Y"];
            Console.WriteLine($"X={x}, Y={y}");
            p.Print();
        }
    }
}
