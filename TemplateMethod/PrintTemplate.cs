using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class PrintTemplate
    {
        public void Print()
        {
            PrintTitle();
            PrintBody();
            PrintFooter();
        }

        public abstract void PrintTitle();

        public abstract void PrintBody();

        public abstract void PrintFooter();
    }
}
