using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteFactoryB : AbstractFactory
    {
        public override AbstractProduct FactoryMethod()
        {            
            return new ConcreteProductB();
        }
    }
}
