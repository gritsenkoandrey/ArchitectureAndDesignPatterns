using System;


namespace Lesson_2_HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(1);
            Order order2 = new Order(2);

            OrderAPI orderAPI = new OrderAPI();
            OrderRepository orderRep = new OrderRepository();

            orderAPI.Load(order1.OrderId);
            orderAPI.Save(order1);
            orderAPI.Delete(order1);
            orderAPI.Update(order1);

            orderRep.Load(order2.OrderId);
            orderRep.Save(order2);
            orderRep.Delete(order2);
            orderRep.Update(order2);

            Console.ReadLine();
        }
    }
}