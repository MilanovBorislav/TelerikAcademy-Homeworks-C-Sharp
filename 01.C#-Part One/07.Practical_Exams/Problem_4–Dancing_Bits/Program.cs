using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Dancing_Bits
{
    class Program
    {
        static void Main(string[] args)
        {

//             int a = 2;
//             int b = 10;
//             int c = 42;
//             int d = 170;
// 
//             string aa = Convert.ToString(a, 2).PadLeft(0);
//             string bb = Convert.ToString(b, 2).PadLeft(0);
//             string cc = Convert.ToString(c, 2).PadLeft(0);
//             string dd = Convert.ToString(d, 2).PadLeft(0);

            int dancing = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string concat = "";
            string letter = "";
            int[] arr = new int[n];
            for(int f = 0; f < n; f++)
            {
                arr[f] = int.Parse(Console.ReadLine());
                letter = Convert.ToString(arr[f], 2).PadLeft(0);
                concat = concat + letter;


            }



            //Console.WriteLine(concat);

            //             string concat = aa + bb + cc + dd;
            //             Console.WriteLine(concat);//  
            int length = concat.Length;

            int counter = 0;
            int lenght = concat.Length;
            int i = 0;
            int k = i;

            for(i = 0; i < length; i++)
            {
                int len = 0;
                i = k;
                for(k = i; k < length; k++)
                {
                    if(concat[i] == concat[k])
                    {
                        len++;
                    }
                    if(concat[i] != concat[k])
                    {
                        break;
                    }
                }
                if(len == dancing)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
