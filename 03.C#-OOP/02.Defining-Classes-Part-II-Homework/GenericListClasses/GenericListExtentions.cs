using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListClasses
{
    public static class GenericListExtensions
    {

        public static T Min<T>(this GenericList<T> elementList)

            where T:IComparable<T>
        {

            T min = elementList[0];

            for( int index = 1; index < elementList.Count; index++ )
            {

                if( elementList[index].CompareTo( min ) < 0 )
                {

                    min = elementList[index];

                }

            }

            return min;

        }

        public static T Max<T>(this GenericList<T> list)

            where T:IComparable<T>
        {

            T max = list[0];

            for( int index = 0; index < list.Count; index++ )
            {

                if( list[index].CompareTo( max ) > 0 )
                {

                    max = list[index];

                }

            }

            return max;

        }

    }
}
