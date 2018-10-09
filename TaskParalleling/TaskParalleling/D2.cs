using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaaskParalleling
{
    class D2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            Account accountA = new Account(101, 5000);
            Account accountB = new Account(102, 3000);

            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "Thread T1 ";

            AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);
            Thread T2 = new Thread(accountManagerA.Transfer);
            T2.Name = "Thread T2 ";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();
            Console.WriteLine("Main Complete");
            Console.Read();
        }
    }
}
