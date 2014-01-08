using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericListClasses
{

   public class GenericList<T> 
       where T :IComparable<T>
       
    {
       private T[] elementsList;
       private int count = 0;
       public GenericList(int capasity)
       {                                   
           elementsList = new T[capasity];
       }

       public GenericList()
           : this( 3 )
       { }

       public T this[int key] // Apply indexer
       {
           get { return this.elementsList[key]; }
       }

        public void AddElement(T element)
        {
           if( count >= elementsList.Length )
           {
               T[] newTempList = new T[elementsList.Length +5];
               Array.Copy( elementsList, 0, newTempList, 0, elementsList.Length );
               elementsList = newTempList;
           }

           elementsList[count] = element;
           count++;
        }

       public T AccessElement(int index)
       {
           return elementsList[index];   
       }

      

       public void InsertElement(T element,int index)
       {
           if( index>=count )
           {
               throw new IndexOutOfRangeException();
           }

           T[] newArray = new T[this.elementsList.Length+1];

           for( int i = 0,k=0; i < count-k; i++ )
           {
               if( index >= count )
               {
                   throw new IndexOutOfRangeException();
               }

               newArray[i] = elementsList[i];
               if( i == index )
               {
                   newArray[i] = element;
                   for( k = i+1; k <count+1; k++ )
                   {
                       newArray[k] = elementsList[k-1];
                   }
               }
           }

           this.elementsList = newArray;
           count++;
       
       }

       public void RemoveElement(int index)
       {
           if( index>=count )
           {
               throw new IndexOutOfRangeException(); 
           }

           T[] newArray = new T[this.elementsList.Length + 1];

           for( int i = 0,k=0; i < count-k; i++ )
           {
               newArray[i] = elementsList[i]; 
               if( i==index )                    
               {
                   for( k =index ; k <count-1; k++ )
                   {
                       newArray[k] = elementsList[k +1];
                   }
                   elementsList = newArray;
                   if( index==count-1 )
                   {
                       newArray[index] = elementsList[index + 1]; 
                   }
               } 
           }
           count--;
       }

       public int SearchIndex(T element) 
       {
           int index = 0;

           for( int i = 0; i < count; i++ )
           {
               if( elementsList[i].Equals(element) )
               {
                   index = i;  
               }
           }

           return index;
       }

       public void ClearList()
       {
           T[] newArray = new T[0];
           elementsList = newArray;
           count = 0;
       }

       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();

           for( int i = 0; i < count; i++ )
           {
               sb.Append( elementsList[i] );
               if( i < count - 1 )
               {
                   sb.Append( ", " );
               }
           }

           return string.Format( sb.ToString() );
       }




       public int Count  //Real Count
       {
           get { return count; }
       }
    }                                                    
}            
