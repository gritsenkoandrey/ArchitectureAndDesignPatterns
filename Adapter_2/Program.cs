using System;


namespace Adapter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Auto auto = new Auto();
            Camel camel = new Camel();
            // используем адаптер
            ITransport camalTransport = new CamelToTransportAdapter(camel);

            driver.Travel(auto);
            driver.Travel(camalTransport);

            Console.ReadLine();
        }
    }
}