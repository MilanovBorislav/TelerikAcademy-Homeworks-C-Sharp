using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Index_Of_Letters
{
    class Task_12_Index_Of_Letters
    {
        public static int AlphabethIndex(char target)
        {

            char[] arr = {'A' ,'B', 'C', 'D' ,'E', 'F' ,'G' ,'H', 'I' ,'J', 'K' ,'L' ,'M', 'N', 'O' ,
//index in array           0    1    2    3    4    5    6    7    8    9    10   11   12   13   14   
 
                                   'P', 'Q' ,'R', 'S', 'T', 'U' ,'V' ,'W' ,'X' ,'Y' ,'Z'};
 //index in array                  15    16   17   18   19   20   21   22   23   24   25 
            int begin = 0;
            int length = arr.Length;
            int test = 0;

            while (true)
            {
                test = (begin + length) / 2;
                if (arr[test] > target)
                {
                    length = test;
                }
                else
                {
                    begin = test;
                }

                if (arr[test] == target)
                {
                    break;
                }

            }
            return test;

        }

        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter some word");
            string bobi = Console.ReadLine().ToUpper();
            
            bool isLetter = true;

            for (int i = 0; i < bobi.Length; i++)
            {
                isLetter = char.IsLetter(bobi[i]);
                if (isLetter == false)
                {
                    Console.Write("The word contains characters different from letter");
                    Console.Write("| {0} |", bobi[i]);
                    break;
                }
            }

            Console.WriteLine();

            if (isLetter == true)
            {
                for (int i = 0; i < bobi.Length; i++)
                {
                    Console.WriteLine("Alphabeth Array |{0}| Index [{1}]", bobi[i], AlphabethIndex(bobi[i]));
                }
                Console.WriteLine();
            }

        }
    }
}
