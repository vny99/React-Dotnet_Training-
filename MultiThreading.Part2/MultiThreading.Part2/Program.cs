using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Part2
{
  
    internal class Program
    {
        private static int Sum = 0; //shared resource
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Calculation);
            Thread t2 = new Thread(Calculation);
            Thread t3 = new Thread(Calculation);
            t1.Start();
            t2.Start();
            t3.Start();
            /* t.join() method forces the main thread to wait untill the 't' thread completes its execution . and 
             * when time period is given inside the Join method it acts as boolean return type which value will be
             * true if the 't' thread executes before the mentioned in the join function*/
            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("the sum is " + Sum);
            Console.ReadLine();
        }
        private static object _lock=  new object();
        public static void Calculation()
        {
            for(int i = 0; i < 50000; i++)
            {
                /*sum++;
                to protect the shared resource
                 interlocked.increment(ref sum);
                interlocked method faster than lock but have only some methods */
                //lock (_lock) 
                //{
                //    Sum++;
                //}
                /* lock method won't allow another thread untill the current thread excution is completed*/
                Monitor.Enter(_lock);
                try
                {
                    Sum++;
                }
                finally
                {
                    Monitor.Exit(_lock);
                }


            }
        }
    }
}
