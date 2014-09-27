////TASK 4
////Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage
////with static methods to save and load paths from a text file. Use a file format of your choice.

namespace Euclidian3DSpace
{
    using System;
    using System.IO;
    
    public static class PathStorage
    {
        ////private StreamReader reader = new StreamReader(@"../../../Point_Coordinates/Coor.txt");        
        public static void SavePath(StreamWriter writer, Path toWrite)
        {
            foreach (var point in toWrite.Paths)
            {
                string line = point.Xcoor.ToString() + " " + point.Ycoor.ToString() + " " + point.Zcoor.ToString();
                writer.WriteLine(line);
            }
        }

        public static Path LoadPath(StreamReader reader)
        {
            Path export = new Path();
            using (reader)
            {                
                Point3D point = new Point3D();
                while (true)
                {
                    string[] line = reader.ReadLine().Split(' ');

                    if (line == null)
                    {
                        break;
                    }

                    point.Xcoor = Convert.ToDouble(line[0]);
                    point.Ycoor = Convert.ToDouble(line[1]);
                    point.Zcoor = Convert.ToDouble(line[2]);

                    export.AddPoints(point);          
                }                
            }

            return export;
        }
    }
}
