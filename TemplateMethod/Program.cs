using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Template console = new PrintConsole();
            console.Print();

            Console.ReadKey();
        }
    }
}
