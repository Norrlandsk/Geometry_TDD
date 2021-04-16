using Geometry_TDD.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Geometry_TDD.Tests.CalculatorTests
{
    [TestClass]
    public class CalculatorTestsPerimeterList
    {
        [TestMethod, TestCategory("Calculator")]
        [DynamicData(nameof(PerimeterListTestCases), DynamicDataSourceType.Method)]
        public void GetPerimeterListTest_ShouldBeEqual_WhenGivenCorrectData(List<IShape> shapes, float expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.GetPerimeter(shapes);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, TestCategory("Calculator")]
        [DynamicData(nameof(PerimeterListBadTestCases), DynamicDataSourceType.Method)]
        public void GetPerimeterListTest_ShouldBeEqual_WhenGivenBadData(List<IShape> shapes, float expected)
        {
            //TODO: Fix so that it behaves as expected
            Calculator calculator = new Calculator();
            var actual = calculator.GetPerimeter(shapes);
            Assert.AreNotEqual(expected, actual);
        }

        
        private static IEnumerable<object[]> PerimeterListTestCases()
        {
            yield return new object[] { new List<IShape> { new Rectangle(10, 5), new Square(10), new Triangle(10, 5) }, 100f };
            yield return new object[] { new List<IShape> { new Circle(5), new Square(1), new Triangle(100, 34), new Rectangle(10, 5) }, 365f };
            yield return new object[] { new List<IShape> { new Square(77), new Square(10), new Triangle(120, 45) }, 708f };
            yield return new object[] { new List<IShape> { new Circle(346), new Square(10342), new Triangle(6543, 55) }, 63171f };
        }

        private static IEnumerable<object[]> PerimeterListBadTestCases()
        {
            yield return new object[] { new List<IShape> { new Rectangle(float.MaxValue, 5), new Square(10), new Triangle(10, 5) }, 100f };
            yield return new object[] { new List<IShape> { new Circle(float.MinValue), new Square(1), new Triangle(100, 34), new Rectangle(10, 5) }, 365f };
            yield return new object[] { new List<IShape> { new Square(float.PositiveInfinity), new Square(10), new Triangle(120, 45) }, 708f };
            yield return new object[] { new List<IShape> { new Circle(float.NegativeInfinity), new Square(10342), new Triangle(6543, 55) }, 63171f };
            yield return new object[] { new List<IShape> { new Rectangle(-5,2), new Square(10342), new Triangle(6543, 55) }, 63171f };
        }
    }
}