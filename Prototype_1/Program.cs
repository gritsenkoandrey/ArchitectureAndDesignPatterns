using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentReader reader = new DocumentReader(new Uri("https://yandex.ru"));
            Console.WriteLine($"Word position {reader.FindWord("Погода")}");

            DocumentReader readerClone = reader.Clone() as DocumentReader;
            Console.WriteLine($"Word position {reader.FindWord("Пробки")}");

            Console.ReadLine();
        }
    }
}