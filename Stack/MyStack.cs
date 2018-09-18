using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    class MyStack<T>
    {
        class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next;

            public Node(T value = default(T), Node<T> next = null)
            {
                Value = value;
                Next = next;
            }
        }
        Node<T> head;
        public int Count { get; private set; }
        public void Push(T value)
        {
            head = new Node<T>(value, head);
            Count++;
        }
        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return head.Value;
        }
        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            T value = head.Value;
            head = head.Next;
            Count--;
            return value;
        }
        public void Clear()
        {
            head = null;
            Count = 0;
        }
    }
}
