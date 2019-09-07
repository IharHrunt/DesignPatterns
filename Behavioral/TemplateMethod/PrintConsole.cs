using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class PrintConsole : PrintTemplate
    {
        public override void PrintBody()
        {
            Console.WriteLine("Print Body");
        }

        public override void PrintFooter()
        {
            Console.WriteLine("Print Footer");
        }

        public override void PrintTitle()
        {
            Console.WriteLine("Print Title");
        }
    }
}
