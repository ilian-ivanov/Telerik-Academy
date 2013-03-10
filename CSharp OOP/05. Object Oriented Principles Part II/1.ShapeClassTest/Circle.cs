using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapeClassTest
{
    public class Circle : Shape
    {

        // we have only one radius so we make this constructor public and other private, in that way we can take the base constructor
        // and make check for radius to be positive in base class
        public Circle(double radius)
            : this(radius, radius)
        {
        }

        private Circle(double radius, double radius2) : base(radius, radius2)
        {
        }

        public double Radius
        {
            get { return this.width; }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("The radius must be bigger than 0!");
                }
            }
        }


        public override double CalculateSurface()
        {
            return Math.PI * this.width * this.width;
        }

    }
}
