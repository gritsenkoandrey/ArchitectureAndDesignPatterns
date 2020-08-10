using System;
using System.Threading;


namespace Singleton_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Launch("Windows");
            Console.WriteLine(computer.OS.Name);
            //// у нас не получится изменить ОС, так как объект уже создан
            //computer.Launch("Linux");
            //computer.OS = OS.GetInstance("Linux");
            //Console.WriteLine(computer.OS.Name);

            (new Thread(() =>
            {
                Computer computerThread = new Computer();
                //computerThread.Launch("Mac");
                computerThread.OS = OS.GetInstance("Mac");
                Console.WriteLine(computerThread.OS.Name);
            })).Start();

            //Computer computer = new Computer();
            //computer.Launch("Windows");
            //Console.WriteLine(computer.OS.Name);

            Console.ReadLine();
        }
    }
}