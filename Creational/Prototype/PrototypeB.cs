using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PrototypeB : Prototype
    {
        public PrototypeB(int id, string name) 
            : base(id, name)
        {}

        public override Prototype Clone()
        {
            return new PrototypeB(Id, Name);
        }
    }
}
