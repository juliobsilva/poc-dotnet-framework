// WindowsFormsApp.Tests/CalculatorTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp;

namespace WindowsFormsApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ShouldReturnSum_WhenGivenTwoIntegers()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }
    }
}
