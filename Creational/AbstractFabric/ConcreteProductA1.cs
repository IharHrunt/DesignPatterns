using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteProductA1 : AbstractProductA
    {
        public ConcreteProductA1()
        {
            Console.WriteLine("ConcreteProductA1 is ready");
        }
    }
}
