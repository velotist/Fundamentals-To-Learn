using InterfaceExercises;
using System;

namespace CustomerManagement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Name = "Marcus"
            };
            Console.WriteLine(customer.Name);
            customer.DeleteName(customer.Name);
            Console.WriteLine(customer.Name);
        }
    }

    internal class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void DeleteName(string name)
        {
            Name = string.Empty;
            Console.WriteLine("Deleted...");
        }
    }
}