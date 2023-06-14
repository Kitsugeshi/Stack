using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        public Node<T> Head { get; set; }
        public int Count { get; set; }
        public Stack()
        {
            Head = null!;
            Count = 0;
        }

        public Stack(T data)
        {
            Head = new Node<T>(data);
            Count = 1;
        }

        public void Push(T data)
        {
            var item = new Node<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
    }
}
