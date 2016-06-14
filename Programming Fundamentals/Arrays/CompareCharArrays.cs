using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            //string[] arrays = {new string(firstArray), new string(secondArray) };
            
            //Console.WriteLine(string.Join("\n", arrays.OrderBy(str => str)));

            if (55.CompareTo(1024) > 0)
            {
                Console.WriteLine(secondArray);
                Console.WriteLine(firstArray);
            }
            else
            {
                Console.WriteLine(firstArray);
                Console.WriteLine(secondArray);
            }
        }
    }
}
