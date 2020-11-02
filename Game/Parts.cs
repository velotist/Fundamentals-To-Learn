using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    struct Rectangle
    {
        public Rectangle(int width, int length)
        {
            this.Width = width;
            this.Length = length;
        }

        public int Width { get; }

        public int Length { get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(100,200);

            Console.WriteLine("Width: {0}", rectangle.Width);
            Console.WriteLine("Length: {0}", rectangle.Length);

            Console.ReadLine();
        }
    }
}