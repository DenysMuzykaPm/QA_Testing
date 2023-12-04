using System;
using CalcTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RunEstimate_SimpleAddition_ReturnsCorrectResult()
        {
            AnalaizerClassLibrary ent = new AnalaizerClassLibrary();

            // Arrange
            string expression = "2 3 +";

            // Act
            string result = ent.RunEstimate(expression);

            // Assert
            Assert.AreEqual("5", result);
        }

        [TestMethod]
        public void RunEstimate_DivideByZero_ReturnsError()
        {
            AnalaizerClassLibrary ent = new AnalaizerClassLibrary();
            // Arrange
            string expression = "5 0 /";

            // Act
            string result = ent.RunEstimate(expression);

            // Assert
            Assert.IsTrue(result.StartsWith("&"));
        }

        [TestMethod]
        public void RunEstimate_InvalidExpression_ReturnsError()
        {
            AnalaizerClassLibrary ent = new AnalaizerClassLibrary();
            // Arrange
            string expression = "2 + 3"; // Missing operands

            // Act
            string result = ent.RunEstimate(expression);

            // Assert
            Assert.IsTrue(result.StartsWith("&"));
        }

        [TestMethod]
        public void RunEstimate_ComplexExpression_ReturnsCorrectResult()
        {
            AnalaizerClassLibrary ent = new AnalaizerClassLibrary();
            // Arrange
            string expression = "5 2 * 8 + 0 /";

            // Act
            string result = ent.RunEstimate(expression);

            // Assert
            Assert.AreEqual("10", result);
        }
    }
}
