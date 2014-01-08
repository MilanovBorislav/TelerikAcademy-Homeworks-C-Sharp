using System;
using System.Linq;
using System.Text;


namespace SubstringStringBuilder
{
    class TestSubstringStringBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append( "MishoPeshoGosho" );

            Console.WriteLine(sb.SubString(5,5));
            Console.WriteLine(sb.SubString(5));
            Console.WriteLine(sb.SubString(5,sb.Length-10));
            Console.WriteLine(sb.SubString(0));

        }
    }
}
