// JENKIIIIINS
using System;

namespace Calculator  
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Add(double a)
        {
            Accumulator = a + Accumulator;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Subtract(double a)
        {
            Accumulator = a - Accumulator;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double a)
        {
            Accumulator = a * Accumulator;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Power(double x)
        {
            Accumulator = Math.Pow(x, Accumulator);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("You FOOL! You divided by zero. You've doomed us all!");
            }
            Accumulator = dividend / divisor;
            return Accumulator;
        }

        public double Divide(double d)
        {
            if (Accumulator == 0)
            {
                throw new DivideByZeroException("You FOOL! You divided by zero. You've doomed us all!");
            }
            Accumulator = d / Accumulator;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

    }
}
