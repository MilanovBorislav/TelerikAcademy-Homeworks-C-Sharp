using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OuterClass
{
    const int max_count = 6;
    class InnerClass
    {
        public void PrintArgument(bool variable)
        {
            string variableToString = variable.ToString();
            Console.WriteLine(variableToString);
        }
    }

    public static void Main()
    {
        OuterClass.InnerClass instanceOfClass = new OuterClass.InnerClass();
        instanceOfClass.PrintArgument(true);
    }
}
