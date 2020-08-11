using System;

namespace Open_Closed_Principle_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client client = new Client() { ClientType = 2 };
            Client client = new SilverPartner();
            double discount = client.GetDiscount(1000);
            client = new GoldenPartner();
            discount = client.GetDiscount(1000);

            Console.ReadLine();
        }
    }
}