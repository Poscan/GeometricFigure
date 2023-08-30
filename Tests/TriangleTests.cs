using GeometricFigure;

namespace Tests;

public class TriangleTests
{
    [TestCase(3, 4, 5)]
    [TestCase(4, 5, 3)]
    [TestCase(5, 3, 4)]
    public void IsRightTriangle_IsTrue(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);

        Assert.IsTrue(triangle.IsRight);
    }

    [Test]
    public void IsRightTriangle_IsFalse()
    {
        var triangle = new Triangle(3, 3, 4);

        Assert.IsFalse(triangle.IsRight);
    }

    [Test]
    public void Construct_ThrowException_WhenTriangleNotReal()
    {
        var ex = Assert.Throws<Exception>(() => new Triangle(1, 2, 4));

        Assert.That(ex?.Message, Is.EqualTo("Такого треугольника не существует"));
    }

    [Test]
    public void Construct_ThrowException_WhenLengthNegative()
    {
        var ex = Assert.Throws<Exception>(() => new Triangle(-1, 2, 4));

        Assert.That(ex?.Message, Is.EqualTo("Длина не может быть меньше, либо равной нулю"));
    }
}