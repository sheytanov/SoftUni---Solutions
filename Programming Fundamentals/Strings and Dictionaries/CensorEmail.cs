using System;

namespace CensorEmail
{
    public class CensorEmail
    {
        public static void Main()
        {
            string[] email = Console.ReadLine().Split('@');
            string text = Console.ReadLine();
            string username = email[0];
            string domain = email[1];

            string inputEmail = string.Join("@", email);
            string censoredUser = new string('*', username.Length);
            string replaceString = censoredUser + "@" + domain;

            Console.WriteLine(text.Replace(inputEmail, replaceString));
        }
    }
}
