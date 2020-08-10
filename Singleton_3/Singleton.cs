using System;
using System.Threading;


// Потокобезопасная реализация без использования lock
namespace Singleton_3
{
    public class Singleton
    {
        //private static readonly Singleton _instance = new Singleton();
        public static string text = "hello";
        
        public string Date { get; private set; }

        private Singleton()
        {
            Console.WriteLine($"Singleton ctor {DateTime.Now.TimeOfDay}");
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static Singleton GetInstance()
        {
            Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
            Thread.Sleep(500);
            return Nested.instance;
            //return _instance;
        }

        // Lazy initialization
        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}