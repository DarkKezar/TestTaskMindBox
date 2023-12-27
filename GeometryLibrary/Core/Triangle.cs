
namespace GeometryLibrary.Core;

public class Triangle : IShape, IRightAngled
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public double CalculateArea()
    {
        double s = (_a + _b + _c) / 2;
        return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
    }

    public bool IsRightAngled()
    {
        double[] sides = { _a, _b, _c };
        Array.Sort(sides);

        return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }
}