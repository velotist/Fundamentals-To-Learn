using System;

namespace CreateObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri1 = new Triangle();

            // Only creates a reference of 
            // type Triangle 
            Triangle tri2;

            Console.WriteLine("Area of tri1 is "
                                + tri1.Area());

            // Assigns the reference to tri1 
            tri2 = tri1;

            // Making changes in tri2 
            tri2.side = 5;
            tri2.altitude = 7;

            Console.WriteLine("side = " + tri1.side + " altitude = " + tri1.altitude);

            Console.WriteLine("Area of tri1 is "
                                + tri1.Area());
        }
    }
}