using System;

namespace MultiThreading
{
    public delegate void SumCallBack(int sum);
    public class NumberHelper
    {
        private readonly int _Number;
        private event SumCallBack _Sum;
        public NumberHelper(int num, SumCallBack sum)
        {
            _Number = num;
            _Sum = sum;
        }
        public void ShowNumbers()
        {
            int sum = 0;
            for(int i = 0; i < _Number; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            if (_Sum != null)
            {
                _Sum(sum);
            }
        }
    }
}
