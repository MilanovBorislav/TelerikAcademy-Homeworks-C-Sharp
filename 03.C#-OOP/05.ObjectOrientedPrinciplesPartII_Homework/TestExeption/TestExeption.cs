using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeptionClassLibrary;



namespace TestExeption
{
    class TestExeption
    {
    
        static void WriteNumber()
        {
            int min = 0;
            int max = 100;
            Console.WriteLine( "Enter number in the range from  {0}  to  {1}", min, max );
            int number = int.Parse( Console.ReadLine() );
            if( number < min || number > max )
            {
                throw new InvalidRangeExeption<int>( min, max );
            }
            else
            {
                Console.WriteLine( " {0} is valid valid", number );
            }
        }
        static void WriteDate()
        {
            DateTime min = new DateTime( 1980, 1, 1 );
            DateTime max = new DateTime( 2013, 12, 31 );

            Console.WriteLine( "Enter date between {0} - {1}", min, max );

            DateTime date = DateTime.Parse( Console.ReadLine() );

            if( date < min || date > max )
            {
                throw new InvalidRangeExeption<DateTime>( min, max );
            }
            else
            {
                Console.WriteLine( "{0} is valid!", date );
            }
        }
        static void Main()
        {
            try
            {
                WriteNumber();
            }
            catch( Exception ex )
            {
                Console.WriteLine( "Invalid Input " + ex.Message );

            }

            try
            {
                WriteDate();
            }
            catch (Exception ex)
            {
                Console.WriteLine( "Invalid Input " + ex.Message );

            }
           
        }
    }
}
