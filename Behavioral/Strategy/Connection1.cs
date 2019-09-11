using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Connection1 : IConnection
    {
        public string GetConnectionString()
        {
            return "Connection string to Database #1";
        }
    }
}
