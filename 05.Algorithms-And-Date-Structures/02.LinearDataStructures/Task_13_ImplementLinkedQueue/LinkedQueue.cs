using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_ImplementLinkedQueue
{
    /// <summary>
    /// A Fists in Firs Out collection
    /// </summary>
    /// <typeparam name="T">The type of stored data in the collection</typeparam>
    class LinkedQueue<T> : IEnumerable<T>
    {
        LinkedList<T> items = new LinkedList<T>();
        
        /// <summary>
        /// Add an item to the back of the queue
        /// </summary>
        /// <param name="item">The iste to place int the queue</param>
        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        /// <summary>
        /// Remove and retursn the front item from the queue
        /// </summary>
        /// <returns>Stored last value</returns>
        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            //store the last value in a temporary variable
            T value = items.First.Value;
            //remove the last item 
            items.RemoveFirst();
            return value;
        }

        /// <summary>
        ///  Remove and retursn the front item from the queue without removing it from the queue
        /// </summary>
        /// <returns>The front item from the queue</returns>
        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            //return the last value from the queue
            return items.First.Value;
        }

        /// <summary>
        /// The number of items in the queue
        /// </summary>
        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        /// <summary>
        /// Removes all elements in the queue
        /// </summary>
        public void Clear()
        {
            items.Clear();
        }

        #region IEnumerable
        
        /// <summary>
        /// Returns enumerator that enumerates the queue
        /// </summary>
        /// <returns>The enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        /// <summary>
        /// Returns enumerator that enumerates the queue
        /// </summary>
        /// <returns>The enumerator</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
        
        #endregion   
    }
}