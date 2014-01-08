using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_ImplementStack
{
    public class MyStack<T> : IEnumerable<T>
    {
        T[] items = new T[0];
        int size;

        /// <summary>
        /// Add the specified item to stack
        /// </summary>
        /// <param name="item">Item to push</param>
        public void Push(T item)
        {
            int newLenght;

            if (size == items.Length)
            {
                if (size == 0)
                {
                    newLenght = 4;
                }
                else
                {
                    newLenght = size * 2;
                }

                T[] newArray = new T[newLenght];
                items.CopyTo(newArray, 0);
                items = newArray;
            }
            items[size] = item;
            size++;
        }

        /// <summary>
        /// Remove and returns the the top most item from the stack
        /// </summary>
        /// <returns>Тhe top most item from the stack</returns>
        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            size--;
            return items[size];
        }

        /// <summary>
        /// Returns the top item from the stack without removing ig from the stack
        /// </summary>
        /// <returns>Тhe top most item from the stack</returns>
        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            return items[size - 1];
        }

        public int Count
        {
            get
            {
                return size;
            }
        }

        #region IEnumerable
        /// <summary>
        /// Enumerates each item in the stack
        /// </summary>
        /// <returns>The LIFO enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                yield return items[i];

            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        #endregion
    }
}