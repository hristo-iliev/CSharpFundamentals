//TASK 3
//Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace Euclidian3DSpace
{
    using System;
    
    public class Distance
    {
        public double CalculateDistance(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt(Math.Pow((first.Xcoor - second.Xcoor), 2) + 
                Math.Pow((first.Ycoor - second.Ycoor), 2) + Math.Pow((first.Zcoor - second.Zcoor), 2));

            return distance;
        }
    }
}
