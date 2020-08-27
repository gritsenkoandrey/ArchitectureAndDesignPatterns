using System;


namespace Strategy_2
{
    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }

    public class Car
    {
        protected int passengers;
        protected string model;

        public IMovable Movable { private get; set; }

        public Car(int num, string model, IMovable move)
        {
            this.passengers = num;
            this.model = model;
            this.Movable = move;
        }

        public void Move()
        {
            Movable.Move();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, "Toyota", new PetrolMove());
            car.Move();
            car.Movable = new ElectricMove();
            car.Move();

            Console.ReadLine();
        }
    }
}