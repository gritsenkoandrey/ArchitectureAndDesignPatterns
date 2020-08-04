using System;


namespace Lesson_2_HomeWork_1
{
    class OrderAPI : IOrder
    {
        public Order Load(int orderId)
        {
            Console.WriteLine($"Заказ {orderId} загружен (API)");
            return new Order(orderId);
        }

        public void Save(Order order)
        {
            Console.WriteLine($"Заказ {order.OrderId} сохранен (API)");
        }

        public void Delete(Order order)
        {
            Console.WriteLine($"Заказ {order.OrderId} удален (API)");
        }

        public void Update(Order order)
        {
            Console.WriteLine($"Заказ {order.OrderId} обновлен (Repository)");
        }
    }
}