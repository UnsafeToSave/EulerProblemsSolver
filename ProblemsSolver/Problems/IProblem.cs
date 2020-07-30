namespace ProblemsSolver.Problems
{
    public interface IProblem<T>
    {
        void Solution();
        T GetResult();
    }
}
