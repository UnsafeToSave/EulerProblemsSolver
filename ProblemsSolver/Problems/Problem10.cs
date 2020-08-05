using ProblemsSolver.Tools;
using System.Linq;

namespace ProblemsSolver.Problems
{
    // Problem description:
    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

    //Find the sum of all the primes below two million.
    public class Problem10 : IProblem<long>
    {
        int boundler; // Variable containing boundler of sequence
        long sum = 0; // Sum of sequence of prime numbers which below boundler
        public Problem10(int boundler)
        {
            this.boundler = boundler;
        }

        public long GetResult()
        {
            return sum;
        }

        public void Solution()
        {
            PrimeNumbers.SearchBelow(boundler);
            foreach (var number in PrimeNumbers.GetSequence())
            {
                if (number > boundler) break;
                sum += number;
            }
        }
    }
}
