using System;


namespace Command_1
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public void Buy()
        {
            Console.WriteLine($"Товар [ название: { Name}, количество: { Quantity} ] куплено");
        }

        public void Sell()
        {
            Console.WriteLine($"Товар [ название: { Name}, количество: { Quantity} ] продано");
        }
    }
}