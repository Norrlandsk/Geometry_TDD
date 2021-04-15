using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_TDD
{
    public class Calculator
    {
        public float GetArea(IShape shape)
        {
            return shape.Area();
             
        }

        public float GetPerimeter(IShape shape)
        {
            return shape.Perimeter();
        }

        public float GetPerimeter(List <IShape> shapes)
        {
            float perimeter = 0;

            foreach (var shape in shapes)
            {
                perimeter += shape.Perimeter();
            }
            return perimeter;
        }
    }
}
