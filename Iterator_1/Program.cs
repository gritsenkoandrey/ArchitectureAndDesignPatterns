using System;


namespace Iterator_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var collection = new ItemCollection<Item>
            {
                new Item {Name = "Элемент 0"},
                new Item {Name = "Элемент 1"},
                new Item {Name = "Элемент 2"},
                new Item {Name = "Элемент 3"},
                new Item {Name = "Элемент 4"},
                new Item {Name = "Элемент 5"}
            };

            Console.WriteLine("От начала к концу");
            foreach (var item in collection)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\nОт конца к началу");
            foreach (var item in collection.BackToFront)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\nОт 1 до 5 с шагом 2");
            foreach (var item in collection.FromToStep(1, 5, 2))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}