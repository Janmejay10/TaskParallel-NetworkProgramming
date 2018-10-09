using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelPractice
{
    class T4
    {
        static void Main(string[] args)
        {
            //creating the task  
            Task<int> task1 = new Task<int>(() =>
            {
                int result = 1;

                for (int i = 1; i < 10; i++)
                    result *= i;

                return result;
            });

            //starting the task  
            task1.Start();

            //waiting for result - printing to the console  
            Console.WriteLine("Task result: {0}", task1.Result);

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
    }
}
