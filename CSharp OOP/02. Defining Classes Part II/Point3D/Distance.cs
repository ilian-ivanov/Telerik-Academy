using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public static class Distance
    {
        public static double FindDistance(Structure3DPoint pointA, Structure3DPoint pointB)
        {
            int deltaX = pointB.XCoord - pointA.XCoord;
            int deltaY = pointB.YCoord - pointA.YCoord;
            int deltaZ = pointB.ZCoord - pointA.ZCoord;

            return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));
        }
    }
}
