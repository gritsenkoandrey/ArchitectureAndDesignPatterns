using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {

        }

        public static ThreadSafeSingleton Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            //Компилятор С# гарантирует позднее (lazy) создание класса Nested
            //с помощью статического конструктора.
            static Nested()
            {

            }

            //Во вложенном (nested) классе есть статический член ThreadSafeSingleton,
            //которому присваивается new ThreadSafeSingleton() при первом обращении к свойству Instance.
            //Последующие обращения к свойству Instance получают один и тот же экземпляр
            //статического члена класса.

            internal static readonly ThreadSafeSingleton instance = new ThreadSafeSingleton();
        }
    }
}