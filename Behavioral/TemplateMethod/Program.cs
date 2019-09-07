using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTemplate console = new PrintConsole();
            console.Print();

            Console.ReadKey();
        }
    }
}
