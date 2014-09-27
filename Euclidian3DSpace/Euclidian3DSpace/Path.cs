////TASK 4
////Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage
////with static methods to save and load paths from a text file. Use a file format of your choice.

namespace Euclidian3DSpace
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> path = new List<Point3D>();

        public List<Point3D> Paths
        {
            get
            {
                return this.path;
            }

            private set
            {
                this.path = value;
            }
        }

        public int Count
        {
            get
            {
                return this.path.Count;
            }        
        }
        
        public void AddPoints(Point3D currentPoint)
        {
            this.path.Add(currentPoint);
        }
    }
}
