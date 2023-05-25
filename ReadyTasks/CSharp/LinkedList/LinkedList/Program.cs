using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T>: ICollection<T>
    {
        public class LinkedListNode<T>: ICloneable
        {
            private T _value;

            public T Value { get => this._value; }

            public LinkedListNode<T> Prev;
            public LinkedListNode<T> Next;

            public LinkedListNode(T val)
            {
                this._value = val;
                this.Prev = null;
                this.Next = null;
            }

            public LinkedListNode(T val, LinkedListNode<T> next, LinkedListNode<T> prev)
            {
                this._value = val;
                this.Prev = prev;
                this.Next = next;
            }

            public LinkedListNode(LinkedListNode<T> node)
            {
                this._value = node.Value;
                this.Prev = node.Prev;
                this.Next = node.Next;
            }

            public object Clone()
            {
                return new LinkedListNode<T>(this);
            }
        }

        private int _capacity;
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _tail;

        public LinkedListNode<T> Head { get => new LinkedListNode<T>(this._head); }
        public LinkedListNode<T> Tail { get => new LinkedListNode<T>(this._tail); }

        public int Count => this._capacity;

        public bool IsReadOnly => false;

        public LinkedList()
        {
            this._capacity = 0;
            this._head = null;
            this._tail = null;
        }

        public void AddToTail(T val)
        {
            this._capacity++;
            if (this._head == null)
            {
                this._head = new LinkedListNode<T>(val);
                this._tail = this._head;
            }
            else
            {
                this._tail.Next = new LinkedListNode<T>(val);
                this._tail = this._tail.Next;
            }
        }

        public void AddToHead(T val)
        {
            this._capacity++;
            if (this._head == null)
            {
                this._head = new LinkedListNode<T>(val);
                this._tail = this._head;
            }
            else
            {
                this._head.Prev = new LinkedListNode<T>(val);
                this._head = this._head.Prev;
            }
        }

        public LinkedListNode<T> RemoveFromStart()
        {
            if (this._head == null)
            {
                throw new ArgumentOutOfRangeException("Collection is empty");
            }
            else
            {
                this._capacity--;
                var initHead = this._head;
                this._head = this._head.Next;
                if (this._head == null)
                {
                    this._tail = null;
                }
                initHead.Prev = null;
                initHead.Next = null;
                return initHead;
            }
        }

        public LinkedListNode<T> RemoveFromEnd()
        {
            if (this._head == null)
            {
                throw new ArgumentOutOfRangeException("Collection is empty");
            }
            else
            {
                this._capacity--;
                var initHead = this._tail;
                this._tail = this._tail.Prev;
                if (this._tail == null)
                {
                    this._head = null;
                }
                initHead.Prev = null;
                initHead.Next = null;
                return initHead;
            }
        }

        public void Add(T item)
        {
            this.AddToTail(item);
        }

        public void Clear()
        {
            while (this._capacity > 0)
            {
                this.RemoveFromEnd();
            }
        }

        public bool Contains(T item)
        {
            var initNode = this._head;
            while (initNode != null)
            {
                if (initNode.Value.Equals(item))
                {
                    return true;
                }
                initNode = initNode.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var initNode = this._head;
            for (int i = arrayIndex; i < array.Length && initNode != null; i++)
            {
                array[i] = initNode.Value;
                initNode = initNode.Next;
            }
        }

        public void Remove(LinkedListNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            if (node == this._head)
            {
                this.RemoveFromStart();
            }
            else if (node == this._tail)
            {
                this.RemoveFromEnd();
            }
            else
            {
                var prev = node.Prev;
                var next = node.Next;
                prev.Next = next;
            }
        }
        public bool Remove(T item)
        {
            var initNode = this._head;
            LinkedListNode<T> nodeForRemove = null;
            while (initNode != null)
            {
                if (initNode.Value.Equals(item))
                {
                    nodeForRemove = initNode;
                    break;
                }
                initNode = initNode.Next;
            }

            if (nodeForRemove == null)
            {
                return false;
            }
            else
            {
                this.Remove(nodeForRemove);
                return true;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var initNode = this._head;
            while (initNode != null)
            {
                yield return initNode.Value;
                initNode = initNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
