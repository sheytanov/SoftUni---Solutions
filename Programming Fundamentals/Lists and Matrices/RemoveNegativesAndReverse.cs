using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split()
                                                  .Select(int.Parse)
                                                  .Where(number => number >= 0)
                                                  .Reverse()
                                                  .ToList();

            Console.WriteLine(numbers.Count == 0 ? "empty" : string.Join(" ", numbers));
        }
    }
}
