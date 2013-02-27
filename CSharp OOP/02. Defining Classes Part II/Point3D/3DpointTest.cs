using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class _3DpointTest
    {
        static void Main()
        {
            Structure3DPoint pointA = new Structure3DPoint();
            Structure3DPoint pointB = new Structure3DPoint(1,1,1);
            double distance = 0;
            Console.WriteLine(pointB);
            Console.WriteLine(Structure3DPoint.Point0);
            
            distance = Distance.FindDistance(pointA, pointB);
            Console.WriteLine(distance);

            Path space = new Path(pointA, pointB);
            
            PathStorage.SavePath("../../SavePath.txt", space);

            Path loadPath = new Path();

            loadPath = PathStorage.LoadPath("../../LoadPath.txt");
            PathStorage.SavePath("../../NewPath", loadPath);
        }
    }
}
