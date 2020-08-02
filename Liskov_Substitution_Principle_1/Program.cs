using System;
using System.Collections.Generic;


namespace Liskov_Substitution_Principle_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<AbstractAnimal>() { new Dog(), new Fish() };
            //foreach (var animal in list)
            //{
            //    var legsCount = animal.LegsCount;
            //}

            var list = new List<ILegs>() { new Dog()/*, new Fish()*/ };
            foreach (var animal in list)
            {
                var legsCount = animal.LegsCount;
                Console.WriteLine(legsCount);
            }

            Console.ReadLine();
        }
    }
}