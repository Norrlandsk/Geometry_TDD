﻿using Geometry_TDD.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Geometry_TDD.Tests
{
    [TestClass()]
    public class CalculatorTestsArea
    {
        [DataTestMethod, TestCategory("Calculator")]
        [DynamicData(nameof(AreaTestCases), DynamicDataSourceType.Method)]
        public void GetAreaTest_ShouldBeEqual(IShape shape, float expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.GetArea(shape);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod, TestCategory("Calculator")]
        [DynamicData(nameof(AreaTestCases), DynamicDataSourceType.Method)]
        public void GetAreaTest_ShouldNotBeEqual(IShape shape, float expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.GetArea(shape);
            Assert.AreNotEqual(expected, actual + 1);
        }

        private static IEnumerable<object[]> AreaTestCases()
        {
            yield return new object[] { new Rectangle(10, 5), 50f };
            yield return new object[] { new Circle(15), 707f };
            yield return new object[] { new Square(15), 225f };
            yield return new object[] { new Triangle(10, 5), 25f };
        }
    }
}