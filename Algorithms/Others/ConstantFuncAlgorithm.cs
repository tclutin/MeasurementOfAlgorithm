using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Others
{
    public class ConstantFuncAlgorithm : IAlgorithm<int[]>
    {

        public void Execute(int[] input)
        {
            ConstantFunc(input);
        }

        public void ConstantFunc(int[] vector)
        {
            int length = vector.Length;
        }
    }
}
