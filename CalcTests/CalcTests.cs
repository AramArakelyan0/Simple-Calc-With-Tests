using NUnit.Framework;
using Calc;

namespace CalcTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void addition_test()
        {
            int result = Calculator.Add(3 , 12);
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void subtraction_test()
        {
            int result = Calculator.Subtract(7, 20);
            Assert.That(result, Is.EqualTo(-13));
        }

        [Test]
        public void multiplication_test()
        {
            int result = Calculator.Multiply(4, 8);
            Assert.That(result, Is.EqualTo(32));
        }

        [TestCase(12, 4, 3)]
        [TestCase(13,4, 3)]
        public void division_test(int a, int b, int expected)
        {
            int result = Calculator.Divide(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void division_zero_test()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(7, 0));
        }
    }
}