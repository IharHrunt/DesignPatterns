using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractFactory factory;
            AbstractProduct productA;
            AbstractProduct productB;

            factory = new ConcreteFactory1();
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();

            factory = new ConcreteFactory2();
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();

            Console.ReadKey();
        }
    }
}
