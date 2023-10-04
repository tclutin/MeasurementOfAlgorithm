using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Sort
{
    public class ClassicQuickPowAlgorithm : IAlgorithmInt<int>
    {
        public int Execute(int n)
        {
            int x = 2;
            return ClassicQuickPow(x, n);
        }
        public int ClassicQuickPow(int x, int n)
        {
            int steps = 0;
            int f = 1;
            int c = x;
            int k = n;

            while (k != 0)
            {
                if (k % 2 == 0)
                {
                    c = c * c;
                    k = k / 2;
                    steps += 2;
                }
                else
                {
                    f = f * c;
                    k = k - 1;
                    steps += 2;
                }
            }
            return steps;
        }
    }
}
