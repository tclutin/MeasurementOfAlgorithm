using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Others
{
    public class SimplePowAlgorithm : IAlgorithmInt<int>
    {
        public int Execute(int n)
        {
            int x = 2;
            return Pow(x, n);
        }

        public int Pow(int x, int n)
        {
            int steps = 0;
            int result = 1;
            int count = 0;
            while (count < n)
            {
                result *= x;
                count++;
                steps += 2;
            }
            return steps;
        }
    }
}
