using Lab1_algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Arithmetic
{
    public class MultipleAlgorithm : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            MultiplyElementsVector(input);
        }

        public void MultiplyElementsVector(int[] vector)
        {
            long result = 1;
            for (int i = 0; i < vector.Length; i++)
            {
                result *= vector[i];
            }
        }
    }
}
