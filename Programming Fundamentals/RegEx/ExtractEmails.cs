using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main(string[] args)
        {
            string pattern = @"(?:^|\s)([a-zA-Z0-9][\-\._a-zA-Z0-9]*@[a-zA-Z\-]+(\.[a-z]+)+\b)";

            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection matchCollection = regex.Matches(text);

            foreach (Match match in matchCollection)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
