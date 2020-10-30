using System;

namespace InterfaceExercises
{
    interface IDoSomething
    {
        string GetName();
        int GetAge();
        void Print();
    }

    class Program
    {
        static void Main(string[] args)
        {
            DoIt ageIs37 = new DoIt
            {
                Age = 37
            };

            ageIs37.Print();
            Console.WriteLine(ageIs37.GetName());
            Console.WriteLine(ageIs37.GetAge());
            Console.ReadKey();
        }
    }

    class DoIt : IDoSomething
    {
        public int Age { get; set; }
        public string Name { get; set; }

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

        public void Print()
        {
            Console.WriteLine(Age);
        }
    }
}