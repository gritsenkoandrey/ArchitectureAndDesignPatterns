using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Singleton_1
{
    public class SingletonClass
    {
        private static SingletonClass _instance;

        private SingletonClass()
        {

        }

        public static SingletonClass Instance
        {
            get
            {
                if (_instance == null) _instance = new SingletonClass();
                return _instance;
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}