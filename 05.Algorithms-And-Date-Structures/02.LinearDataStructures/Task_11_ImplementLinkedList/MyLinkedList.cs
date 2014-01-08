using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_ImplementLinkedList
{ 
    /// <summary>
    /// A linked list collection capable of operations such as 
    /// Add, Remove, Find and Enumerate
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyLinkedList<T> : ICollection<T>
    {
        /// <summary>
        /// The firs node in the list of null if empty
        /// </summary>
        public MyLinkedListNode<T> Head { get; private set; }

        /// <summary>
        /// Last node ing the list or null if empty
        /// </summary>
        public MyLinkedListNode<T> Tail { get; private set; }

        #region Add
        
        public void AddFirst(T value)
        {
            AddFirst(new MyLinkedListNode<T>(value));
        }

        /// <summary>
        /// Add the value to the end of the list
        /// </summary>
        /// <param name="value">The value to add</param>
        public void AddLast(T value)
        {
            AddLast(new MyLinkedListNode<T>(value));
        }

        public void AddFirst(MyLinkedListNode<T> node)
        {
            // Save off the head node so we don't lose it
            MyLinkedListNode<T> temp = Head;

            // Point head to the new node
            Head = node;

            // Insert the rest of the list behind the head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                // if the list was empty then Head and Tail should
                // both point to the new node.
                Tail = Head;
            }
        }

        public void AddLast(MyLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;   
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        #endregion

        #region Remove
        
        /// <summary>
        /// Remove firs node from the list
        /// </summary>
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
            }
            if (Count == 0)
            {
                Tail = null;
            }
        }
        
        /// <summary>
        ///Remove the last node from the list 
        /// </summary>
        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    MyLinkedListNode<T> currentNode = Head;
                    while (currentNode.Next != Tail)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = null;
                    Tail = currentNode;
                }
            }
        }
        
        #endregion
        
        #region ICollection
        
        /// <summary>
        /// Show number of items contained in the list
        /// </summary>
        public int Count { get; private set; }
        
        /// <summary>
        /// Add the specified to the front of the list
        /// </summary>
        /// <param name="item">The value to add can be any type</param>
        public void Add(T item)
        {
            AddFirst(item);
        }
        
        /// <summary>
        /// Clear all items in the list
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        
        /// <summary>
        /// Return true if the list contain searched value
        /// </summary>
        /// <param name="item">Searched item</param>
        /// <returns>boolean value</returns>
        public bool Contains(T item)
        {
            MyLinkedListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            
            return false;
        }
        
        /// <summary>
        /// Copies the node value in the specified array
        /// </summary>
        /// <param name="array">The array to copy the linked list value to</param>
        /// <param name="arrayIndex">the index in the array to start copying at</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            MyLinkedListNode<T> currntNode = Head;
            while (currntNode != null)
            {
                array[arrayIndex++] = currntNode.Value;
                currntNode = currntNode.Next;
            }
        }
        
        /// <summary>
        /// True if the collection is readonly, false otherwise.
        /// </summary>     
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        
        /// <summary>
        /// Removes the first occurance of the item from the list (searching from Head to Tail).
        /// </summary>
        /// <param name="item">The item to remove</param>
        /// <returns>True if the item was found and removed, false otherwise</returns>
        public bool Remove(T item)
        {
            MyLinkedListNode<T> previosNode = null;
            MyLinkedListNode<T> currnetNode = Head;
            
            while (currnetNode != null)
            {
                if (currnetNode.Value.Equals(item))
                {
                    if (previosNode != null)
                    {
                        previosNode.Next = currnetNode.Next;
                        if (currnetNode.Next == null)
                        {
                            Tail = previosNode;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    
                    return true;
                }
                
                previosNode = currnetNode;
                currnetNode = currnetNode.Next;
            }
            
            return false;
        }

        /// <summary>
        /// Enumerates over the linked list values from Head to Tail
        /// </summary>
        /// <returns>A Head to Tail enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            MyLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// Enumerates over the linked list values from Head to Tail
        /// </summary>
        /// <returns>A Head to Tail enumerator</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }
    
        #endregion
    }
}