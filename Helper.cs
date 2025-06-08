using System;

namespace InfoGain
{

    /// <summary>
    /// A static helper class containing utility math functions.
    /// </summary>
    internal static class Helper
    {
        /// <summary>
        /// Returns the square of a given integer.
        /// </summary>
        // Static field
        private static int counter = 0;

        // Static method
        public static int Square(int number)
        {
            counter++; // Static fields can be accessed inside static methods
            return number * number;
        }

        // Static property
        public static int Counter => counter;

        /// <summary>
        /// Returns the cube of a given integer.
        /// </summary>
        public static int Cube(int number)
        {
            return number * number * number;
        }

        /// <summary>
        /// Checks if the number is even.
        /// </summary>
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Checks if the number is odd.
        /// </summary>
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        /// <summary>
        /// Returns the factorial of a non-negative integer.
        /// </summary>
        public static long Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number must be non-negative.");

            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Returns true if the number is prime.
        /// </summary>
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }


    }

}
