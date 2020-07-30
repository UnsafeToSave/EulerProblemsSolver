using ProblemsSolver.Tools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ProblemsSolver.Problems
{
    // Problem description:
    // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

    // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    public class Problem5 : IProblem<long>
    {
        long minNumber; // The smallest positive number that is evenly divisible by all of the numbers from 1 to n
        int lastNumber; //The last element in sequince of divisors
        public Problem5(int last)
        {
            lastNumber = last;
        }

        public long GetResult()
        {
            return minNumber;
        }

        public void Solution()
        {
            long number;  //Variable containing estimated required number
            minNumber = Factorials.GetFactorial(lastNumber);


                for(int i = lastNumber - 2; i > 1; i--)
                {
                    number = minNumber % Factorials.GetFactorial(i) == 0 ? minNumber/Factorials.GetFactorial(i) : minNumber;
                    for (int j = lastNumber; j >= 1; j--)
                    {
                        if (number % j != 0) break;
                        if (j == 1)
                        {
                            minNumber = number;
                            i++;
                        }
                    }
                }
        }
    }
}
