﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParalleling
{
    class T5
    {
        static void GenerateNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method1 - Number: {0}", i);
                Thread.Sleep(1000);
            }
        }

        static void PrintCharacters()
        {
            string str = "dotnetcurry";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("Method2 - Character: {0}", str[i]);
                Thread.Sleep(1000);
            }

        }

        static void PrintArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int i in arr)
            {
                Console.WriteLine("Method3 - Array: {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Parallel.Invoke(
                new Action(GenerateNumbers),
                new Action(PrintCharacters),
                new Action(PrintArray)
                );

            Console.ReadLine();
        }
    }
}
