using NUnit.Framework;
using ProblemsSolver.Problems;
using System.Collections.Generic;

namespace EulerProblemsSolver.Test
{
    [TestFixture]
    public class Problem1Test
    {
        private static IEnumerable<TestCaseData> InitialData
        {
            get
            {
                yield return new TestCaseData(23, new Problem1(10, 3, 5));
                yield return new TestCaseData(233168, new Problem1(1000, 3, 5));
            }
        }
        [Test, TestCaseSource(nameof(InitialData))]
        public void SolutionTest(int expectedResult, IProblem<int> problem)
        {
            //Act
            problem.Solution();

            //Assert
            Assert.AreEqual(expectedResult, problem.GetResult());
        }
    }
}
