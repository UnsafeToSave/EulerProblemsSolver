using ProblemsSolver.Tools;

namespace ProblemsSolver.Problems
{
    // Problem description:
    //The prime factors of 13195 are 5, 7, 13 and 29.

    //What is the largest prime factor of the number 600851475143 ?
    public class Problem3 : IProblem<long>
    {

        long number;        //Input number
        long largestFactor; //Variable containing result  

        public Problem3(long num)
        {
            number = num;
        }

        public long GetResult()
        {
            return largestFactor;
        }

        public void Solution()
        {
            int idPrime = 1;           //Id of prime number in sequence of prime numbers
            long prevNumber = number;  //Variable reciving value of _number to each iterration
            while (!number.IsPrime())
            {
                number = number % PrimeNumbers.GetElementAt(idPrime) == 0 ? number / PrimeNumbers.GetElementAt(idPrime) : number;
                idPrime++;
                if(prevNumber != number)
                {
                    prevNumber = number;
                    idPrime = 1;
                }
            }
            largestFactor = number;
        }
    }
}
