using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    class VersionAttributeTest
    {
        static void Main(string[] args)
        {
            Type type = typeof( SampleClass);

            object[] attributes = type.GetCustomAttributes( false );

            foreach( var attribute in attributes )
            {

                if( attribute is VersionAttribute )
                {

                    Console.WriteLine( "Version {0} of the {1} class.", (attribute as VersionAttribute).Version, typeof( SampleClass ).FullName );

                }

            }

        }
    }
}
