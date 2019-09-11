using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }
}
