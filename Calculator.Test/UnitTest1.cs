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

        [TestCase(5, 10, 15)]
        [TestCase(22, 25, 47)]
        [TestCase(100, 11, 111)]
        public void Adda_tob_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Add(a,b), Is.EqualTo(c));
        }

        [TestCase(5, 1, 4)]
        [TestCase(22, 20, 2)]
        [TestCase(100, 10, 90)]
        public void Subtracta_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(1, 1, 1)]
        [TestCase(2, 20, 40)]
        [TestCase(10, 10, 100)]
        public void Multiplya_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(4,2,16)]
        [TestCase(5,3,125)]
        [TestCase(6,4,1296)]
        public void Powera_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(c));
        }

        [TestCase(3,4,5,2)]
        [TestCase(2,4,3,3)]
        [TestCase(8,6,9,5)]
        public void Adda_tob_Subtractc_Returnsd(double a, double b, double c, double d)
        {
            Assert.That(uut.AddAndSubtract(a, b, c), Is.EqualTo(d));
        }

        [TestCase(4,4,1)]
        [TestCase(5,0,0)]
        [TestCase(9,3,3)]
        public void Dividea_withb_Returnsc(double a, double b, double c)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(c));
        }

        [TestCase(7,7)]
        [TestCase(8,8)]
        [TestCase(9,9)]
        public void AddAccumulator_inputa_returnsb_accumulatorValue0(double a, double b)
        {
            Assert.That(uut.AddAccumulator(a), Is.EqualTo(b));
        }

        [TestCase(9,9,18)]
        [TestCase(10,10,20)]
        [TestCase(11,11,22)]
        public void AddAccumulator_inputa_returnsc_accumulatorValueb(double a, double b, double c)
        {
            uut.AddAccumulator(b);
            Assert.That(uut.AddAccumulator(a), Is.EqualTo(c));
        }
    }
}