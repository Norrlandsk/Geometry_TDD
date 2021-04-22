using System.Collections.Generic;

namespace Geometry_TDD
{
    public class Calculator
    {
        public float GetArea(IShape shape)
        {
            float result = 0;
            if (shape != null)
            {
                result = shape.Area();
            }

            return result;
        }

        public float GetPerimeter(IShape shape)
        {
            float result = 0;
            if (shape != null)
            {
                result = shape.Perimeter();
            }
            return result;
        }

        public static float GetPerimeter(List<IShape> shapes)
        {
            float result = 0;

            foreach (var shape in shapes)
            {
                if (shape == null)
                {
                    result += 0;
                }
                else
                {
                    result += shape.Perimeter();
                }
            }

            return result;
        }
    }
}