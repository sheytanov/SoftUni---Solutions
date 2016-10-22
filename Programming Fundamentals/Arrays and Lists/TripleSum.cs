using System;

namespace TripleSum
{
    public class TripleSum
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            bool foundSum = false;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {

                    for (int c = 0; c < numbers.Length; c++)
                    {
                        if (numbers[a] + numbers[b] == numbers[c])
                        {
                            Console.WriteLine("{0} + {1} == {2}", 
                                numbers[a], numbers[b], numbers[c]);
                            foundSum = true;

                            break;
                        }
                    }
                }
            }

            if (!foundSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
