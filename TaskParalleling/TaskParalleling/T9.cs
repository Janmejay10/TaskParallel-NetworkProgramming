using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParalleling
{
    class T9
    {
        static void Main(string[] args)
        {
            runoperation obj = new runoperation();
            Console.WriteLine("Creating and running tasks implicitly");
            obj.parallelinvoke_implicitly();
            Console.WriteLine();
            Console.WriteLine("Creating and running tasks explicity");
            obj.parallelinvoke_explicity_01();
            Console.WriteLine();
            Console.WriteLine("Creating and running tasks explicity by referencing action delegate");
            obj.parallelinvoke_explicity_03();
            Console.ReadLine();
        }
    }
    class runoperation
    {
        static runoperation() { }
        public void parallelinvoke_implicitly()
        {
            //Creating and running tasks implicitly  
            // This way of running mutiple task at same time is known as implicit task   
            // both operation are exxecuted parallelly  
            //Retun type is always void for parallel invoke. In technical term the input of parallel invoke is always action delegate  
            Parallel.Invoke(() = > Console.WriteLine("Perform Operatrion 1"), () = > Console.WriteLine("Perform Operatrion 2"));
        }
        public void parallelinvoke_explicity_01()
        {
            Parallel.Invoke(() = > dowork("Task- One"), () = > dowork("Task- Two"), () = > dowork("Task- Three"));
        }
        private void dowork(string input)
        {
            Console.WriteLine("I have been called by '{0}'", input);
        }
        public void parallelinvoke_explicity_03()
        {
            // parallel invoke with action delegate as input  
            Parallel.Invoke(action1);
        }
        /// <summary>  
        /// Following is an action delegate with one input of type string  
        /// </summary>  
        Action action1 = new Action(delegate {
            Console.WriteLine("Hi.... I am action Delegate.... I am inline coded with anonymous type");
        });
    }
}