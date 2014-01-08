using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileExtentionUtils.GetFileExtension("example"));
            Console.WriteLine(FileExtentionUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileExtentionUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileExtentionUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileExtentionUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileExtentionUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                CalcDistanceUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                CalcDistanceUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Cuboide cuboide = new Cuboide(3, 4, 0);

            Console.WriteLine("Volume = {0:f2}", cuboide.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", cuboide.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", cuboide.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", cuboide.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", cuboide.CalcDiagonalYZ());
        }
    }
}
