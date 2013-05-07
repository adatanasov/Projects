namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            ////Console.WriteLine(FileNameUtilities.GetFileExtension("example"));
            Console.WriteLine(FileNameUtilities.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameUtilities.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameUtilities.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameUtilities.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameUtilities.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", CalculateDistance.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", CalculateDistance.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Shape3D myShape = new Shape3D(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", myShape.CalcVolume());

            Console.WriteLine(
                "Diagonal XYZ = {0:f2}",
                CalculateDistance.CalcDistance3D(0d, 0d, 0d, myShape.Width, myShape.Height, myShape.Depth));
            Console.WriteLine(
                "Diagonal XY = {0:f2}",
                CalculateDistance.CalcDistance2D(0d, 0d, myShape.Width, myShape.Height));
            Console.WriteLine(
                "Diagonal XZ = {0:f2}",
                CalculateDistance.CalcDistance2D(0d, 0d, myShape.Width, myShape.Depth));
            Console.WriteLine(
                "Diagonal YZ = {0:f2}",
                CalculateDistance.CalcDistance2D(0d, 0d, myShape.Height, myShape.Depth));
        }
    }
}
