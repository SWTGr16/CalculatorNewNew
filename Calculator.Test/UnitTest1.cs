using NUnit.Framework;
using CalculatorNewNew;

namespace Calculator.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add2and4Returns6()
        {
            var uut = new Calc();

            Assert.That(uut.Add(2, 4), Is.EqualTo(6));
        }

        [Test]
        public void Subtract4and2Returns2()
        {
            var uut = new Calc();
            Assert.That(uut.Subtract(4, 2), Is.EqualTo(2));
        }

        [Test]
        public void Multiply2and3Returns6()
        {
            var uut = new Calc();
            Assert.That(uut.Multiply(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void Power4and2Returns16()
        {
            var uut = new Calc();
            Assert.That(uut.Power(4, 2), Is.EqualTo(16));
        }
    }
}