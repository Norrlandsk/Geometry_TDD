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
                if (result is
                    float.MinValue or
                    float.MaxValue or
                    float.PositiveInfinity or
                    float.NegativeInfinity or
                    < 0) { result = 0; }
            }

            return result;
        }

        public float GetPerimeter(IShape shape)
        {
            var result = shape.Perimeter();
            if (result is
                float.MinValue or
                float.MaxValue or
                float.PositiveInfinity or
                float.NegativeInfinity or
                < 0) { result = 0; }
            return result;
        }


        
        public float GetPerimeter(List<IShape> shapes)
        {
            float result = 0;

            foreach (var shape in shapes)
            {
                result += shape.Perimeter();
            }
            if (result is
                float.MinValue or
                float.MaxValue or
                float.PositiveInfinity or
                float.NegativeInfinity or
                < 0) { result = 0; }
            return result;
        }
    }
}