using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory;
            AbstractProduct product;

            factory = new ConcreteFactoryA();
            product = factory.FactoryMethod();

            factory = new ConcreteFactoryB();
            product = factory.FactoryMethod();

            Console.ReadKey();
        }
    }
}
