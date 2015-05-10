using System;

namespace KodeKata
{
    public static class Utility
    {
        public static int Factorial(int number)
        {
            if (number < 0) { throw new ArgumentException("Number can not be negative", "number"); }

            if (number <= 1) { return 1; } // # Base case: 0! or 1! is 1
            return number * Factorial(number - 1); // # Recursion step: n! = n * (n-1)!
        }

        public static int Fibonacci(int number)
        {
            if (number < 0) { throw new ArgumentException("Number can not be negative", "number"); }

            if (number == 0) { return 0; }
            if (number == 1) { return 1; }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
