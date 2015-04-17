using System;

using NUnit.Framework;

namespace KodeKata.Test
{
    [TestFixture]
    public class Factorial
    {
        public static int[][] FactorialTestData = new int[][]
        {
            new int[] { 1, 1 },
            new int[] { 2, 2 },
            new int[] { 3, 6 },
            new int[] { 4, 24 },
            new int[] { 5, 120 },
            new int[] { 6, 720 }
        };

        [Test]
        public void NegativeNumberFactorial()
        {
            Assert.Throws<ArgumentException>(() => Utility.Factorial(-1));
        }

        [Test]
        public void ZeroFactorial()
        {
            int result = Utility.Factorial(0);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCaseSource("FactorialTestData")]
        public void PositiveNumberFactorial(int number, int expected)
        {
            int result = Utility.Factorial(number);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
