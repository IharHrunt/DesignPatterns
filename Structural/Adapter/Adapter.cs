using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter : Target
    {   
        public override void Request()
        {
            new Adaptee().AdapteeRequest();
        }
    }
}
