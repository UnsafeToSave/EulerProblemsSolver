namespace ProblemsSolver.Tools
{
    public static class Factorials
    {
        public static long GetFactorial(int n)
        {
            if (n == 1) return 1;

            return n * GetFactorial(n - 1);
        }
    }
}
