using System;

namespace CountOccurencesInString
{
    public class CountOccurencesInString
    {
        public static void Main()
        {
            string mainString = Console.ReadLine().ToLower();
            string subString = Console.ReadLine().ToLower();

            int index = -1;
            bool hasFoundAllMatches = false;
            int counter = 0;

            while (!hasFoundAllMatches)
            {
                index = mainString.IndexOf(subString, index + 1);
                if (index != -1)
                {
                    counter++;
                }
                else
                {
                    hasFoundAllMatches = true;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
