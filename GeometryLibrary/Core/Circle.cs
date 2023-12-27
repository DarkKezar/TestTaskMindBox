
namespace GeometryLibrary.Core;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}