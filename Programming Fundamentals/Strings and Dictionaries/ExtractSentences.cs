using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace ExtractSentences
{
    public class ExtractSentences
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine();
            Console.WriteLine();
            List<char> delimeters = string.Join("", ": . , : ; ( ) [ ] \" \' \\ / ! ?"
                .Split())
                .ToCharArray()
                .ToList();

            delimeters.Add(' ');

            for (int i = 0; i < text.Length; i++)
            {
                string[] words = text[i].Split(delimeters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

                if (words.Contains(word))
                {
                    Console.WriteLine(text[i].Trim());
                }

            }
        }
    }
}
