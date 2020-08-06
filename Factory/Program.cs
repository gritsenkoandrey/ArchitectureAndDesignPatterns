using System;


namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //После реализации шаблона «Фабрика» с помощью рефлексии осталась
            //одна проблема – жесткая связь между клиентским кодом и фабрикой
            //CarFactory carFactory = new CarFactory()
            CarFactory carFactory = new CarFactory();

            ICar[] cars = { 
                carFactory.CreateInstance("Bus", "275", "100", "1000"),
                carFactory.CreateInstance("Truck", "100", "50", "750"),
                carFactory.CreateInstance("Motobike", "75", "150", "1250") };
            
            // Factory без рефлексии
            //ICar[] cars = {
            //    CarFactory.GetCar("Bus", "275", "100", "1000"), 
            //    CarFactory.GetCar("Truck", "100", "50", "750"),
            //    /*CarFactory.GetCar("Motobike", "75", "150", "1250")*/};

            foreach (var item in cars)
            {
                Console.WriteLine($"Автомобиль: {item.GetType()}, {item}");
            }

            Console.ReadLine();
        }
    }
}
