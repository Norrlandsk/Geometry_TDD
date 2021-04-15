﻿using Geometry_TDD;
using Geometry_TDD.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Geometry_TDD.Tests
{
    [TestClass]
    public class CalculatorTestsPerimeter
    {
        [DataTestMethod, TestCategory("Calculator")]
        [DynamicData(nameof(PerimeterTestCases), DynamicDataSourceType.Method)]
        public void GetPerimeterTest_ShouldBeEqual(IShape shape, float expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.GetPerimeter(shape);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod, TestCategory("Calculator")]
        [DynamicData(nameof(PerimeterTestCases), DynamicDataSourceType.Method)]
        public void GetPerimeterTest_ShouldNotBeEqual(IShape shape, float expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.GetPerimeter(shape);
            Assert.AreNotEqual(expected, actual + 1);
        }

        private static IEnumerable<object[]> PerimeterTestCases()
        {
            yield return new object[] { new Rectangle(10, 5), 30f };
            yield return new object[] { new Circle(15), 94f };
            yield return new object[] { new Square(15), 60f };
            yield return new object[] { new Triangle(10, 5), 30f };
        }
    }
}