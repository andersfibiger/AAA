using System;

namespace Calculator  
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a + b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return a * b;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Math.Pow(x, exp);
        }
        public double Divide(double dividend, double divisor)
        {
            Accumulator = dividend / divisor;
            return dividend / divisor;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

    }
}
