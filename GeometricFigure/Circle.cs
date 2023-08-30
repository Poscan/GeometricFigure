namespace GeometricFigure;

public class Circle : IFigure
{
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new Exception("Нельзя указать радиус меньше либо равным нулю");

        Radius = radius;
    }

    public double Radius { get; }

    public double Area()
    {
        return Area(Radius);
    }

    public static double Area(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}