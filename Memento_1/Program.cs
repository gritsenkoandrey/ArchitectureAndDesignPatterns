using System;


namespace Memento_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            originator.State = "State 1";
            careTaker.Add(originator.SaveStateToMomento());

            originator.State = "State 2";
            careTaker.Add(originator.SaveStateToMomento());

            originator.State = "State 3";
            careTaker.Add(originator.SaveStateToMomento());

            originator.State = "State 4";
            Console.WriteLine("Текущее состояние: " + originator.State);

            originator.GetStateFromMemento(careTaker.Get(0));
            Console.WriteLine("Первое состояние: " + originator.State);

            originator.GetStateFromMemento(careTaker.Get(1));
            Console.WriteLine("Второе состояние: " + originator.State);

            originator.GetStateFromMemento(careTaker.Get(2));
            Console.WriteLine("Третье состояние: " + originator.State);

            Console.ReadLine();
        }
    }
}