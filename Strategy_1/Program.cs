using System;


namespace Strategy_1
{
    public class Address
    {
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }

    public enum ShippingOptions
    {
        UPS = 1,
        FedEx,
        EMS,
    }

    public class Order
    {
        public ShippingOptions ShippingMethod { get; set; }
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }

    public class ShippingCostCalculator
    {
        #region Реализация без использования паттерна - стратегия.
        //public double ShippingCostCalculatorMethod(Order order)
        //{
        //    switch (order.ShippingMethod)
        //    {
        //        case ShippingOptions.FedEx:
        //            return CalculateForFedEx(order);
        //        case ShippingOptions.UPS:
        //            return CalculateForUPS(order);
        //        case ShippingOptions.EMS:
        //            return CalculateForEMS(order);
        //        default:
        //            throw new Exception("Неизвестный сервис");
        //    }
        //}
        //double CalculateForEMS(Order order)
        //{
        //    return 3;
        //}
        //double CalculateForUPS(Order order)
        //{
        //    return 4;
        //}
        //double CalculateForFedEx(Order order)
        //{
        //    return 5;
        //}
        #endregion
        public double Calculate(Order order, Func<Order, double> shippingCostStrategy)
        {
            return shippingCostStrategy(order);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Func<Order, double> emsStrategy = (Order order) => { return 3; };
            Func<Order, double> upsStrategy = (Order order) => { return 4; };
            Func<Order, double> fedexStrategy = (Order order) => { return 5; };

            var cost = new ShippingCostCalculator().Calculate(new Order(), emsStrategy);
        }
    }
}