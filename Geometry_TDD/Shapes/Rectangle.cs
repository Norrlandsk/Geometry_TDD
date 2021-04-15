using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_TDD.Shapes
{
    public class Rectangle : IShape
    {

        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float width,float height)
        {
            Width = width;
            Height = height;
        }

        public float Area()
        {
            float area = Width * Height;
            return area;
        }

        public float Perimeter()
        {
            float perimeter = (Width + Height) * 2;
            return perimeter;
        }
    }
}
