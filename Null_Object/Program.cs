using System;


namespace Null_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = AnimalFactory.GetAnimal("Лев");
            var animal2 = AnimalFactory.GetAnimal("Заяц");
            var animal3 = AnimalFactory.GetAnimal("Слон");
            var animal4 = AnimalFactory.GetAnimal("Бегемот");

            Console.WriteLine("Животные");
            Console.WriteLine(animal1.GetName());
            Console.WriteLine(animal2.GetName());
            Console.WriteLine(animal3.GetName());
            Console.WriteLine(animal4.GetName());

            Console.ReadLine();
        }
    }
}