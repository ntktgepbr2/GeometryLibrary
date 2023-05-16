using NUnit.Framework;

namespace GeometryLibrary.UnitTesting
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CalculateCircleArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [Test]
        public void CalculateTriangleArea_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new(sideA, sideB, sideC);
            double expectedArea = 6;

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [Test]
        public void IsRightTriangle_ReturnsTrueForRightTriangle()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void IsRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            // Arrange
            double sideA = 4;
            double sideB = 5;
            double sideC = 6;
            Triangle triangle = new(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(isRightTriangle);
        }
    }
}