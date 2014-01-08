using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_ImplementLinkedList
{
    public class MyLinkedListNode<T>
    { 
        /// <summary>
        /// Construct a new node with the special value
        /// </summary>
        /// <param name="value">vale of any type</param>
        public MyLinkedListNode(T value)
        {
            this.Value = value;
        }

        /// <summary>
        /// The node value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// The next node in the linked list (null if it is the last node)
        /// Pointer to the next node in the chain
        /// </summary>
        public MyLinkedListNode<T> Next { get; set; }
    }
}