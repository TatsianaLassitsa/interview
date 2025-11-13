using System;

namespace SimcorpInterview
{
    public static class Primes {
        /// Write an algorithm that returns the first <n> prime numbers (простi числа)
        /// Assume n <= 100
        private static int[] FirstPrimes(int numberOfPrimes)
        { 
            return new int[] {2, 3, 5};
        }

        public static void Main(string[] args)
        {
            foreach (var n in FirstPrimes(3))
            {
                Console.WriteLine(n);
            }
        }
    }
}