using System;


namespace Visitor_1
{

    public class Engine : ICarPart
    {
        public void Accept(ICarPartVisitor CarPartVisitor)
        {
            CarPartVisitor.Visit(this);
        }
    }

    public class Suspension : ICarPart
    {
        public void Accept(ICarPartVisitor CarPartVisitor)
        {
            CarPartVisitor.Visit(this);
        }
    }

    public class Body : ICarPart
    {
        public void Accept(ICarPartVisitor CarPartVisitor)
        {
            CarPartVisitor.Visit(this);
        }
    }

    public class Car : ICarPart
    {
        ICarPart[] parts;

        public Car()
        {
            parts = new ICarPart[] { new Engine(), new Suspension(), new Body() };
        }

        public void Accept(ICarPartVisitor CarPartVisitor)
        {
            foreach (var part in parts)
            {
                part.Accept(CarPartVisitor);
            }
            CarPartVisitor.Visit(this);
        }
    }

    public class CarPartDisplayVisitor : ICarPartVisitor
    {
        public void Visit(Car Car)
        {
            Console.WriteLine("Автомобиль.");
        }
        public void Visit(Engine engine)
        {
            Console.WriteLine("Двигатель.");
        }
        public void Visit(Suspension suspension)
        {
            Console.WriteLine("Подвеска.");
        }
        public void Visit(Body body)
        {
            Console.WriteLine("Кузов.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Accept(new CarPartDisplayVisitor());

            Console.ReadLine();
        }
    }
}