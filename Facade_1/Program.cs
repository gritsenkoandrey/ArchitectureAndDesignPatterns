using System;


namespace Facade_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var computer = new ComputerFacade(new Computer());
            computer.TurnOn();
            computer.TurnOff();

            Console.ReadLine();
        }
    }
}