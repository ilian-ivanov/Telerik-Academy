using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public struct Structure3DPoint
    {
        // FIELDS --------------------------------------------------------
        private int xCoord; 
        private int yCoord;
        private int zCoord;
        private static readonly Structure3DPoint point0 = new Structure3DPoint(0, 0, 0); 

        // CONSTRUCTORS ------------------------------------------------------
        public Structure3DPoint(int xCoord, int yCoord, int zCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            this.zCoord = zCoord;
        }

        // PROPERTIES ----------------------------------------------------------
        public int XCoord
        {
            get
            {
                return this.xCoord;
            }
            set
            {
                this.xCoord = value;
            }
        }

        public int YCoord
        {
            get
            {
                return this.yCoord;
            }
            set
            {
                this.yCoord = value;
            }
        }

        public int ZCoord
        {
            get
            {
                return this.zCoord;
            }
            set
            {
                this.zCoord = value;
            }
        }

        public static Structure3DPoint Point0
        {
            get
            {
                return point0;
            }
        }

        // METHODS ------------------------------------------------------
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.xCoord, this.yCoord, this.zCoord);
        }
    }
}
