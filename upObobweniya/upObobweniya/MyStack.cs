using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    public class MStack<T>
    {
        private T[] items;
        private int count;
        private int n;

        public MStack(int length)
        {
            items = new T[length];
            count = 0;
            n = length;
        }

        public int Count
        {
            get { return count; }
        }

        public void Push(T item)
        {
            if (count == n)
                throw new Exception("Переполнение стека");
            items[count++] = item;
        }

        public T Pop()
        {
            if (count == 0)
                throw new Exception("Стек пуст");
            T item = items[--count];
            items[count] = default(T);
            return item;
        }

        public T Peek()
        {
            if (count == 0)
                throw new Exception("Стек пуст");
            return items[count - 1];
        }
    }
}
