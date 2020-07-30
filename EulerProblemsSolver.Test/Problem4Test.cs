using NUnit.Framework;
using ProblemsSolver.Problems;
using System.Collections.Generic;

namespace EulerProblemsSolver.Test
{
    [TestFixture]
    public class Problem4Test
    {
        private static IEnumerable<TestCaseData> InitialData
        {
            get
            {
                yield return new TestCaseData(9, new Problem4(1));
                yield return new TestCaseData(9009, new Problem4(2));
                yield return new TestCaseData(906609, new Problem4(3));
                yield return new TestCaseData(99000099, new Problem4(4));
                yield return new TestCaseData(999000000999, new Problem4(6));
                yield return new TestCaseData(9999000000009999, new Problem4(8));
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
