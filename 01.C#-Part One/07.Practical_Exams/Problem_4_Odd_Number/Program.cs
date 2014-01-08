using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;


namespace Problem_4_Odd_Number
{
    class Program
    {    
//         static long[] sortArray(long[] arr)
//         {
//             //int[] arr = new int[10] { 50, 40, 20, 60, 100, 30, 80, 10, 90, 70 };
//             int arr_size = arr.Length;
//             long i;
//             long j;
//             long index;
//             long temp;
// 
//             for(i = 1; i < arr_size; i++)
//             {
//                 index = arr[i];
// 
//                 j = i;
// 
//                 while((j > 0) && (arr[j - 1] > index))
//                 {
//                     temp = arr[j - 1];
//                     arr[j] = arr[j - 1];
//                     j--;
//                 }
//                 arr[j] = index;
// 
//             }
//             return arr;
//         }
             
        static void Main(string[] args)
        {
//              //Reading array from the Console
//              int n = int.Parse(Console.ReadLine());
//              long[] newArr = new long[n];
//              for(int j = 0; j < n; j++)
//              {
//                  newArr[j] = long.Parse(Console.ReadLine());
//              }
//              //
//  
//              //Sorting array  and create new array
//              long[] arr = sortArray(newArr);
//              //
//              int length = arr.Length;
//              int i = 0;
//              int k = i;
//              for(i = 0; i < length; i++)
//              {
//                  int len = 0;
//                  i = k;
//                  for(k = i; k < length; k++)
//                  {
// 
//                      if(arr[i] == arr[k])
//                      {
//                          len++;
//                      }
//                      if(arr[i] != arr[k])
//                      {
//                          break;
//                      }
//                  }
//                  if(len % 2 != 0)
//                  {
//                      Console.WriteLine(arr[i]);
//                      break;
//                  }

                                  int N = int.Parse(Console.ReadLine());
                                             //  int N = 5;
                                               long result = 0;
                                               //long[] arr = new long[N];
                                              // long[] arr = {9,9,1,1,9,9,9,2,2,4,4 }; 
                                               for(int i = 0; i <= N-1; i++)
                                               {
                                                   long number = long.Parse(Console.ReadLine());
                                                   result = result ^ number;
                                               }
                                               Console.WriteLine(result);
             
        }
    }
}
