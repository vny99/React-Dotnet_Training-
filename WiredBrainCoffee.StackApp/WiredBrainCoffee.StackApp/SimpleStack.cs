using System.Runtime.CompilerServices;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack<T>
    {
        private T[] _items;
        private int _currentIndex;
        public SimpleStack()
        {
            _items = new T[10];
            _currentIndex = -1;
        }

        public void Push(T item)
        {
            _items[++_currentIndex] = item;
        }
        public T Pop()
        {
            return _items[_currentIndex--];
        }
        public int Count()
        {
            return _currentIndex + 1;
        }
    }
}