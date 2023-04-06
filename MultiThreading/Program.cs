using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main";
            Console.WriteLine($"Thead name from variable : {t.Name}");
            Console.WriteLine($"Thread name from Thread : {Thread.CurrentThread.Name}");

            //IterationMethod1();
            //Console.WriteLine("Method 1 executed");
            //IterationMethod2();
            //Console.WriteLine("Mehod 2 executed ");
            //IteriationMethod3();
            //Console.WriteLine("Method 3 executed");
            
            Console.WriteLine("Main thread has started");
            Thread t1 = new Thread(IterationMethod1)
            {
                Name = "thread-1"
            };
            Thread t2 = new Thread(IterationMethod2)
            {
                Name = "thread-2"
            };
            Thread t3 = new Thread(IteriationMethod3)
            {
                Name = "thread-3"
            };
            t1.Start();
            t2.Start();
            t3.Start();
            if (t3.IsAlive)
            {
                Console.WriteLine("it is still alive");
            }
            t1.Join();
            if (t2.Join(11000))
            {
                Console.WriteLine("it is still awake");
            }
            t3.Join();
           

            // TheadStartDelegator
            //ThreadStart obj = new ThreadStart(ShowNumbers); // here we are externally iniating the Thread start
            //Thread td = new Thread(obj);                    // it can also be done like ThreadStart obj= ShowNumbers;
            //td.Start();                                     // so when we are passing ShowNumbers method inside the
            //  Thead() , there is internally we are assiging it to the ThreadStart constructor

            //ParameterizedThreadStartDelegator
            //ParameterizedThreadStart pbj = new ParameterizedThreadStart(ShowNumbersParameterized);
            //Thread tp = new Thread(pbj);
            //tp.Start(10);

            /* In the above method we only int value but even if we pass a not integer value that method 
             * does'nt give any error , since it is not type safe . To make it type safe we need a helper
             * class the implementation will be as follows */

            //SumCallBack _sum = new SumCallBack(SumCall);
            //NumberHelper nH = new NumberHelper(20,_sum);
            //ThreadStart obj2 = new ThreadStart(nH.ShowNumbers);
            //Thread to = new Thread(obj2);
            //to.Start();
            Console.ReadLine();





        }
        public static void SumCall( int  sum)
        {
            Console.WriteLine(sum);
        }

        private static void ShowNumbersParameterized(object maxValue)
        {
            for(int i=0;i< Convert.ToInt32(maxValue); i++)
            {
                Console.WriteLine(i);
            }
        }

        static void ShowNumbers()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i++);
            }
        }

        private static void IteriationMethod3()
        {
            Console.WriteLine($"Method3 started using {Thread.CurrentThread.Name}");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"method3 {i}");
            }
            Console.WriteLine($"Method3 stopped using {Thread.CurrentThread.Name}");
        }

        private static void IterationMethod2()
        {
            Console.WriteLine($"Method2 started using {Thread.CurrentThread.Name}");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"method2 {i}");
                if (i == 2)
                {
                    Console.WriteLine("delay has started");
                    Thread.Sleep(10000);
                    Console.WriteLine("dealy ended");
                }
            }
            Console.WriteLine($"Method2 stopped using {Thread.CurrentThread.Name}");
        }

        private static void IterationMethod1()
        {
            Console.WriteLine($"Method1 started using {Thread.CurrentThread.Name}");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"method1 {i}");
            }
            Console.WriteLine($"Method1 stopped using {Thread.CurrentThread.Name}");
        }
    }
}
