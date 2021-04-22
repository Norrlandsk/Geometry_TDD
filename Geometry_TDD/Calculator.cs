using System.Collections.Generic;

namespace Geometry_TDD
{
#pragma warning disable RCS1102 // Make class static.

    /// <summary>
    /// Calculator class for getting area and perimeter of IShape object
    /// </summary>
    public class Calculator

    {
        /// <summary>
        /// Gets area of IShape object
        /// </summary>
        /// <param name="shape"></param>
        /// <returns>float</returns>
        public static float GetArea(IShape shape)
        {
            float result = 0;
            if (shape != null)
            {
                result = shape.Area();
            }

            return result;
        }

        /// <summary>
        /// Gets perimeter of IShape object
        /// </summary>
        /// <param name="shape"></param>
        /// <returns>float</returns>
        public static float GetPerimeter(IShape shape)
        {
            float result = 0;
            if (shape != null)
            {
                result = shape.Perimeter();
            }
            return result;
        }

        /// <summary>
        /// Gets sum of all perimeters in List&lt;IShape&gt;
        /// </summary>
        /// <param name="shapes"></param>
        /// <returns>float</returns>
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

#pragma warning restore RCS1102 // Make class static.
}