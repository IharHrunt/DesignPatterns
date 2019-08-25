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
            Creator creator;
            Product product;

            creator = new CreatorA();
            product = creator.FactoryMethod();

            creator = new CreatorB();
            product = creator.FactoryMethod();

            Console.ReadKey();
        }
    }
}
