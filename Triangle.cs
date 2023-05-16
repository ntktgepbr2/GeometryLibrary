namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        public bool IsRightTriangle()
        {
            double aSquare = _sideA * _sideA;
            double bSquare = _sideB * _sideB;
            double cSquare = _sideC * _sideC;

            return aSquare.Equals(bSquare + cSquare) || bSquare.Equals(aSquare + cSquare) || cSquare.Equals(aSquare + bSquare);
        }
    }
}