using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            List<string> lists =
                Console.ReadLine()
                    .Split('|')
                    .ToList();

            lists.Reverse();

            List<int> result = new List<int>();

            foreach (string list in lists)
            {                              
                List<int> currentList =
                    list.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                result.AddRange(currentList);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
