using Geometry_TDD.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Geometry_TDD.Tests.CalculatorTests
{
    [TestClass]
    public class CalculatorTestsPerimeterList
    {
        [TestMethod, TestCategory("PerimeterList")]
        [DynamicData(nameof(PerimeterListTestCases), DynamicDataSourceType.Method)]
        public void GetPerimeterListTest_ShouldBeEqual_WhenGivenCorrectData(List<IShape> shapes, float expected)
        {
            Calculator calculator = new Calculator();
            var actual = Calculator.GetPerimeter(shapes);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, TestCategory("PerimeterList")]
        [DynamicData(nameof(PerimeterListBadTestCases), DynamicDataSourceType.Method)]
        public void GetPerimeterListTest_ShouldExcludeObjectFromCalculation_WhenObjectIsNull(List<IShape> shapes, float expected)
        {

            Calculator calculator = new Calculator();
            var actual = Calculator.GetPerimeter(shapes);
            Assert.AreEqual(expected, actual);
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
            yield return new object[] { new List<IShape> { null, new Square(10), new Triangle(10, 5) }, 70f };
            yield return new object[] { new List<IShape> { null, new Square(1), new Triangle(100, 34), new Rectangle(10, 5) }, 334f };
            yield return new object[] { new List<IShape> { new Square(5), null, new Triangle(120, 45) }, 380f };
            yield return new object[] { new List<IShape> { new Circle(30), new Square(10342), null }, 41556f };
            yield return new object[] { new List<IShape> { new Rectangle(-5,2), null, new Triangle(6543, 55) }, 19623f };
            yield return new object[] { new List<IShape> { null, null, null }, 0f };
        }
    }
}