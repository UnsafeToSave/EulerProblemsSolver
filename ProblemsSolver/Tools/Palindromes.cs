using System.Collections.Generic;

namespace ProblemsSolver.Tools
{
    /// <summary>
    /// Method to work with palindromes
    /// </summary>
    public static class Palindromes
    {
        /// <summary>
        /// Method to defining is number palindrome or not
        /// </summary>
        /// <returns>Returns true if number is palindrome and false if not</returns>>
        public static bool IsPalindrome(this long number)
        {
            List<int> numbers = new List<int>();
            while (number != 0)
            {
                numbers.Add((int)(number % 10));
                number = number / 10;
            }

            for(int i = 0; i < numbers.Count/2; i++)
            {
                if (numbers[i] != numbers[numbers.Count - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
