﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DoublyLinkedList
{
    internal class CustomDoublyLinkedList<T>
    {
        public DoublyNode<T> Head { get; set; } 
        public DoublyNode<T> Tail { get; set; } 
        public int Count { get; set; }
        public CustomDoublyLinkedList()
        {
            Head = null;
            Count = 0;
        }
        public CustomDoublyLinkedList(T item)
        {
            Head = new DoublyNode<T>(item);
            Count = 1;
        }
        public void RemoveItem(T item)
        {
            int step = 0;
            DoublyNode<T> current = Head;
            if (Head.Data.Equals(item))
            {
                current = current.Next;
                Head = current;
            }
            else
            {
                while (step < Count)
                {
                    if (current.Data.Equals(item))
                    {
                        DoublyNode<T> temp = current;
                        current.Previous.Next = temp.Next;
                        current = temp.Next;
                        break;
                    }
                    if (current.Next != null)
                    {
                        current = current.Next;
                    }
                    step++;
                }
            }
            Count--;
        }
        public void PrependItem(T item)
        {
            if (Count == 1)
            {
                DoublyNode<T> newNode = new(item);
                newNode.Next = Head;
                Head.Previous = newNode;
                Tail = Head;
                Head = newNode;
            }
            else
            {
                DoublyNode<T> newNode = new(item);
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
            Count++;
        }
        public void AppendItem(T item)
        {
            if (Count == 0)
            {
                DoublyNode<T> newNode = new(item);
                Head = newNode;
                Tail = newNode;
            }
            else if (Count == 1)
            {
                DoublyNode<T> newNode = new(item);
                newNode.Previous = Head;
                Head.Next = newNode;
                Tail = newNode;
            } 
            else
            {
                DoublyNode<T> newNode = new(item);
                newNode.Previous = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }
        
        public void AddItem(T item, int index)
        {
            if (index < Count)
            {
                double linkedListLength = Count;
                if (index < Math.Ceiling(linkedListLength / 2))
                {
                    SearchFromHead(item, index);
                }
                else
                {
                    SearchFromTail(item, index);
                }
                Count++;
            }
            else
            {
                AppendItem(item);
            }
        }
        private void SearchFromHead(T item, int index)
        {
            int step = 0;
            DoublyNode<T> newNode = new(item);
            DoublyNode<T> current = Head;

            while (step < index)
            {
                current = current.Next;
                step++;
            }
            newNode.Next = current.Next;
            newNode.Previous = current;
            current.Next.Previous = newNode;
            current.Next = newNode;
        }
        private void SearchFromTail(T item, int index)
        {
            int step = Count - 1;
            DoublyNode<T> newNode = new(item);
            DoublyNode<T> current = Tail;

            while (step > index)
            {
                current = current.Previous;
                step--;
            }
            newNode.Previous = current.Previous;
            newNode.Next = current;
            current.Previous.Next = newNode;
            current.Previous = newNode;
        }

        public T SearchItem(string title)
        {
            PropertyInfo property = typeof(T).GetProperty("Title");
            if (property != null )
            {
                DoublyNode<T> current = Head;
                while (!current.Data.GetType().GetProperty("Title").GetValue(current.Data).Equals(title))
                {
                    if (current.Next != null)
                    {
                        current = current.Next;
                    }
                    else
                    {
                        return default;
                    }
                }
                return current.Data;
            } 
            else
            {
                return default;
            }
        }
    }
}
