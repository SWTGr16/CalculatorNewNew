using NUnit.Framework;
using CalculatorNewNew;

namespace Calculator.Test
{
    public class Tests
    {
        public Calc uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calc();
        }

        [Test]
        public void Add2and4Returns6()
        {
            Assert.That(uut.Add(2, 4), Is.EqualTo(6));
        }

        [Test]
        public void Subtract4and2Returns2()
        {
            Assert.That(uut.Subtract(4, 2), Is.EqualTo(2));
        }

        [Test]
        public void Multiply2and3Returns6()
        {
            Assert.That(uut.Multiply(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void Power4and2Returns16()
        {
            Assert.That(uut.Power(4, 2), Is.EqualTo(16));
        }

        [TestCase(3,4,5,2)]
        [TestCase(2,4,3,3)]
        public void AddAndSubtract3n4n5Returns2(double a, double b, double c, double result)
        {
            Assert.That(uut.AddAndSubtract(a, b, c), Is.EqualTo(result));
        }

        [TestCase(4,4,1)]
        [TestCase(5,0,0)]
        [TestCase(9,3,3)]
        public void Dividea_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(c));
        }
    }
}