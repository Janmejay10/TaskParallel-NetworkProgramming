using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TaskParalleling
{
    class T3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i =" + i);
                Thread.Sleep(1000);
            }

            );
        }
    }
}
