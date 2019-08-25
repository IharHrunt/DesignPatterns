using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ConcretePrototypeA : AbstractPrototype
    {
        public ConcretePrototypeA(int id) 
            : base(id)
        {}

        public override AbstractPrototype Clone()
        {
            return new ConcretePrototypeA(Id);
        }
    }
}
