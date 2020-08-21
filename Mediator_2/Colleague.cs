using System;


namespace Mediator_2
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }
        public abstract void Notify(string message);
    }

    public class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) : base(mediator)
        {

        }
        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение заказчику: " + message);
        }
    }
    public class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator) : base(mediator)
        { 

        }
        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение программисту: " + message);
        }
    }

    public class TesterColleague : Colleague
    {
        public TesterColleague(Mediator mediator) : base(mediator)
        {
            
        }
        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение тестеру: " + message);
        }
    }
}