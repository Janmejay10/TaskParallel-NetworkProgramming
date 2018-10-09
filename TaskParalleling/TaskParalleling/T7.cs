using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParalleling
{
    class T7
    {

        static void Main(string[] args)
        {  

            Parallel.For(0, 100, (i) => Console.WriteLine(i + ","));
            Parallel.For(0, 100, (i) => Console.WriteLine(i + ","));

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        static void DoWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} DoWork is begining...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} DoWork is completed...", id);
        }

        static void DoOtherWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} DoOtherWork is begining...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} DoOtherWork is completed...", id);
        }
    }
}
