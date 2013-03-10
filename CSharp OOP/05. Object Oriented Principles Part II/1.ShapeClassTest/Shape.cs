using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapeClassTest
{
    public abstract class Shape
    {
        protected double width;
        protected double height;

        protected Shape(double width, double height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                throw new ArgumentException("The number(s) must be bigger than 0!");
            }
        }

        public abstract double CalculateSurface();
    }
}
