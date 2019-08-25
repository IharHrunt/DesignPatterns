using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2.AbstractFactory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
