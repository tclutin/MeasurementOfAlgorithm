using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Arithmetic
{
    public class SumAlgorithm : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            SumElementsVector(input);
        }

        public void SumElementsVector(int[] vector)
        {
            long result = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                result += vector[i];
            }
        }
    }
}
