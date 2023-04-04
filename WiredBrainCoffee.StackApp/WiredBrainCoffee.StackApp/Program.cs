using System;
namespace WiredBrainCoffee.StackApp
{
    class program
    {
        static void Main(String[] args)
        {
            StackForDouble();
            StackForString();

        }

        private static void StackForString()
        {
            var stack = new SimpleStack<String>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            var sum="";
            while (stack.Count() > 0)
            {
                String r = stack.Pop();
                Console.WriteLine($"item - {r}");
                sum += r;
            }

        }

        private static void StackForDouble()
        {
            var stack = new SimpleStack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);
            var sum = 0.0;
            while (stack.Count() > 0)
            {
                double r = stack.Pop();
                Console.WriteLine($"item - {r}");
                sum += r;
            }
        }
    }
}