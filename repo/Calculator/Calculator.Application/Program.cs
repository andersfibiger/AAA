using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("TESTS for Add");
            Console.WriteLine($"2+2 = {calc.Add(2, 2)}");
            Console.WriteLine($"2-3 = {calc.Add(2, -3)}");
            Console.WriteLine($"-4-4 = {calc.Add(-4, -4)}");
            Console.WriteLine($"-2+2 = {calc.Add(-2, 2)}\n");

            Console.WriteLine("TESTS for subtract");
            Console.WriteLine($"2-2 = {calc.Subtract(2, 2)}");
            Console.WriteLine($"2-(-2) = {calc.Subtract(2, -2)}");
            Console.WriteLine($"-12-2 = {calc.Subtract(-12, 2)}\n");

            Console.WriteLine("TESTS for multiply");
            Console.WriteLine($"2*2 = {calc.Multiply(2, 2)}");
            Console.WriteLine($"-2*2 = {calc.Multiply(-2, 2)}");
            Console.WriteLine($"0*(-2) = {calc.Multiply(0, -2)}");
            Console.WriteLine($"-10*(-10) = {calc.Multiply(-10, -10)}\n");

            Console.WriteLine("TESTS for power");
            Console.WriteLine($"2^2 = {calc.Power(2, 2)}");
            Console.WriteLine($"2^(-2) = {calc.Power(2, -2)}");
            Console.WriteLine($"-2^2 = {calc.Power(-2, 2)}");
            Console.WriteLine($"10^2 = {calc.Power(10, 2)}");
        }
    }
}
