using System;
using System.Threading;

namespace cSharpLerner
{
    public static class Calculator
    {
        public static double Avarage(int[] numbers)
        {
            int sum = 0;
            foreach (var VARIABLE in numbers)
            {
                sum += VARIABLE;
            }

            return (double)sum/numbers.Length;
        }

        public static bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;

            if (divisor == 0) return false;
            result = divisible / divisor;
            return true;
        }
        public static double Avarage2(params int[] numbers)
        {
            int sum = 0;
            foreach (var VARIABLE in numbers)
            {
                sum += VARIABLE;
            }

            return (double)sum / numbers.Length;
        }
        public static double CalcTriangleSquare(double a , double b , double c)
        {
            double p = 0.5 * (a + b + c);
            return Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
        }

        public static double CalcTriangleSquare(double b, double h)
        {

            return 0.5*b*h;
        }        
        public static double CalcTriangleSquare(double ab, double ac, int angle)
        {
            double rads = angle * Math.PI / 180;
            return 0.5*ab*ac*Math.Sin(rads);
        }


    }
}