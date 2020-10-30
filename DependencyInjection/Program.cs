using System;

namespace DependencyInjection
{
    public interface Text
    {
        void Print();
    }

    class Format : Text
    {
        public void Print()
        {
            Console.WriteLine(" here is text format");
        }
    }

    // constructor injection
    public class ConstructorInjection
    {
        private Text _text;
        public ConstructorInjection(Text t1) => this._text = t1;
        public void print() => _text.Print();
    }

    class Constructor
    {
        static void Main(string[] args)
        {
            ConstructorInjection cs = new ConstructorInjection(new Format());
            cs.print();
            Console.ReadKey();
        }
    }
}