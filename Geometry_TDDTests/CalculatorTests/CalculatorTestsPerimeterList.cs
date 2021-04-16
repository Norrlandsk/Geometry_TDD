using Geometry_TDD.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Geometry_TDD.Tests.CalculatorTests
{
    [TestClass]
    public class CalculatorTestsPerimeterList
    {
        [TestMethod, TestCategory("Calculator")]
        [DynamicData(nameof(PerimeterListTestCases), DynamicDataSourceType.Method)]
        public void GetPerimeterListTest_ShouldBeEqual(List<IShape> shapes, float expected, string caseName)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.GetPerimeter(shapes);
            Assert.AreEqual(expected, actual, caseName);
        }

        [TestMethod, TestCategory("Calculator")]
        [DynamicData(nameof(PerimeterListTestCases), DynamicDataSourceType.Method)]
        public void GetPerimeterListTest_ShouldNotBeEqual(List<IShape> shapes, float expected, string caseName)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.GetPerimeter(shapes);
            Assert.AreNotEqual(expected, actual+1, caseName);
        }



        private static IEnumerable<object[]> PerimeterListTestCases()
        {
            yield return new object[] { new List<IShape> { new Rectangle(10, 5), new Square(10), new Triangle(10, 5) }, 100f, "Case 1" };
            yield return new object[] { new List<IShape> { new Circle(5), new Square(1), new Triangle(100, 34), new Rectangle(10, 5) }, 365f, "Case 2" };
            yield return new object[] { new List<IShape> { new Square(77), new Square(10), new Triangle(120, 45) }, 708f, "Case 3" };
            yield return new object[] { new List<IShape> { new Circle(346), new Square(10342), new Triangle(6543, 55) }, 63171f, "Case 4" };
        }
    }
}