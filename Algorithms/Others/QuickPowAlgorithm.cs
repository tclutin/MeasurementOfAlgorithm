using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Others
{
    public class QuickPowAlgorithm : IAlgorithmInt<int>
    {
        public int Execute(int n)
        {
            int x = 2;
            return QuickPow(x, n);
        }

        public int QuickPow(int x, int n)
        {
            int steps = 0;
            int c = x;
            int k = n;
            int f;
            if (k % 2 == 1)
                f = c;
            else
                f = 1;
            do
            {
                steps += 2;
                k = k / 2;
                c = c * c;
                if (k % 2 == 1)
                {
                    f = f * c;
                    steps++;
                }
                    
            }
            while (k != 0);
            return steps;
        }

    }

}
