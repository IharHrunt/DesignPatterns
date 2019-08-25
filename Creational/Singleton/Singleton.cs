using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        public static Singleton instance;
        private static readonly object locker = new object();

        public string Date { get; private set; }        

        private Singleton()
        {
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock(locker)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }
}
