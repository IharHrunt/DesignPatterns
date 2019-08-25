using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.FactoryMethod
{
    public class ConcreteProductA : AbstractProduct
    {
        public ConcreteProductA()
        {
            Console.WriteLine("ConcreteProductA is ready");
        }
    }
}
