using System;
using System.Collections.Generic;
using System.Reflection;


namespace Abstract_Factory
{
    public class CarFactory : ICarFactory
    {
        Dictionary<string, Type> cars;

        public CarFactory()
        {
            LoadTypes();
        }

        //Использование рефлексии для устранения недостатков шаблона «Фабрика»
        //В методе LoadTypes с помощью Assembly.GetExecutingAssembly().GetTypes()
        //извлекается список всех типов, используемых в приложении.Затем происходит
        //проверка соответствия типов интерфейсу ICar. И типы, соответствующие
        //данному интерфейсу, помещаются в словарь cars. Добавление нового типа
        //порожденных объектов, при таком подходе к реализации шаблона «Фабрика»,
        //не требует внесения изменений в класс «Фабрика».
        private void LoadTypes()
        {
            cars = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in typesInThisAssembly)
            {
                if (type.GetInterface(nameof(ICar).ToString()) != null)
                {
                    cars.Add(type.Name, type);
                }
            }
        }

        private Type GetTypeToCreate(string typeCar)
        {
            foreach (var car in cars)
            {
                if (car.Key.Contains(typeCar))
                {
                    return cars[car.Key];
                }
            }
            return null;
        }

        public ICar CreateInstance(string description, 
            string wheelsSize, string engineCapacity, string engineTorque)
        {
            Type type = GetTypeToCreate(description);
            if (type == null)
            {
                return new UnknownCar();
            }

            return Activator.CreateInstance(type, wheelsSize, engineCapacity, engineTorque) as ICar;
        }

        // Factory
        //public static ICar GetCar(string type, string wheelsSize, string engineCapacity, string engineTorque)
        //{
        //    if ("Bus" == type)
        //    {
        //        return new Bus(wheelsSize, engineCapacity, engineTorque);
        //    }
        //    else if ("Truck" == type)
        //    {
        //        return new Truck(wheelsSize, engineCapacity, engineTorque);
        //    }
        //    return null;
        //}
    }
}