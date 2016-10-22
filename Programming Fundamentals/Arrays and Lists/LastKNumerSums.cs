using System;

namespace LastKNumerSums
{
    public class LastKNumerSums
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = i - 1; j >= 0 && j >= i-k; j--)
                {
                    numbers[i] += numbers[j];
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
