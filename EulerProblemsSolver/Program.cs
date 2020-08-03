using ProblemsSolver.Problems;
using ProblemsSolver.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace EulerProblemsSolver
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await PrimeNumbers.SearchBelow(2000000);
            var r = PrimeNumbers.numbers.Where(x => x < 2000000).Sum();
        }
    }
}
