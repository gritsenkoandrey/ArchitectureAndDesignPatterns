using System;


namespace Lesson_7_HomeWork_1
{
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }

    public class ShippingUPS : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            Console.WriteLine("UPS");
            return 4;
        }
    }

    public class ShippingFedEx : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            Console.WriteLine("FedEx");
            return 5;
        }
    }

    public class ShippingEMS : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            Console.WriteLine("EMS");
            return 3;
        }
    }

    public class Address
    {
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }

    public class Order
    {
        public IShippingStrategy ShippingStrategy { get; set; }
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.ShippingStrategy = new ShippingEMS();
            order.ShippingStrategy.Calculate(order);

            order.ShippingStrategy = new ShippingFedEx();
            order.ShippingStrategy.Calculate(order);

            order.ShippingStrategy = new ShippingUPS();
            order.ShippingStrategy.Calculate(order);

            Console.ReadLine();
        }
    }
}