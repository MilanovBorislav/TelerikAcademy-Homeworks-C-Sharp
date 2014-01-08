using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_Windows_Copyright_Sumbol
    {
    class Task_9_Windows_Copyright_Sumbol
        {
        static void Main ( )
            {
            //Write a program that prints an isosceles triangle of 9 copyright symbols ©.
            //Use Windows Character Map to find the Unicode code of the © symbol. Note: 
            //the © symbol may be displayed incorrectly.


            string a = @"
                            ©
                           © ©
                          ©   ©
                         © © © ©
                            ";
            Console.WriteLine( a );

            }
        }
    }
