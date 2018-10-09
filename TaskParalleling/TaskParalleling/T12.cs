using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParalleling
{
    class T12
    {
        static void Main(string[] args)
        {
            //creating the cancelation token  
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            //creating the task  
            Task task = new Task(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Cancel() called.");
                        return;
                    }

                    Console.WriteLine("Loop value {0}", i);
                }
            }, token);

            Console.WriteLine("Press any key to start task");
            Console.WriteLine("Press any key again to cancel the running task");
            Console.ReadKey();

            //starting the task  
            task.Start();

            //reading a console key  
            Console.ReadKey();

            //canceling the task  
            Console.WriteLine("Canceling task");
            cancellationTokenSource.Cancel();

            Console.WriteLine("Main method complete. Press any key to finish.");
            Console.ReadKey();
        }
    }
}
