using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        private List<Structure3DPoint> path3D = new List<Structure3DPoint>();

        public Path(params Structure3DPoint[] point)
        {
            for (int i = 0; i < point.Length; i++)
            {
                this.path3D.Add(point[i]);
            }
        }
       
        internal List<Structure3DPoint> Path3D
        {
            get
            {
                return this.path3D;
            }
        }

        // METHODS --------------------------------------------------------------
        public void AddPoint(Structure3DPoint point)
        {
            this.path3D.Add(point);
        }

        public void Clear()
        {
            this.path3D.Clear();
        }
    }
}
