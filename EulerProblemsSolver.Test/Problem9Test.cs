using System.Collections.Generic;
using NUnit.Framework;
using ProblemsSolver.Problems;

namespace EulerProblemsSolver.Test
{
    [TestFixture]
    public class Problem9Test
    {
        private static IEnumerable<TestCaseData> InitialData
        {
            get
            {
                yield return new TestCaseData(60, new Problem9(12));
                yield return new TestCaseData(31875000, new Problem9(1000));
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
