using System;


namespace Lazy_Initialization_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.PrintItem();
            client.UseItem();

            Console.ReadLine();
        }
    }
}