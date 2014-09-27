////TASK 1
////Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
////Implement the ToString() to enable printing a 3D point.

////TASK 2
////Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
////Add a static property to return the point O.

namespace Euclidian3DSpace
{    
    public struct Point3D
    {
        ////{X, Y, Z}
        private static readonly Point3D Point0 = new Point3D(0, 0, 0);
        private double x;
        private double y;
        private double z;        

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;                        
        }

        public static string GetPoint0
        {
            get
            {
                return Point0.ToString();
            }
        }

        public double Xcoor
        { 
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        public double Ycoor
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        public double Zcoor
        {
            get
            {
                return this.z;
            }

            set
            {
                this.z = value;
            }
        }

        public override string ToString()
        {
            string result = this.x.ToString() + ", " + this.y.ToString() + ", " + this.z.ToString();
            return result;
        }
    }
}
