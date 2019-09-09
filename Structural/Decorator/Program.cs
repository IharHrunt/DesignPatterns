using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent("Start");
            Console.WriteLine(component.Operation());

            component = new ConcreteDecoratorA(component);
            Console.WriteLine(component.Operation());

            component = new ConcreteDecoratorB(component);
            Console.WriteLine(component.Operation());

            Console.ReadLine();
        }
    }
}
