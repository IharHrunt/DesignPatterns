using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component.Name, component)
        {}

        public override string Operation()
        {
            return $"{component.Operation()} + ConcreteDecoratorA";
        }
    }
}
