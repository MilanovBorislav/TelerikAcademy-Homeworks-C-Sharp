using System;
using System.Linq;
using System.Text;

namespace SubstringStringBuilder
{
    public static  class SubstringStringBuilder
    {
        public static StringBuilder SubString(this StringBuilder strBuilder, int index,int length)
        {
            StringBuilder sb = new StringBuilder();

            if( index + length >= strBuilder.Length -1 )
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            int endIndex = index + length;

            for( int i = index; i < endIndex; i++ )
            {
                sb.Append( strBuilder[i] );
            }

            return sb;
        }

        public static  StringBuilder SubString(this StringBuilder strBuilder, int index)
        {
            StringBuilder sb = new StringBuilder();

            if( index<0 )
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
     
            for( int i = index; i <strBuilder.Length; i++ )
            {
                sb.Append( strBuilder[i] );
            }

            return sb;
        }
    }
}
