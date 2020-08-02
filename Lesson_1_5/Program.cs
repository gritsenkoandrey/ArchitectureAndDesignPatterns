using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_1_5
{
    class Program
    {
        public static readonly string Address = Constants.Adress;
        public static readonly string Format = Constants.Format;

        private static void DummyFunc()
        {
            WriteToConsole("Петя", "школьный друг", 30);
        }

        private static void DummyFuncAgain()
        {
            WriteToConsole("Вася", "сосед", 54);
        }

        private static void DummyFuncMore()
        {
            WriteToConsole("Николай", "сын", 4);
        }

        private static void WriteToConsole(string name, string description, int age)
        {
            Console.WriteLine(Format, name, description, Address, age);
        }

        private static void MakeAction(Action action)
        {
            string methodName = action.Method.Name;
            Console.WriteLine($"Начало работы метода {methodName}");
            action();
            Console.WriteLine($"Окончание работы метода {methodName}");
        }

        //Реализуем повторяющиеся вызовы в виде коллекции:
        private static List<Action> GetActionSteps()
        {
            return new List<Action>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }

        static void Main(string[] args)
        {
            List<Action> actions = GetActionSteps();
            foreach (var action in actions)
            {
                MakeAction(action);
            }

            //Рефакторинг почти завершен, однако в методе Main по-прежнему остаются схожие фрагменты,
            //а именно, три вызова метода MakeAction. Такой код нарушает принцип DRY.
            //MakeAction(DummyFunc);
            //MakeAction(DummyFuncAgain);
            //MakeAction(DummyFuncMore);

            //Console.WriteLine("Начало работы метода DummyFunc");
            //DummyFunc();
            //Console.WriteLine("Окончание работы метода DummyFunc");
            //Console.WriteLine("Начало работы метода DummyFuncAgain");
            //DummyFuncAgain();
            //Console.WriteLine("Окончание работы метода DummyFuncAgain");
            //Console.WriteLine("Начало работы метода DummyFuncMore");
            //DummyFuncMore();
            //Console.WriteLine("Окончание работы метода DummyFuncMore");

            Console.ReadLine();
        }
    }
}