using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.FactoryMethod
{
    public class ConcreteFactoryA : AbstractFactory
    {
        public override AbstractProduct FactoryMethod()
        {   
            return new ConcreteProductA();
        }
    }
}
