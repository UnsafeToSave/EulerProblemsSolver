using ProblemsSolver.Tools;

namespace ProblemsSolver.Problems
{
    // Problem description:
    //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

    //What is the 10 001st prime number?
    public class Problem7 : IProblem<long>
    {
        int index;        // Index of required number in sequence of prime numbers
        long primeNumber; // Requiered prime number
        public Problem7(int index)
        {
            this.index = index;
        }

        public long GetResult()
        {
            return primeNumber;
        }

        public void Solution()
        {
            primeNumber = PrimeNumbers.GetElementAt(index);
        }
    }
}
