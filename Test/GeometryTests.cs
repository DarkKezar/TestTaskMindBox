using Xunit;
using GeometryLibrary.Core;

namespace Test;

public class GeometryTests
{
    [Fact]
    public void Circle_CalculateArea_ReturnsCorrectArea()
    {
        // Arrange
        double radius = 5;
        Circle circle = new Circle(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(78.53981633974483, area);
    }

    [Fact]
    public void Triangle_CalculateArea_ReturnsCorrectArea()
    {
        // Arrange
        double a = 3;
        double b = 4;
        double c = 5;
        Triangle triangle = new Triangle(a, b, c);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.Equal(6, area);
    }

    [Fact]
    public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
    {
        // Arrange
        double a = 3;
        double b = 4;
        double c = 5;
        Triangle triangle = new Triangle(a, b, c);

        // Act
        bool isRightAngled = (triangle is IRightAngled) && triangle.IsRightAngled();

        // Assert
        Assert.True(isRightAngled);
    }
}
