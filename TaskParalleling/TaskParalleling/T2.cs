using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParalleling
{
    class T2
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(() => DoWork(1, 2000));
            Task t2 = Task.Factory.StartNew(() => DoWork(2, 2500));
            Task t3 = Task.Factory.StartNew(() => DoWork(3, 1500));
            Console.WriteLine("the show is on");
            Console.Read();
        }

        static void DoWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed...", id);
        }


    }
}
