using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeAreaSearchLibrary
{
    public class Triangle : GeometricShape
    {
        private double _a;
        private double _b;
        private double _c;
        private double _angleA;
        private double _angleB;
        private double _angleC;

        public double A
        {
            get => _a;
        }
        public double B
        {
            get => _b;
        }
        public double C
        {
            get => _c;
        }
        public double AngleA
        {
            get => _angleA;
        }
        public double AngleB
        {
            get => _angleB;
        }
        public double AngleC
        {
            get => _angleC;
        }

        public Triangle(double a, double b, double c, double angleA, double angleB, double angleC)
        {
            CorrectSidesCheck(a, b, c);
            CorrectAnglesCheck(angleA, angleB, angleC);

            SetSides(a, b, c);
            SetAngles(angleA, angleB, angleC);
        }

        public override double GetArea()
        {
            double p = (A + B + C)/2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }

        public void SetSides(double a, double b, double c)
        {
            CorrectSidesCheck(a, b, c);
            _a = a;
            _b = b;
            _c = c;
        }
        public void SetAngles(double angleA, double angleB, double angleC)
        {
            CorrectAnglesCheck(angleA, angleB, angleC);
            _angleA = angleA;
            _angleB = angleB;
            _angleC = angleC;
        }

        private void CorrectSidesCheck(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("There is no triangle with such sides");
            }
        }
        private void CorrectAnglesCheck(double angleA, double angleB, double angleC)
        {
            if (angleA + angleB + angleC != 180)
            {
                throw new ArgumentException("There is no triangle with such angles");
            }
        }
        public bool IsRightAngled()
        {
            return AngleA == 90 || AngleB == 90 || AngleC == 90;
        }
    }
}
