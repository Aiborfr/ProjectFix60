using System;
using System.Linq;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text");
            string response = Console.ReadLine();
            Console.WriteLine(IsPalindrome(response));
        }

        public static bool IsPalindrome(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversedText = new string(charArray);

            return text.Equals(reversedText, StringComparison.OrdinalIgnoreCase);
        }

        public static string Palindrome(string original)
        {
            string reversed = new string(original.Reverse().ToArray());
            return $"{original}{reversed}";
        }

    }
}
