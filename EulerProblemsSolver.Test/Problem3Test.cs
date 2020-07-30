using NUnit.Framework;
using ProblemsSolver.Problems;
using System.Collections.Generic;

namespace EulerProblemsSolver.Test
{
    [TestFixture]
    public class Problem3Test
    {
        private static IEnumerable<TestCaseData> InitialData
        {
            get
            {
                yield return new TestCaseData(13, new Problem3(5460));
                yield return new TestCaseData(29, new Problem3(13195));
                yield return new TestCaseData(25041041, new Problem3(75123123));
                yield return new TestCaseData(6857, new Problem3(600851475143));
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
