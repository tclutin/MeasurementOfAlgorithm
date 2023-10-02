using Lab1_algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Others
{
    public class GornerAlgorithm : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            GornerMethod(input);
        }

        public double GornerMethod(int[] vector, int i = 0)
        {
            double x = 1.5;
            if (i >= vector.Length)
                return 0;
            return vector[i] + x * GornerMethod(vector, i + 1);
        }
    }
}
