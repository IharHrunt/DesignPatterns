using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();            
            client.Request(new Target());            
            client.Request(new Adapter());

            Console.ReadKey();
        }
    }
}
