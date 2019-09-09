using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Component
    {
        public string Name { get; protected set; }

        public Component(string name)
        {
            Name = name;
        }

        public abstract string Operation();
    }
}
