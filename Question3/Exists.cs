using System;

namespace SimcorpInterview
{
    public static class Question3
    {
        /// <summary>
        /// This function takes an *ordered* list of integers and returns *true* if the number exists in the list and *false* if it does not.
        /// Unfortunately, for some inputs the function does not operate as expected.
        /// Identify any issues and propose fixes. 
        /// </summary>
        /// <remarks>
        /// It is not acceptable to re-implement the function using LINQ, HashSets, etc.
        /// </remarks>
        public static bool Exists(int[] numbers, int item)
        {
            int firstIndex = 0;
            int lastIndex = numbers.Length - 1;
            bool found = false;

            while (firstIndex <= lastIndex && !found)
            {
                int midpoint = (firstIndex + lastIndex) / 2;
                if (numbers[midpoint] == item)
                    found = true;
                else
                {
                    if (item < numbers[midpoint])
                        lastIndex = midpoint;
                    else
                        firstIndex = midpoint;
                }
            }
            return found;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Exists(new[] { 1 }, 1));
        }
    }
}
