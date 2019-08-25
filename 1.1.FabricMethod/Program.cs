using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.FabricMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory;
            Product product;

            factory = new FactoryA();
            product = factory.FactoryMethod();

            factory = new FactoryB();
            product = factory.FactoryMethod();

            Console.ReadKey();
        }
    }
}
