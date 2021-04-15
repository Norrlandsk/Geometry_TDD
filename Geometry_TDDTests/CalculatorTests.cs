using Geometry_TDD.Shapes;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Geometry_TDD.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DynamicData(nameof(AreaTestCases))]
        public void GetAreaTest(IShape shape, float expected,string displayName)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.GetArea(shape);
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<object[]> AreaTestCases
        {

            get
            {
                yield return new object[] { new Rectangle(10, 5), 50f, "Rectangle" };
                yield return new object[] { new Circle(15), 701f, "Circle" };
            }
        }
        
    }
}