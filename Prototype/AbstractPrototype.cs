using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class AbstractPrototype
    {
        public int Id { get; private set; }

        public AbstractPrototype(int id)
        {
            Id = id;
        }

        public abstract AbstractPrototype Clone();
    }
}
