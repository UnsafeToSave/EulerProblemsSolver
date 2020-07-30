using NUnit.Framework;
using ProblemsSolver.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblemsSolver.Test
{
    [TestFixture]
    public class Problem5Test
    {
        private static IEnumerable<TestCaseData> InitialData
        {
            get
            {
                yield return new TestCaseData(6, new Problem5(3));
                yield return new TestCaseData(12, new Problem5(4));
                yield return new TestCaseData(60, new Problem5(5));
                yield return new TestCaseData(60, new Problem5(6));
                yield return new TestCaseData(420, new Problem5(7));
                yield return new TestCaseData(840, new Problem5(8));
                yield return new TestCaseData(2520, new Problem5(9));
                yield return new TestCaseData(2520, new Problem5(10));
                yield return new TestCaseData(232792560, new Problem5(20));
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
