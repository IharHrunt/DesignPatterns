using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.FactoryMethod
{
    public class ConcreteProductB : AbstractProduct
    {
        public ConcreteProductB()
        {
            Console.WriteLine("ConcreteProductB is ready");
        }
    }
}
