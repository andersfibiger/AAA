using System;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        //blackbox since it is private
        private Calculator uut_;

        [SetUp]
        public void Setup()
        {
            uut_ = new Calculator();
        }

        [Test]
        public void Add_Add2and4_returns6()
        {
            Assert.That(uut_.Add(2, 4), Is.EqualTo(6));
        }
    }
}
