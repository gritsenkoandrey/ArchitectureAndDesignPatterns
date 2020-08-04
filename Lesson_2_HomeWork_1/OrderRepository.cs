using System;


namespace Lesson_2_HomeWork_1
{
    public class OrderRepository : IOrder
    {
        public Order Load(int orderId)
        {
            Console.WriteLine($"Заказ {orderId} загружен (Repository)");
            return new Order(orderId);
        }

        public void Save(Order order)
        {
            Console.WriteLine($"Заказ {order.OrderId} сохранен (Repository)");
        }

        public void Delete(Order order)
        {
            Console.WriteLine($"Заказ {order.OrderId} удален (Repository)");
        }

        public void Update(Order order)
        {
            Console.WriteLine($"Заказ {order.OrderId} обновлен (Repository)");
        }
    }
}