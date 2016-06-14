using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurences
{
    public class OddOccurences
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> dict = GetRepeats(words);

            List<string> result = dict
                .Where(kvPair => kvPair.Value%2 != 0)
                .Select(kvPair => kvPair.Key)
                .ToList();
            
            Console.WriteLine(string.Join(", ", result));
        }

        public static Dictionary<string, int> GetRepeats(List<string> words)
        {
            Dictionary<string, int> wordRepeats = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordRepeats.ContainsKey(word))
                {
                    wordRepeats[word]++;
                }
                else
                {
                    wordRepeats.Add(word, 1);
                }
            }

            return wordRepeats;
        }
    }
}
