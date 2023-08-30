using System.Collections;
using GeometricFigure;

namespace Tests
{
    [TestFixture]
    public class AreaTests
    {
        [TestCaseSource(typeof(AreaData), nameof(AreaData.TestCases))]
        public bool DivideTest(IFigure figure, double result)
        {
            var area = figure.Area();
            return area - result < Math.Pow(1, -10);
        }
    }

    public class AreaData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new Circle(2), 4 * Math.PI).Returns(true);
                yield return new TestCaseData(new Triangle(3, 4, 5), 6).Returns(true);
            }
        }
    }
}