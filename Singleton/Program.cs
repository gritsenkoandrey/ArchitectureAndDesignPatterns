using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            SingletonClass singletonOne = SingletonClass.Instance;
            singletonOne.ShowMessage();
            SingletonClass singletonTwo = SingletonClass.Instance;
            DoWork(singletonTwo);

            // потокобезопасная реализация
            (new Thread(() =>
            {
                ThreadSafeSingleton instanceOne = ThreadSafeSingleton.Instance;
            }
            )).Start();
            ThreadSafeSingleton instanceTwo = ThreadSafeSingleton.Instance;


            Console.ReadLine();
        }

        private static void DoWork(SingletonClass singleton)
        {
            singleton.ShowMessage();
        }
    }
}