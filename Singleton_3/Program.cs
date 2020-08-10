using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //(new Thread(() =>
            //{
            //    Singleton singleton1 = Singleton.GetInstance();
            //    Console.WriteLine(singleton1.Date);
            //})).Start();

            //Singleton singleton2 = Singleton.GetInstance();
            //Console.WriteLine(singleton2.Date);

            Console.WriteLine($"Main {DateTime.Now.TimeOfDay}");
            Console.WriteLine(Singleton.text);

            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.Date);

            Console.ReadLine();
        }
    }
}