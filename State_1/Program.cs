using System;


namespace State_1
{
    public class Program
    {
        public class Context
        {
            public IState State { get; set; } = null;
        }

        public class StartState : IState
        {
            public void DoAction(Context context)
            {
                Console.WriteLine("Игрок на старте");
                context.State = this;
            }

            public override string ToString() => "Старт";
        }

        public class StopState : IState
        {
            public void DoAction(Context context)
            {
                Console.WriteLine("Игрок на финише");
                context.State = this;
            }
            public override string ToString() => "Финиш";
        }

        static void Main(string[] args)
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.State.ToString());

            StopState stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.State.ToString());

            Console.ReadLine();
        }
    }
}