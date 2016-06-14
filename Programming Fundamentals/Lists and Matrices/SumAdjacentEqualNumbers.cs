using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<double> realNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            
            int pos = 0;

            while (pos < realNumbers.Count - 1)
            {
                
                if (realNumbers[pos] == realNumbers[pos + 1])
                {
                    realNumbers[pos] *= 2;
                    realNumbers.RemoveAt(pos + 1);
                    if (pos > 0)
                    {
                        pos--;
                    }
                }
                else
                {
                    pos++;
                }
                
            }

            Console.WriteLine(string.Join(" ", realNumbers));
        }
    }
}
