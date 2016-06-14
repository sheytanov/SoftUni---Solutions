using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentElement
{
    class MostFrequentElement
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int resultNumber = 0;
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempCounter = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        tempCounter++;
                    }
                }
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    resultNumber = numbers[i];
                }
            }
            Console.WriteLine(resultNumber);
        }
    }
}