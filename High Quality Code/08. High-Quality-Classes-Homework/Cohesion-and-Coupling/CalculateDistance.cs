namespace CohesionAndCoupling
{
    using System;

    public class CalculateDistance
    {
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distanceX = x2 - x1;
            double distanceY = y2 - y1;
            double distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distanceX = x2 - x1;
            double distanceY = y2 - y1;
            double distanceZ = z2 - z1;
            double distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY) + (distanceZ * distanceZ));
            return distance;
        }       
    }
}
