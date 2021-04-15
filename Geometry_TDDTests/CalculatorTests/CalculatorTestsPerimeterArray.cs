using Geometry_TDD.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Geometry_TDD.Tests.CalculatorTests
{
    [TestClass]
    public class CalculatorTestsPerimeterArray
    {
        List<IShape> shapes = new List<IShape>();
        [TestMethod, TestCategory("Calculator")]
        [DataRow()]
        public void GetPerimeterListTest_ShouldBeEqual(List<IShape> shapes, List<float> expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.GetPerimeter(shapes);
            Assert.AreEqual(expected, actual);
        }



        //private static IEnumerable<object[]> PerimeterListTestCases()
        //{
        //    yield return new object[] { new List<IShape>
        //    {
        //        new Rectangle(10, 5),
        //        new Square(10),
        //        new Triangle(10, 5)
        //    },
        //     new List<float>{3,54,6}
        //    };
        //}
    }
}