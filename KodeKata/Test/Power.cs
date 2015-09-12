using System;
using NUnit.Framework;

namespace KodeKata.Test
{
    [TestFixture]
    public class Power
    {
        [Test]
        public void ZeroPower()
        {
            double result = Utility.Power(2, 0);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void ZeroNumber()
        {
            double result = Utility.Power(0, 12);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void PositiveNumberPower()
        {
            double result = Utility.Power(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void NegativeNumberOddPower()
        {
            double result = Utility.Power(-2, 3);

            Assert.That(result, Is.EqualTo(-8));
        }

        [Test]
        public void NegativeNumberEvenPower()
        {
            double result = Utility.Power(-2, 4);

            Assert.That(result, Is.EqualTo(16));
        }

        [Test]
        public void NegativePower()
        {
            double result = Utility.Power(2, -2);

            Assert.That(result, Is.EqualTo(0.25D));
        }
    }
}