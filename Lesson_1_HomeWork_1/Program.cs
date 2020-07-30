using System;


namespace Lesson_1_HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityBase store = new Store();
            EntityBase customer = new Customer("HomeWork");

            Console.WriteLine(store);
            Console.WriteLine(customer);

            Console.ReadLine();
        }
    }
}