using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adaptee
    {
        public void CustomRequest()
        {
            Console.WriteLine("Custom Request");
        }
    }
}
