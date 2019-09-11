using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Connection2 : IConnection
    {
        public string GetConnectionString()
        {
            return "Connection string to Database #2";
        }
    }
}
