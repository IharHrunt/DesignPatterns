using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public ConcreteComponent(string name) : base (name)
        {}

        public override string Operation()
        {
            return $"{Name} + ConcreteComponent";
        }
    }
}
