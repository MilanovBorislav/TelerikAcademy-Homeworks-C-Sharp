using System;
using System.Collections;
using System.Collections.Generic;


namespace HashTable
{
    public class HashTable<TKey, TValue>
    {
        const double fillFactor = 0.75;

        int maxItemsAtCurrentSize;

        int count;

        HashTableArray<TKey, TValue> array;

        public HashTable()
            : this(1000)
        {
        }

        public HashTable(int initialCapacity)
        {
            if (initialCapacity < 1)
            {
                throw new ArgumentOutOfRangeException("initialCapacity");
            }

            array = new HashTableArray<TKey, TValue>(initialCapacity);

            maxItemsAtCurrentSize = (int)(initialCapacity * fillFactor) + 1;
        }

        public void Add(TKey key, TValue value)
        {
            if (count >= maxItemsAtCurrentSize)
            {
                HashTableArray<TKey, TValue> largerArray = new HashTableArray<TKey, TValue>(array.Capacity * 2);

                foreach (HashTableNodePair<TKey, TValue> node in array.Items)
                {
                    largerArray.Add(node.Key, node.Value);
                }

                array = largerArray;

                maxItemsAtCurrentSize = (int)(array.Capacity * fillFactor) + 1;
            }

            array.Add(key, value);
            count++;
        }

        public bool Remove(TKey key)
        {
            bool removed = array.Remove(key);
            if (removed)
            {
                count--;
            }

            return removed;
        }

        public TValue this[TKey key]
        {
            get
            {
                TValue value;
                if (!array.TryGetValue(key, out value))
                {
                    throw new ArgumentException("key");
                }

                return value;
            }
            set
            {
                array.Update(key, value);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return array.TryGetValue(key, out value);
        }

        public bool ContainsKey(TKey key)
        {
            TValue value;
            return array.TryGetValue(key, out value);
        }

        public bool ContainsValue(TValue value)
        {
            foreach (TValue foundValue in array.Values)
            {
                if (value.Equals(foundValue))
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<TKey> Keys
        {
            get
            {
                foreach (TKey key in array.Keys)
                {
                    yield return key;
                }
            }
        }

        public IEnumerable<TValue> Values
        {
            get
            {
                foreach (TValue value in array.Values)
                {
                    yield return value;
                }
            }
        }

        public void Clear()
        {
            array.Clear();
            count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public IEnumerator<HashTableNodePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var item in this.array.Items)
            {
                yield return item;
            }
        }
    }
}
