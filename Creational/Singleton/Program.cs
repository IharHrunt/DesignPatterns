using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj;

            obj = Singleton.GetInstance();
            Console.WriteLine(obj.Date);

            Thread.Sleep(3000);

            obj = Singleton.GetInstance();
            Console.WriteLine(obj.Date);

            Console.ReadKey();
        }
    }
}
