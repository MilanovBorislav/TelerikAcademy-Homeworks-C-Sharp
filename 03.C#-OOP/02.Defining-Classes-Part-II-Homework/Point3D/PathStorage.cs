using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Point3D
{
    class PathStorage
    {
        public static void SavePath(Path path)
        {
            using( StreamWriter writer = new StreamWriter( @"..\..\SavedPaths.txt" ) )
            {
                foreach( var point in path.PathToPoint)
                {
                    writer.WriteLine( point ); 
                }
            }
        }

        public static List<Path> LoadPath()
        {
            Path loadPath = new Path();
            List<Path> pathsLoaded = new List<Path>();
            using( StreamReader reader = new StreamReader( @"..\..\LoadedPaths.txt" ) )
            {
                string line = reader.ReadLine();
                while( line != null )
                {
                    if( line != "*" )
                    {
                        _3DPoint point = new _3DPoint();
                        string[] points = line.Split( '-' );
                        point.X_Coordinate = int.Parse( points[0] );
                        point.X_Coordinate = int.Parse( points[1] );
                        point.X_Coordinate = int.Parse( points[2] );
                        loadPath.Add3DPoint( point );
                    }
                    else
                    {
                        pathsLoaded.Add( loadPath );
                        loadPath = new Path();
                    }
                    line = reader.ReadLine();
                }
            }
            return pathsLoaded;
        }





    }
}
