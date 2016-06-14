using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderBy(number => number).ToList();

            int previousElement = numbers[0];
            int counter = 1;

            foreach (var number in numbers.Skip(1))
            {
                if (previousElement == number)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", previousElement, counter);
                    previousElement = number;
                    counter = 1;
                }
            }
            Console.WriteLine("{0} -> {1}", previousElement, counter);
        }
    }
}
