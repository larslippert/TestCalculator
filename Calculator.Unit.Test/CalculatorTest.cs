using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCalculator;
using NUnit.Framework;


namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        private CalculatorClass _uut;
        [SetUp]
        public void SetUp()
        {
            _uut = new CalculatorClass();
        }

        [Test]
        public void Add_2plus2_equals4()
        {
            Assert.That(_uut.Add(2,2), Is.EqualTo(4));
        }

        [Test]
        public void Subtract_2minus1_equals1()
        {
            Assert.That(_uut.Subtract(2,1), Is.EqualTo(1));
        }

        [Test]
        public void Multiply_2times8_equals16()
        {
            Assert.That(_uut.Multiply(2,8), Is.EqualTo(16));
        }

        [Test]
        public void Power_2power3_equals8()
        {
            Assert.That(_uut.Power(2,3), Is.EqualTo(8));
        }
    }
}
