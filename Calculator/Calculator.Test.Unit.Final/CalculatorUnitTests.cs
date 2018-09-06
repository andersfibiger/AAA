using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Anders Jensen")]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }
        // Test AddPosANdNegNumbers
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        // test Subtract
        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

        //Testing Multiply
        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

        //Test Power
        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        //Test Divide
        [TestCase(4, 2, 2)]
        [TestCase(5, 2, 2.5)]
        [TestCase(7.5, 2.5, 3)]
        [TestCase(-7.5, 2.5, -3)]
        [TestCase(-5, -2, 2.5)]
        [TestCase(0, Math.PI, 0)]
        public void Divide_DivideNumbers_ResultIsCorrect(double dividend, double divisor, double result)
        {
            Assert.That(_uut.Divide(dividend, divisor), Is.EqualTo(result));
        }

        //Test DivideByZeroException
        [TestCase(0, 0)]
        [TestCase(2.5, 0)]
        [TestCase(2, 0)]
        public void Divide_DivideByZero_ResultIsException(double dividend, double divisor)
        {
            Assert.Throws<DivideByZeroException>(() => _uut.Divide(dividend, divisor));
        }

        //Test Accumulator
        [TestCase()]
        public void Test_Fresh_Accumulator()
        {
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }
        [TestCase(2,2,4)]
        [TestCase(3,3,6)]
        public void Test_Accumulator_After_Add(double a, double b, double c)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(c));
        }
        


        //Test Clear
        [TestCase()]
        public void Clear_ResultIsZero()
        {
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }
        [TestCase()]
        public void Clear_IsResultZeroAfterAccumulate()
        {
            _uut.Add(2, 2);
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }
      

    }
}
