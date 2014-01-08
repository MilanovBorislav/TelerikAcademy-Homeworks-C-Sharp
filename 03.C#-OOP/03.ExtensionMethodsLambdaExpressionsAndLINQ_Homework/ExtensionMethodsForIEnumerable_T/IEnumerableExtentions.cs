using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsForIEnumerable_T
{
    public static class IEnumerableExtentions
    {
        public static T Min<T>(this IEnumerable<T> elementList)

            where T:IComparable<T>
        {

            dynamic min = long.MaxValue;

            foreach( var item in elementList )
            {
                if( item < min )
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> elementList)
              where T:IComparable<T>
        {
            dynamic max = long.MinValue;

            foreach( var item in elementList )
            {
                if( item>max )
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Product<T>(this IEnumerable<T> elementList)
        {
            dynamic product = 1;

            foreach( var item in elementList )
            {
                product = product * item;
            }
            return product;
        }

        public static T Sum<T>(this IEnumerable<T> elemntList)
        {
            dynamic sum = 0;

            foreach( var item in elemntList )
            {
                sum = sum + item;  
            }
            return sum;
        }


        public static decimal Average<T>(this IEnumerable<T>elementList)
        {
            dynamic sum = 0;
            decimal counter = 0;

            foreach( var item in elementList )
            {
                sum = sum + counter;
                counter++;
            }

            return sum / counter;
        }



    }

   


}
