using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PrototypeA : Prototype
    {
        public PrototypeA(int id) 
            : base(id)
        {}

        public override Prototype Clone()
        {
            return new PrototypeA(Id);
        }
    }
}
