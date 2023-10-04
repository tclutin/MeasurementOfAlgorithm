using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Others
{
    public class RecursivePowAlgorithm : IAlgorithmInt<int>
    {
        public int Execute(int n)
        {
            int steps = 0;
            int x = 2;

           RecursivePow(x, n, ref steps);
           
            return steps;
        }

        public int RecursivePow(int x, int n, ref int steps)
        {
            steps++;

            if (n == 0)
                return 1;
            if (n == 1)
                return x;
            return RecursivePow(x, n - 1, ref steps);
        }
    }
}
