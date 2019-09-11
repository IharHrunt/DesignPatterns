using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype;
            Prototype clone;

            prototype = new PrototypeA(1);
            Console.WriteLine(prototype.Id);
            clone = prototype.Clone();
            Console.WriteLine(clone.Id);            
            
            prototype = new PrototypeB(2);
            Console.WriteLine(prototype.Id);
            clone = prototype.Clone();
            Console.WriteLine(clone.Id);

            Console.ReadKey();
        }
    }
}
