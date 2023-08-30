namespace GeometricFigure;

public class Triangle : IFigure
{
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new Exception("Длина не может быть меньше, либо равной нулю");

        if (a + b < c || a + c < b || b + c < a)
            throw new Exception("Такого треугольника не существует");

        A = a;
        B = b;
        C = c;
    }

    public double A { get; }
    public double B { get; }
    public double C { get; }

    public bool IsRight => Math.Abs(Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) < Math.Pow(1, -10) ||
                           Math.Abs(Math.Abs(Math.Pow(A, 2) - Math.Pow(B, 2)) - Math.Pow(C, 2)) < Math.Pow(1, -10);

    public double Area()
    {
        return Area(A, B, C);
    }

    public static double Area(double a, double b, double c)
    {
        var p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}