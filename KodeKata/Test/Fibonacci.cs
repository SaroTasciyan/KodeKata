using System;
using NUnit.Framework;

namespace KodeKata.Test
{
    [TestFixture]
    public class Fibonacci
    {
        public static int[][] FibonacciTestData = new int[][]
        {
            new int[] { 1, 1 },
            new int[] { 2, 1 },
            new int[] { 3, 2 },
            new int[] { 4, 3 },
            new int[] { 5, 5 },
            new int[] { 6, 8 }
        };

        [Test]
        public void NegativeNumberFibonacci()
        {
            Assert.Throws<ArgumentException>(() => Utility.Fibonacci(-1));
        }

        [Test]
        public void ZeroFibonnaci()
        {
            int result = Utility.Fibonacci(0);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCaseSource("FibonacciTestData")]
        public void PositiveNumberFibonacci(int number, int expected)
        {
            int result = Utility.Fibonacci(number);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
