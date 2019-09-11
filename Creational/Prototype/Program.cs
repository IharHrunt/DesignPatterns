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

            prototype = new PrototypeA(1, "Ihar");
            Console.WriteLine($"prototype: Id = {prototype.Id}, Name = {prototype.Name}");
            clone = prototype.Clone();
            Console.WriteLine($"clone: Id = {clone.Id}, Name = {clone.Name}");

            prototype = new PrototypeB(2, "Alla");
            Console.WriteLine($"prototype: Id = {prototype.Id}, Name = {prototype.Name}");
            clone = prototype.Clone();
            Console.WriteLine($"clone: Id = {clone.Id}, Name = {clone.Name}");

            Console.ReadKey();
        }
    }
}
