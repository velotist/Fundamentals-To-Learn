using System;
using System.Collections.Generic;

namespace GenericsTesting
{
    internal class Program
    {
        private static readonly List<Person> _allPersons = new List<Person>();

        private static void Main(string[] args)
        {
            Person marcus = new Person
            {
                Name = "Marcus Greiner",
                Age = 49,
                Gender = "male"
            };

            _allPersons.Add(marcus);
            _allPersons.Add(new Person { Name = "Alexander Frank" });
        }

        private void ShowList(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
