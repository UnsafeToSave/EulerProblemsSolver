using NUnit.Framework;
using ProblemsSolver.Problems;

namespace EulerProblemsSolver.Test
{
    [TestFixture]
    public class Problem2Test
    {
        [Test]
        public void SolutionTest()
        {
            //Arrange
            IProblem<int> problem = new Problem2();

            //Act
            problem.Solution();

            //Assert
            Assert.AreEqual(4613732, problem.GetResult());
        }
    }
}
