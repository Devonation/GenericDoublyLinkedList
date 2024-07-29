using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    internal class DoublyNode<T>
    {
        public DoublyNode<T> Previous { get; set; }
        public T Data { get; set; } = default(T);
        public DoublyNode<T> Next { get; set; }

        public DoublyNode(T item) 
        {
            Previous = default;
            Data = item;
            Next = default;
        }
    }
}
