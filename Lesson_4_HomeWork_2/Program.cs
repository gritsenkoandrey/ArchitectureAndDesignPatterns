using System;


namespace Lesson_4_HomeWork_2
{
    public class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> _instance =
            new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy()
        {

        }

        public SingletonLazy GetInstance()
        {
            return _instance.Value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}