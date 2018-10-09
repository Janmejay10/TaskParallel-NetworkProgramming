using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParalleling
{
    class T11
    {
        static void Test()
        {
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
            Console.WriteLine("[INTERMEDIATE]");
            Parallel.Invoke(Test, Test2, Test3);
        }
    }
}
