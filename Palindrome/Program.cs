using System;

namespace Palindrome
{
    public class Program
    {
        /// <summary>
        /// Function to check if palindrome 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        private static bool checkPalindrome(string value)
        {
            int lengthString = value.Length;

            for (int i = 0; i < lengthString / 2; i++)
            {
                if (value[i] != value[lengthString - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        private static string checkPalindrom1(string str)
        {
            string reverseValue;

            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            reverseValue = new string(ch);

            bool res = str.Equals(reverseValue, StringComparison.OrdinalIgnoreCase);

            if (res == true)
                return str + " is a Palindrome.";
            else
                return str + " is not a Palindrome.";
        }

        public static void Main(string[] args)
        {
            //civic is a Palindrom
            //perls is not Palindrom

            Console.WriteLine("Enter value :");
            string value = Console.ReadLine();

            Console.WriteLine(checkPalindrome(value));

            Console.ReadKey();
        }
    }
}
