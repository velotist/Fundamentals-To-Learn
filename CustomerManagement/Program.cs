using System;
using InterfaceExercises;

namespace CustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Marcus";
            Console.WriteLine(customer.Name);
            customer.DeleteName(customer.Name);
            Console.WriteLine(customer.Name);
        }
    }

    class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void DeleteName(string name)
        {
            this.Name = string.Empty;
            Console.WriteLine("Deleted...");
        }
    }
}