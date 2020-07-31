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
    class Problem6Test
    {
        private static IEnumerable<TestCaseData> InitialData
        {
            get
            {
                yield return new TestCaseData(2640, new Problem6(10));
                yield return new TestCaseData(25164150, new Problem6(100));
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
