using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class Stack1<T>
    {
        private List<T> list = new List<T>();

        public void Push(T item)
        {
            list.Add(item);
        }
        public T Pop()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Khong co phan tu nao");
            }
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
        public T Peek()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Khong co phan tu nao");
            }
            return list[list.Count - 1];
        }
        public bool IsEmpty() { return list.Count == 0; }

        public void PrintStack()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }

    }
}
