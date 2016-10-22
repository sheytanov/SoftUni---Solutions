using System;
using System.Collections.Generic;

namespace BombNumbers
{
    public class BombNumbers
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(int.Parse(input[i]));
            }

            string[] bombInfo = Console.ReadLine().Split();
            int target = int.Parse(bombInfo[0]);
            int radius = int.Parse(bombInfo[1]);

            while (numbers.Contains(target))
            {
                int index = -1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (target == numbers[i])
                    {
                        index = i;
                        break;
                    }
                }

                int bombBlast = 2*radius + 1;
                int startIndex = Math.Max(0, index - radius);
                int count = Math.Min(bombBlast, numbers.Count - startIndex);
                numbers.RemoveRange(startIndex, count);
            }


            long sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
