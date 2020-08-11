using System;


namespace Builder_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();

            Console.ReadLine();
        }
    }
}