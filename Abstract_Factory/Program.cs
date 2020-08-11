using System;
using System.Reflection;


namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarFactory carFactory = new CarFactory();
            ICarFactory carFactory = LoadFactory();

            ICar[] cars = {
                carFactory.CreateInstance("Bus", "275", "100", "1000"),
                carFactory.CreateInstance("Truck", "100", "50", "750"),
                carFactory.CreateInstance("Motobike", "75", "150", "1250") };

            foreach (var item in cars)
            {
                Console.WriteLine($"Автомобиль: {item.GetType()}, {item}");
            }

            Console.ReadLine();
        }

        //Здесь происходит чтение настроек проекта и создание фабрики по ее названию.
        //В реальном проекте вместо чтения файла настроек используется внедрение
        //зависимостей (dependency injection), но эта технология будет рассмотрена на последующих занятиях.
        private static ICarFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.DefaultCarFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as ICarFactory;
        }
    }
}