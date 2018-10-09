using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParalleling
{
    class T10
    {
        static void Test()
        {
            // This method always finishes last, because the methods are run in parallel.
            // ... And this one has some computations in it that slow it down.
            for (int i = 0; i < 1000000; i++)
            {
                double value = Math.Sqrt(i);
                if (value == -1)
                {
                    return;
                }
            }
            Console.WriteLine("Test");
        }

        static void Test2()
        {
            Console.WriteLine("Test2");
        }

        static void Test3()
        {
            Console.WriteLine("Test3");
        }

        static void Main()
        {
            Parallel.Invoke(Test, Test2, Test3);
        }
    }
}
