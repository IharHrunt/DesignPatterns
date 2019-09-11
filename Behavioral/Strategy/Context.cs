using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Context
    {
        private IConnection _connection;

        public Context(IConnection connection)
        {
            _connection = connection;
        }

        public string GetConnectionString()
        {
            return _connection.GetConnectionString();
        }
    }
}
