using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_2
{
    class ConcreteCreatorB : ICreator
    {
        public Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}