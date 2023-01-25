using AreaCalc;
namespace CalcTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void circleByRadius()
        {
            var areaTester = new AreaCalculator();
            var radius = 12;
            var result = areaTester.calcWithOneParam(radius, out AreaCalculator.FigureType type);
            var expect = (452.16, AreaCalculator.FigureType.Circle);
            Assert.AreEqual(expect, (result, type));
        }

        [TestMethod]
        public void triangleFromTwoParams()
        {
            var areaTester = new AreaCalculator();
            var firstSide = 13;
            var secondSide = 14;
            var thirdSide = 15;
            var result = areaTester.calcWithThreeParam(firstSide, secondSide, thirdSide, out AreaCalculator.FigureType type);
            var expect = (84, AreaCalculator.FigureType.Triangle);
            Assert.AreEqual(expect, (result, type));
        }
    }
}