using System;
using System.Collections.Generic;

namespace SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            char[] delimeters = new char[] {',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' '};

            string[] words = Console.ReadLine()
                .Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            foreach (var word in words)
            {
                bool containsUppercase = false;
                bool containsLowercase = false;
                bool containsSymbol = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] >= 65 && word[i] <= 90)
                    {
                        containsUppercase = true;
                    }
                    else if (word[i] >= 97 && word[i] <= 122)
                    {
                        containsLowercase = true;
                    }
                    else
                    {
                        containsSymbol = true;
                    }
                }

                if (containsLowercase && containsUppercase || containsSymbol)
                {
                    mixedCaseWords.Add(word);
                }
                else if (containsLowercase)
                {
                    lowerCaseWords.Add(word);
                }
                else
                {
                    upperCaseWords.Add(word);
                }
              
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
