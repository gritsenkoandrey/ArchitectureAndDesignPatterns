using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_3
{
    //Реализация через класс Lazy<T>
    public class SingletonL
    {
        private static readonly Lazy<SingletonL> lazy = new Lazy<SingletonL>(() => new SingletonL());

        public string Name { get; set; }

        private SingletonL()
        {
            Name = Guid.NewGuid().ToString();
        }

        public static SingletonL GetInstance()
        {
            return lazy.Value;
        }
    }
}