using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class PathStorage
    {
        public static void SavePath(string pathToDirectory, Path points)
        {
            List<Structure3DPoint> listOfPoints = points.Path3D;
            StreamWriter write = new StreamWriter(pathToDirectory);
            using (write)
            {
                for (int i = 0; i < listOfPoints.Count; i++)
                {
                    write.WriteLine(listOfPoints[i].ToString(), true);
                }
            }
        }

        public static Path LoadPath(string pathToFile)
        {
            if (pathToFile == string.Empty || !File.Exists(pathToFile))
            {
                throw new ArgumentException("The path is wrong or file doesn't exist!");
            }

            StreamReader read = new StreamReader(pathToFile);
            Path pointsSpace = new Path();

            string line;
            using (read)
            {
                line = read.ReadLine();
                while (line != null)
                {
                    string[] coordinates = line.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                    
                    Structure3DPoint point = 
                        new Structure3DPoint(int.Parse(coordinates[0]), int.Parse(coordinates[1]), int.Parse(coordinates[2]));
                    pointsSpace.AddPoint(point);

                    line = read.ReadLine();
                }
            }
            return pointsSpace;
        }
    }
}
