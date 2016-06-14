using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniWaterSupplies
{
    public class SoftUniWaterSupplies
    {
        public static void Main(string[] args)
        {
            double totalWater = double.Parse(Console.ReadLine());
            double[] bottles = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            int bottleCapacity = int.Parse(Console.ReadLine());

            int breakIndex = -1;
            if (totalWater % 2 == 0)
            {
                for (int currentElement = 0; currentElement < bottles.Length; currentElement++)
                {
                    if (totalWater - (bottleCapacity - bottles[currentElement]) <= 0)
                    {
                        breakIndex = currentElement;
                        bottles[currentElement] += totalWater;
                        break;
                    }
                    else
                    {
                        totalWater = totalWater - (bottleCapacity - bottles[currentElement]);
                        bottles[currentElement] = bottleCapacity;
                    }
                }

                int emptyBottlesCount = bottles.Where(x => x < bottleCapacity).Count();

                if (emptyBottlesCount == 0)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", totalWater);
                }
                else
                {
                    List<int> indexes = new List<int>();
                    double waterNeeded = 0;
                    for (int i = breakIndex; i < bottles.Length; i++)
                    {
                        waterNeeded += bottleCapacity - bottles[i];
                        indexes.Add(i);
                    }
                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", emptyBottlesCount);
                    Console.WriteLine("With indexes: {0}", string.Join(", ", indexes));
                    Console.WriteLine("We need {0} more liters!", waterNeeded);
                }
            }
            else
            {
                for (int currentElement = bottles.Length - 1; currentElement >= 0; currentElement--)
                {
                    if (totalWater - (bottleCapacity - bottles[currentElement]) < 0)
                    {
                        breakIndex = currentElement;
                        bottles[currentElement] += totalWater;
                        break;
                    }
                    else
                    {
                        totalWater = totalWater - (bottleCapacity - bottles[currentElement]);
                        bottles[currentElement] = bottleCapacity;
                    }
                }

                int emptyBottlesCount = bottles.Where(x => x < bottleCapacity).Count();

                if (emptyBottlesCount == 0)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", totalWater);
                }
                else
                {
                    List<int> indexes = new List<int>();
                    double waterNeeded = 0;
                    for (int i = breakIndex; i >= 0; i--)
                    {
                        waterNeeded += bottleCapacity - bottles[i];
                        indexes.Add(i);
                    }
                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", emptyBottlesCount);
                    Console.WriteLine("With indexes: {0}", string.Join(", ", indexes));
                    Console.WriteLine("We need {0} more liters!", waterNeeded);
                }
            }

        }
    }
}