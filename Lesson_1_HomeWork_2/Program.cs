using System;
using System.Collections.Generic;


namespace Lesson_1_HomeWork_2
{
    class Program
    {
        private static readonly string address = Constants.Adress;
        private static readonly string format = Constants.Format;
        private static string DummyFunc() => string.Format(format, "Андрей", "школьный друг", address, 30);
        private static string DummyFuncAgain() => string.Format(format, "Александр", "брат", address, 32);
        private static string DummyFuncMore() => string.Format(format, "Арина", "дочь", address, 2);

        #region Homework

        //delegate void Func();

        //private static void WriteToConsole(string name, string description, int age)
        //{
        //    Console.WriteLine(format, name, description, address, age);
        //}

        //private static void DummyFunc() => WriteToConsole("Андрей", "школьный друг", 30);
        //private static void DummyFuncAgain() => WriteToConsole("Александр", "брат", 32);
        //private static void DummyFuncMore() => WriteToConsole("Арина", "дочь", 2);

        //private static List<Func> GetFuncs()
        //{
        //    return new List<Func>()
        //    {
        //        DummyFunc,
        //        DummyFuncAgain,
        //        DummyFuncMore
        //    };
        //}

        //private static void MakeFunc(Func func)
        //{
        //    string methodName = func.Method.Name;
        //    Console.WriteLine($"Начало работы метода {methodName}");
        //    func();
        //    Console.WriteLine($"Окончание работы метода {methodName}");
        //}

        #endregion

        private static IEnumerable<Func<string>> GetFuncs()
        {
            return new List<Func<string>>()
            {
                DummyFunc,
                DummyFuncAgain,
                DummyFuncMore
            };
        }

        private static void MakeFunc(Func<string> func)
        {
            string methodName = func.Method.Name;
            Console.WriteLine($"Начало работы метода {methodName}");
            Console.WriteLine(func());
            Console.WriteLine($"Окончание работы метода {methodName}");
        }

        private static void Main(string[] args)
        {
            IEnumerable<Func<string>> funcs = GetFuncs();
            foreach (var func in funcs)
            {
                MakeFunc(func);
            }

            Console.ReadLine();
        }
    }
}