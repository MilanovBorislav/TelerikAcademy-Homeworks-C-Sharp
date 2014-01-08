using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetImplamentation
{
    public class MySet<T> : IEnumerable<T>
        where T : IComparable<T>
    {
       private readonly  List<T> _items = new List<T>();

        public MySet()
        {
        }

        public MySet(IEnumerable<T> items)
        {
            AddRange(items);
        } 
        
         public void Add(T item)
         {
             if (Contains(item))
             {
                 throw  new InvalidOperationException("Item is already in Set");
             }
             _items.Add(item);
         }

        public void AddRange(IEnumerable<T>items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }
        
        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public int Count 
        {
            get { return _items.Count; }
        } 

        public MySet<T> Union(MySet<T> other)
        {
            MySet<T> result = new MySet<T>();
            result.AddRange(_items);

            foreach (var item in other)
            {
                if (result.Contains(item))
                {
                    continue;
                }
                else
                {
                    result.Add(item);
                }
            }
            return result;
        }

       

        public MySet<T> Intersection(MySet<T> other)
        {
            MySet<T> result = new MySet<T>();

            foreach (T item in _items)
            {
                if (other._items.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public MySet<T> Difference(MySet<T> other)
        {
            MySet<T> result = new MySet<T>(_items);

            foreach (T item in other._items)
            {
                result.Remove(item);
            }
            return result;
        }

        public MySet<T> SymmetricDifference(MySet<T> other)
        {
            MySet<T> intersection = Intersection(other);
            MySet<T> union = Union(other);
            return union.Difference(intersection);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}