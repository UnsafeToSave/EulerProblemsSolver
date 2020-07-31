namespace ProblemsSolver.Problems
{
    // Problem description:
    //The sum of the squares of the first ten natural numbers is,
    //                       12 + 22 + ... + 102 = 385
    //The square of the sum of the first ten natural numbers is,
    //                    (1 + 2 + ... + 10)2 = 552 = 3025
    //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
    //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    public class Problem6 : IProblem<long>
    {
        int amountNumbers;
        long difference;

        public Problem6(int amount)
        {
            amountNumbers = amount;
        }

        public long GetResult()
        {
            return difference;
        }

        public void Solution()
        {
            long sumOfSquer = 0;
            long squerOfSum = 0;

            for (int i = 1; i <= amountNumbers; i++)
            {
                sumOfSquer += i * i;
            }

            squerOfSum = (amountNumbers * amountNumbers + amountNumbers) / 2;
            squerOfSum = squerOfSum * squerOfSum;
            difference = squerOfSum - sumOfSquer;
        }
    }
}
