using System;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private double baseLength;
        private double height;
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double baseLength, double height, double sideA, double sideB, double sideC)
        {
            this.baseLength = baseLength;
            this.height = height;
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }

        public double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
