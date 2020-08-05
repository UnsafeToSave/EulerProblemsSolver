using NUnit.Framework;
using ProblemsSolver.Problems;
using System.Collections.Generic;

namespace EulerProblemsSolver.Test
{
    [TestFixture]
    public class Problem10Test
    {
        private static IEnumerable<TestCaseData> InitialData
        {
            get
            {
                yield return new TestCaseData(17, new Problem10(10));
                yield return new TestCaseData(142913828922, new Problem10(2000000));
            }
        }
        [Test, TestCaseSource(nameof(InitialData))]
        public void SolutionTest(long expectedResult, IProblem<long> problem)
        {
            //Act
            problem.Solution();

            //Assert
            Assert.AreEqual(expectedResult, problem.GetResult());
        }
    }
}
