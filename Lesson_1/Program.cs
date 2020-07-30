using System;


namespace Lesson_1_1
{
    class Program
    {
        private static readonly string _address = Constants.Adress;
        private static readonly string _format = Constants.Format;

        private static void Main(string[] args)
        {
            DummyFunc();
            DummyFuncAgain();
            DummyFuncMore();

            Console.ReadLine();
        }

        private static void WriteToConsole(string name, string discription, int age)
        {
            Console.WriteLine(_format, name, discription, _address, age);
        }

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
    }
}