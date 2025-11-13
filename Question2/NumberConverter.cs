using System;
using System.Collections.Generic;

namespace SimcorpInterview
{
    public class NumberConverter
    {
        public static long GetNumber(LinkedList<int> binary)
        {
            //Convert the LinkedList of 0 and 1 into it's numerical equivalent
            return 0L;
        }

        public static void RunExample()
        {
            var binary = new LinkedList<int>(new[] { 1, 0, 1, 0, 1 });
            var result = GetNumber(binary);
            Console.WriteLine($"Answer : {result}");
        }
    }
}
