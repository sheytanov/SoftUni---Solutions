using System;


namespace CountLettersInString
{
    public class CountLettersInString
    {
        public static void Main()
        {
            char[] word = Console.ReadLine().ToLower().ToCharArray();
            Array.Sort(word);

            int counter = 1;

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    counter++;
                    if (i + 1 == word.Length - 1)
                    {
                        Console.WriteLine("{0} -> {1}", word[i], counter);
                    }
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", word[i], counter);
                    counter = 1;
                }
            }
        }
    }
}
