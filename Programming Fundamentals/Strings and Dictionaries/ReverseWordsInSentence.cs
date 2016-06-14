using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseWordsInSentence
{
    public class ReverseWordsInSentence
    {
        public static void Main()
        {
            List<char> delimeters = string.Join("", ": . , : ; ( ) [ ] \" \' \\ / ! ? & ="
                .Split())
                .ToCharArray()
                .ToList();

            delimeters.Add(' ');

            string text = Console.ReadLine();

            List<string> wordsInSentece = text.Split(delimeters.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> reversedWords = new List<string>(wordsInSentece);
            reversedWords.Reverse();

            char[] separators = string.Join("", wordsInSentece).ToCharArray().Distinct().ToArray();

            string[] punctuation = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < reversedWords.Count; i++)
            {
                Console.Write(String.Join("", reversedWords[i], punctuation[i]));
            }
            Console.WriteLine();
        }
    }
}
