namespace AreaCalc
{
    public class AreaCalculator
    {
        public enum FigureType
        {
            Triangle, RightTriangle, Circle, Unknown, Error 
        }
        public double calcWithOneParam(double sideRadius, out FigureType type)
        {
            sideRadius *= sideRadius;
            type = FigureType.Circle;
            return sideRadius * 3.14;
        }
        public double calcWithThreeParam(double firstSide, double secondSide, double thirdSide, out FigureType type)
        {
            var sides = new List<double> { firstSide, secondSide, thirdSide };
            if (sides.Contains(0) || sides.FindAll(x => x < 0).Count > 0) { type = FigureType.Error; return 0; } else
            {
                var max = sides.Max();
                var min = sides.FindAll(x => x < max);
                if (min.Count == 2 && Math.Pow(max, 2) == Math.Pow(min[0], 2) + Math.Pow(min[0], 2)) { type = FigureType.RightTriangle; } else { type = FigureType.Triangle; }
            }
            var halfPerim = (firstSide + secondSide + thirdSide) / 2 ;
            var multiply = halfPerim * (halfPerim - firstSide) * (halfPerim - secondSide) * (halfPerim - thirdSide);
            return Math.Sqrt(multiply);
        }
    }
}