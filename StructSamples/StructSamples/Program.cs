using System;

namespace StructSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            PointStackOnly p = new PointStackOnly(100, 100);
            // Compiler error: boxing not allowed!!!
            // object obj = p;
        }

        private static void BoxingAndUnboxingStructs()
        {
            Point p = new Point(100, 100);
            // boxing
            object obj = p;
            // unboxing
            Point p2 = (Point)obj;
            p2.Print();

            // still boxing
            IMovableObject mo = p.Move(50, 50);
            // still unboxing
            Point p3 = (Point)mo;
            p3.Print();
        }

        private static void PointStructVsClass()
        {
            PointAsStruct ps1 = new PointAsStruct(100, 200);
            PointAsStruct ps2 = ps1;
            ps2.X = 200;
            ps2.Y = 300;
            ps1.Print(); // Point (struct) found at X=100, Y=200
            ps2.Print(); // Point (struct) found at X=200, Y=300

            // ---------------------- vs ----------------------

            PointAsClass pc1 = new PointAsClass(100, 200);
            PointAsClass pc2 = pc1;
            pc2.X = 200;
            pc2.Y = 300;
            pc1.Print(); // Point(class) found at X=200, Y=300
            pc2.Print(); // Point(class) found at X=200, Y=300
        }
    }
}
