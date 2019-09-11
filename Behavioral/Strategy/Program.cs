using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IConnection connection;
            Context context;
            string connectionString;

            connection = new Connection1();
            context = new Context(connection);
            connectionString = context.GetConnectionString();
            Console.WriteLine(connectionString);

            connection = new Connection1();
            context = new Context(connection);
            connectionString = context.GetConnectionString();
            Console.WriteLine(connectionString);

            Console.ReadKey();
        }
    }
}
