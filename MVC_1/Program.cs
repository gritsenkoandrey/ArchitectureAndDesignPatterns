using MVC_1.Controller;
using MVC_1.Model;
using MVC_1.View;
using System;

namespace MVC_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car model = GetCar();
            CarView view = new CarView();
            CarController controller = new CarController(model, view);
            controller.Updateview();

            controller.CarName = "Lexus";
            controller.Speed = "110";
            controller.Updateview();

            Console.ReadLine();
        }

        private static Car GetCar()
        {
            Car car = new Car();
            car.Name = "Toyota";
            car.Speed = "90";
            return car;
        }
    }
}