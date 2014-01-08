using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListClasses
{
    class TestGenericList
    {
        static void Main(string[] args)
        {
            GenericList<int> intList= new GenericList<int>();
            intList.AddElement(10);
            intList.AddElement( 10 );
            intList.AddElement( 10 );
            intList.AddElement(999);
            intList.AddElement( 112 );
            intList.AddElement( 189 );
            intList.AddElement( 188 );
            intList.AddElement( 789 );
            intList.AddElement( 1 );

            intList.InsertElement( 8000, 2 );

            intList.RemoveElement( 1 );
           
           Console.WriteLine("Index of 999 : {0}",intList.SearchIndex( 999 ));
           
           Console.WriteLine(intList.ToString());

           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine();

           GenericList<string> strList = new GenericList<string>();
           strList.AddElement( "Misho" );
           strList.AddElement( "Pesho" );
           strList.AddElement( "Gosho" );
           strList.AddElement( "Vasko" );
           strList.AddElement( "Mitko" );
           strList.AddElement( "Vlado" );

           strList.AddElement( "Added Element" );

           strList.InsertElement( "Inserted elememnt on given position", 2 );

           strList.RemoveElement( 1 );

           Console.WriteLine(strList.ToString());

           Console.WriteLine("Index of Gosho : {0}", strList.SearchIndex( "Gosho" ) );

           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine();                         


           int min = intList.Min<int>();
           Console.WriteLine(min);
           int max = intList.Max<int>();
           Console.WriteLine(max);
        }

       

       
    }
}
