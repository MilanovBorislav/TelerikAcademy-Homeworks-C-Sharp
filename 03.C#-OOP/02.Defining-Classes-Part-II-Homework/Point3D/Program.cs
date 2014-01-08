using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Program
    {
        static void Main(string[] args)
        {                                                                                                     
            _3DPoint firstPoint = new _3DPoint( 1.2, 1.6, 7.2 );
            _3DPoint secondPoint = new _3DPoint( 6.7, 3.9, 1.7 );

            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);

//             List<_3DPoint> pointList = new List<_3DPoint>();
// 
//             pointList.Add( firstPoint );
//             pointList.Add( secondPoint );

            Console.WriteLine(" Distance  {0:0.000}" ,Distance.CalculateDistance(firstPoint,secondPoint));


            Path firstPath = new Path();
            firstPath.Add3DPoint( firstPoint);
            firstPath.Add3DPoint( secondPoint );
            firstPath.Add3DPoint( firstPoint );

            PathStorage.SavePath( firstPath );
            List<Path> pathList = PathStorage.LoadPath();

            foreach( var path in pathList )
            {
                Console.WriteLine( "Start" );
                foreach( var pointers in path.PathToPoint )
                {
                    Console.WriteLine( pointers );
                }
                Console.WriteLine( "End" );

            }


        }
    }
}
