using InterfaceExercises;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DoSomething
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DoIt defaultType = new DoIt();

            Console.WriteLine(defaultType.Age);
            Console.WriteLine(defaultType.GetName());
            Console.WriteLine(defaultType.GetAge());
            Console.WriteLine(defaultType.Multiply(3, 4));

            DoIt ageIs48 = new DoIt
            {
                Age = 48
            };
            Console.WriteLine(defaultType.Equals(ageIs48));

            Console.ReadKey();
        }
    }

    internal class DoIt : IDoSomething, IEquatable<DoIt>
    {
        public int Age { get; set; } = 1;
        public string Name { get; set; } = "noname";

        public bool Equals([AllowNull] DoIt other)
        {
            return (Age, Name) == (other.Age, other.Name);
        }

        public int GetAge()
        {
            Console.WriteLine("Your age? ");
            bool isInt = int.TryParse(Console.ReadLine(), result: out int age);
            Age = age;
            if (isInt)
            {
                return Age;
            }

            return 0;
        }

        public string GetName()
        {
            Console.WriteLine("Your name? ");
            string Name = Console.ReadLine();

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
