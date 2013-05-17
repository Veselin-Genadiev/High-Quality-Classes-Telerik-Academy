using System;

namespace CohesionAndCoupling
{
    class TestClasses
    {
        static void Main()
        {
            Console.WriteLine(FileExtensions.GetFileExtension("example"));
            Console.WriteLine(FileExtensions.GetFileExtension("example.pdf"));
            Console.WriteLine(FileExtensions.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                DistanceCalculator.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                DistanceCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Cube cube = new Cube(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", cube.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", cube.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", cube.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", cube.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", cube.CalcDiagonalYZ());
        }
    }
}
