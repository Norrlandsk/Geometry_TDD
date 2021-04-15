namespace Geometry_TDD.Shapes
{
    public class Square : IShape
    {
        public float Side { get; set; }

        public Square(float side)
        {
            Side = side;
        }

        public float Area()
        {
            float area = Side * Side;
            return area;
        }

        public float Perimeter()
        {
            float perimeter = Side * 4;
            return perimeter;
        }
    }
}