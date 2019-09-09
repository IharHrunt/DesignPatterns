using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component.Name, component)
        {}

        public override string Operation()
        {
            return $"{component.Operation()} + ConcreteDecoratorB";
        }
    }
}
