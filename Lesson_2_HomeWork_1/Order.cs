using System;

namespace Lesson_2_HomeWork_1
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            Name = $"New Order {OrderId}";
        }

        public override string ToString()
        {
            return $"{OrderId} - {Name}";
        }
    }
}