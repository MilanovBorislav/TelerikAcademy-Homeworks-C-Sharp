using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Prime_Number
{
    class Task_07_Prime_Number
    {
        static void Main()
        {
            Console.WriteLine("Enter some number");
               int number = int.Parse(Console.ReadLine());
               int n = 100;
               int a = number%2;
               int b = number%3;
               int c = number%5;
               int d = number%7;
                if (number<=n && number>0) {
                    if ( (a == 0) || (b == 0) || (c == 0) || (d == 0) ) {
                        if (number == 2 || number == 3 || number == 5 || number == 7) {
                            Console.WriteLine("number  "+ number + " is prime ");
                        }
                        else {
                           Console.WriteLine("number "+ number + " is not prime "); 
                        }   
                    }
                    else {
                        Console.WriteLine("number "+ number + " is prime ");
                    }
                }
                else {
                    Console.WriteLine("chose another between 2 and  " + n);
                }
        
            }
        }
    }

