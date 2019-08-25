using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.FabricMethod
{
    public class CreatorB : Creator
    {
        public override Product FactoryMethod()
        {            
            return new ProductB();
        }
    }
}
