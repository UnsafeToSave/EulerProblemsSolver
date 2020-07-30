namespace ProblemsSolver.Problems
{
    // Problem description:
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    //
    // Find the sum of all the multiples of 3 or 5 below 1000.

    public class Problem1 : IProblem<int>
    {
        int limit;
        int[] divisors;
        int sum = 0;

        public Problem1(int limit, params int[] divisors)
        {
            this.limit = limit - 1;
            this.divisors = divisors;
        }

        public int GetResult()
        {
            return sum;
        }

        public void Solution()
        {
            int intersection;                        //Amount of same numbers for two divisors
            int[] amount = new int[divisors.Length]; //Amount numbers the multiple of divisors below limit
            int[] mult = new int[amount.Length];     //Multiplier for divisors


            for (int i = 0; i < divisors.Length; i++)
            {
                amount[i] = limit / divisors[i];
                mult[i] = (amount[i] * amount[i] + amount[i]) / 2;
            }


            for (int i = 0; i < amount.Length; i++)
            {
                for (int j = i + 1; j < divisors.Length; j++)
                {
                    intersection = amount[i] / divisors[j];
                    intersection = (intersection * intersection + intersection) / 2;
                    sum -= intersection * divisors[i] * divisors[j];
                }
            }

            for (int i = 0; i < divisors.Length; i++)
            {
                sum += mult[i] * divisors[i];
            }
        }
    }
}
