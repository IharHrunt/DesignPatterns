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
            Factory creator;
            Product product;

            creator = new FactoryA();
            product = creator.FactoryMethod();

            creator = new FactoryB();
            product = creator.FactoryMethod();

            Console.ReadKey();
        }
    }
}
