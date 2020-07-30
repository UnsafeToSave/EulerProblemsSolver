using ProblemsSolver.Tools;
using System;

namespace ProblemsSolver.Problems
{

    // Problem description:
    //    A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

    //Find the largest palindrome made from the product of two 3-digit numbers.
    public class Problem4 : IProblem<long>
    {
        int digit;                  //Digit of number
        long largestPalindrome = 0; //The Largest palindrome

        public Problem4(int digit)
        {
            this.digit = digit;
        }

        public long GetResult()
        {
            return largestPalindrome;
        }

        public void Solution()
        {
            long boundler = (long)Math.Pow(10, digit - 1); //minimum that can take factor
            long factor1 = boundler * 10 - 1;              //One of factors
            long factor2 = factor1;                        //One of factors
            long palindrome;                               //The variable containing estimated palindrome

            if (digit%2 == 0)
            {
                largestPalindrome = factor1 * (factor2 - (long)Math.Pow(10, digit / 2) + 2);
                return;
            }

            for(long i = factor1; i >= boundler; i--)
            {
                for (long j = factor2; j >= boundler; j--)
                {
                    palindrome = i * j;
                    if ((i * j).IsPalindrome())
                    {
                        boundler = j;
                        largestPalindrome = palindrome != 0 && palindrome > largestPalindrome ? palindrome : largestPalindrome;
                    }
                }
            }
        }
    }
}
