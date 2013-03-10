using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ShapeClassTest
{
    class Test
    {
        static void Main()
        {

            Triangle triangle = new Triangle(2, 1);
            //Console.WriteLine(triangle.Width);
            Console.Write("The surface of triangle is: ");
            Console.WriteLine(triangle.CalculateSurface());

            Rectangle rectangle = new Rectangle(1,3);
            rectangle.Width = 5;
            Console.Write("The surface of rectangle is: ");
            Console.WriteLine(rectangle.CalculateSurface());
           
            

            Circle circle = new Circle(1);
            circle.Radius = 2;
            Console.Write("The surface of circle is: ");
            Console.WriteLine(circle.CalculateSurface());

            Console.WriteLine("Again the same surfaces:");
            Shape[] shapes = { triangle, rectangle, circle };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
