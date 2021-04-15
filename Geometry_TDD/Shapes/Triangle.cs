namespace Geometry_TDD.Shapes
{
    public class Triangle : IShape
    {
        public float Base { get; set; }
        public float Height { get; set; }

        public Triangle(float tbase, float height)
        {
            Base = tbase;
            Height = height;
        }

        public float Area()
        {
            float area = (Base * Height) / 2;
            return area;
        }

        public float Perimeter()
        {
            float perimeter = Base * 3;
            return perimeter;
        }
    }
}