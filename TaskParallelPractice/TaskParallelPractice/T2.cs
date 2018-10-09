using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelPractice
{
    class T2
    {
        static void HelloConsole()
        {
            Console.WriteLine("Good Morning to all");
        }

        static void Main(string[] args)
        {
            Task.Factory.StartNew(() =>
             {
                 HelloConsole();
             });
            Task.Factory.StartNew(() =>
            {
                HelloConsole();
            });
            Task.Factory.StartNew(() =>
            {
                HelloConsole();
            });

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
    }
}
