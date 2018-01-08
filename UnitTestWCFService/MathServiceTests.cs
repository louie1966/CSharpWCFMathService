using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathService.Tests
{
    [TestClass()]
    public class MathServiceTests
    {
        [TestMethod()]
        public void MarhService_Can_Do_Addition()
        {
            // Arrange
            MathService mathService = new MathService();

            // Act
            int result = mathService.Add(10, 5);

            // Assert
            Assert.AreEqual(expected: 15, actual: result);

        }

        [TestMethod()]
        public void MarhService_Can_Do_Devision()
        {
            // Arrange
            MathService mathService = new MathService();

            // Act
            int result = mathService.Devide(10, 5);

            // Assert
            Assert.AreEqual(expected: 2, actual: result);
        }

        [TestMethod()]
        public void MarhService_Can_Do_Devision_Resulting_Double()
        {
            // Arrange
            MathService mathService = new MathService();

            // Act
            double result = mathService.Devide(5, 10);

            // Assert
            Assert.AreEqual(expected: 0.5f, actual: result);
        }

        [TestMethod()]
        public void MarhService_Can_Do_Multiplication()
        {
            // Arrange
            MathService mathService = new MathService();

            // Act
            int result = mathService.Multiply(10, 5);

            // Assert
            Assert.AreEqual(expected: 50, actual: result);
        }

        [TestMethod()]
        public void MarhService_Can_Do_Subtraction()
        {
            // Arrange
            MathService mathService = new MathService();

            // Act
            int result = mathService.Subtract(10, 5);

            // Assert
            Assert.AreEqual(expected: 5, actual: result);
        }
    }
}