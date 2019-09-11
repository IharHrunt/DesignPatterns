using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Target adapter = new Adapter();
            client.Request(adapter);

            Console.ReadKey();
        }
    }
}
