using System;

namespace Geometry_TDD.Shapes
{
    public class Circle : IShape
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Area()
        {
            float area = MathF.PI * Radius * Radius;
            return MathF.Round(area);
        }

        public float Perimeter()
        {
            float perimeter = 2 * MathF.PI * Radius;
            return MathF.Round(perimeter);
        }
    }
}