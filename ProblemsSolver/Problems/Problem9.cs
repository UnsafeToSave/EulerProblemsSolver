namespace ProblemsSolver.Problems
{
    // Problem description:
    // A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

    //                                 a2 + b2 = c2

    // For example, 32 + 42 = 9 + 16 = 25 = 52.

    // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    // Find the product abc.
    public class Problem9 : IProblem<int>
    {
        int product = 0; //Variable containing product of a,b,c
        int sum;         //Variable containing sum of a,b,c

        public Problem9(int tripletSum)
        {
            sum = tripletSum;
        }

        public int GetResult()
        {
            return product;
        }

        public void Solution()
        {
            int a, b, c; //Elements of Pythagorean triplet

            a = sum / 3;
            b = sum / 3;
            c = sum / 3 + sum % 3;

            while (a >= 1)
            {
                if(c*c < b*b + a * a)
                {
                    if (a >= b)
                    {
                        a--;
                        b++;
                    }
                    b--;
                    c++;
                }
                else
                {
                    a--;
                    b++;
                }

                if (c * c == b * b + a * a)
                {
                    product = c * b * a;
                    break;
                }
            }

        }
    }
}
