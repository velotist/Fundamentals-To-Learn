using ForeachChallenge;
using System;
using System.Collections.Generic;

namespace TimCorey.ForeachChallenge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Marcus",
                "Tanja",
                "Helen",
                "Max"
            };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            List<Person> persons = new List<Person>
            {
                new Person {Firstname= "Marcus", Lastname="Greiner"},
                new Person {Firstname= "Tanja", Lastname="Fritsch"},
                new Person {Firstname= "Helen", Lastname="Mouse"},
                new Person {Firstname= "Max", Lastname="Lamm"}
            };

            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Firstname} {person.Lastname}");
            }

            Console.ReadLine();
        }
    }
}
