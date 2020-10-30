using System;
using System.Diagnostics.CodeAnalysis;

namespace InterfaceExercises
{
    interface IDoSomething
    {
        public int Age { get; set; }
        public string Name { get; set; }

        string GetName();
        int GetAge();
        int Multiply(int a, int b);
        void Print();
    }

    class Program
    {
        static void Main(string[] args)
        {
            DoIt defaultType = new DoIt();

            Console.WriteLine(defaultType.Age);
            Console.WriteLine(defaultType.GetName());
            Console.WriteLine(defaultType.GetAge());
            Console.WriteLine(defaultType.Multiply(3,4));

            DoIt ageIs48 = new DoIt
            {
                Age = 48
            };
            Console.WriteLine(defaultType.Equals(ageIs48));

            Console.ReadKey();
        }
    }

    class DoIt : IDoSomething, IEquatable<DoIt>
    {
        public int Age { get; set; } = 1;
        public string Name { get; set; } = "noname";

        public bool Equals([AllowNull] DoIt other)
        {
            return (this.Age, this.Name) == (other.Age, other.Name);
        }

        public int GetAge()
        {
            Console.WriteLine("Your age? ");
            var isInt = int.TryParse(Console.ReadLine(), result: out int age);
            Age = age;
            if (isInt)
                return Age;

            return 0;
        }

        public string GetName()
        {
            Console.WriteLine("Your name? ");
            var Name = Console.ReadLine();

            return Name;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public void Print()
        {
            Console.WriteLine(Age);
        }
    }
}