using System;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool VerifyString(string text)
            {
                if (text == null)
                {
                    throw new ArgumentNullException(nameof(text));
                }
                if (text.Length == 2)
                {
                    return true;
                }
                char[] charArray = text.ToCharArray();
                Array.Reverse(charArray);
                string reversedText = new string(charArray);
                if (reversedText == text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            foreach (string arg in args)
            {
                bool isPalindrome = VerifyString(arg);
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }
    }
}

