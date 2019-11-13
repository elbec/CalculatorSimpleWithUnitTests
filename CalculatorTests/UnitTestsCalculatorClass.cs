using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CalculatorNS;

namespace CalculatorNSTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddFunction()
        {
            // Arrange
            double value1 = 4;
            double value2 = 10;
            double expectedValue = 14;
            Calculator calc = new Calculator();

            // Act
            double result = calc.add(value1, value2);

            // Assert
            Assert.AreEqual(expectedValue, result,"Add Function not working correct");
        }

        [TestMethod]
        public void TestMultiplyFunction()
        {
            // Arrange
            double value1 = 4;
            double value2 = 10;
            double expectedValue = 40;
            Calculator calc = new Calculator();

            // Act
            double result = calc.multiply(value1, value2);

            // Assert
            Assert.AreEqual(expectedValue, result, "Multiply Function not working correct");
        }

        [TestMethod]
        public void TestDivideFunction()
        {
            // Arrange
            double value1 = 20;
            double value2 = 4;
            double expectedValue = 5;
            Calculator calc = new Calculator();

            // Act
            double result = calc.divide(value1, value2);

            // Assert
            Assert.AreEqual(expectedValue, result, "Multiply Function not working correct");
        }
    }
}
