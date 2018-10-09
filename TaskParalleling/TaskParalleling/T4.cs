using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParalleling
{
    class T4
    {
        static void Main(string[] args)
        {

            Thread o1 = new Thread(RUnMillioniterations);
            o1.Start();
            Parallel.For(0, 1000000, x => RUnMillioniterations());
        }
        private static void RUnMillioniterations()
        {
            string x = "";
            for (int iIndex = 0; iIndex < 1000000; iIndex++)
            {
                x = x + "s";
            }
        }
    }
}
