using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace BigDictionary
{
    class CustomBigDictionary<TKey1, TKey2, TValue>
    {
        readonly MultiDictionary<TKey1, TValue> firstKey;
        readonly MultiDictionary<TKey2, TValue> secondKey;
        readonly MultiDictionary<int, TValue> doubleKey;
        readonly MultiDictionary<TKey1, TKey2> fistSecondKey;
        readonly MultiDictionary<TKey2, TKey1> secondFirst;

        public CustomBigDictionary()
        {
            firstKey = new MultiDictionary<TKey1, TValue>(true);
            secondKey = new MultiDictionary<TKey2, TValue>(true);
            doubleKey = new MultiDictionary<int, TValue>(true);
            fistSecondKey = new MultiDictionary<TKey1, TKey2>(true);
            secondFirst = new MultiDictionary<TKey2, TKey1>(true);
        }


        public void Add(TKey1 first, TKey2 second, TValue value)
        {
            int compositeKey = GetCompositeKey(first, second);
            doubleKey.Add(compositeKey, value);
            firstKey.Add(first, value);
            secondKey.Add(second, value);

            fistSecondKey.Add(first, second);
            secondFirst.Add(second, first);
        }

        public ICollection<TValue> FindByUsingFirsKey(TKey1 key)
        {
            var founded = new List<TValue>();

            founded.AddRange(firstKey[key]);

            return founded;
        }

        public ICollection<TValue> FindUsingSecondKey(TKey2 key)
        {
            var founded = new List<TValue>();

            founded.AddRange(secondKey[key]);

            return founded;
        }

        public ICollection<TValue> FindUsingBothKeys(TKey1 first, TKey2 second)
        {
            var found = new List<TValue>();

            found.AddRange(firstKey[first]);
            found.AddRange(secondKey[second]);
            found.AddRange(doubleKey[GetCompositeKey(first, second)]);

            return found;
        }

        public void RemoveWithFirstKey(TKey1 key)
        {
            if (!firstKey.ContainsKey(key))
            {
                throw new ArgumentException("Invalid key");
            }

            firstKey.Remove(key);
            var key2 = fistSecondKey[key];
            foreach (var item in key2)
            {
                secondKey.Remove(item);
                doubleKey.Remove(GetCompositeKey(key, item));
            }
        }

        public void RemoveWithSecondKey(TKey2 key)
        {
            if (!secondKey.ContainsKey(key))
            {
                throw new ArgumentException("Invalid key");
            }

            secondKey.Remove(key);
            ICollection<TKey1> key1 = secondFirst[key];
            foreach (var item in key1)
            {
                firstKey.Remove(item);
                doubleKey.Remove(GetCompositeKey(item, key));
            }
        }

        public void RemoveWithBothKeys(TKey1 first, TKey2 second)
        {
            if (!firstKey.ContainsKey(first) || !secondKey.ContainsKey(second))
            {
                throw new ArgumentException("Invalid key");
            }

            firstKey.Remove(first);
            secondKey.Remove(second);

            doubleKey.Remove(GetCompositeKey(first, second));

        }

        private int GetCompositeKey(TKey1 first, TKey2 second)
        {
            int compositeKey = 0;
            unchecked
            {
                compositeKey = first.GetHashCode() * 5039;
                compositeKey = second.GetHashCode() * 5039;
            }
            return compositeKey;
        }

    }
}
