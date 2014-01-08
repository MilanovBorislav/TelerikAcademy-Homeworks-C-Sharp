using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Astrological_Digits
{

    class Program
    {
        static void Main(string[] args)
        {
              string number = Console.ReadLine();
           // string number = "1234567.8900";
            int result = 0;
            List<char> charList = number.ToCharArray().ToList();
            for(int i = 0; i < charList.Count; i++)
            {
                if(charList[i] == '-')
                {
                    charList[i] = ' ';
                }
                if(charList[i] == '.')
                {
                    charList[i] = ' ';
                }
                string value1 = charList[i].ToString();
                int value2;
                int.TryParse(value1, out value2);
                result = result + value2;
            }
         if(result > 9)
            {
               // int result = 199;
                string newresult = result.ToString();
                int newRes = 0;
                int counter = 9;
                while(true)
                {
                    newRes = 0;
                    for(int k = 0; k < newresult.Length; k++)
                    {
                        int value3;
                        string val = newresult[k].ToString();
                        int.TryParse(val, out value3);
                        newRes = newRes + value3;

                    }
                    newresult = newRes.ToString();
                    int Ncounter;
                    int.TryParse(newresult, out Ncounter);
                    counter = Ncounter;
                    if(counter<=9)
                    {
                        break; 
                    }
                }
                Console.WriteLine(counter);
            }
             else
             {
                 Console.WriteLine(result);
             }
        }
    }
}
