using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Others
{
    class NativeMethodAlgorithm : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            NativeMethod(input);
        }

        public double NativeMethod(int[] input)
        {
            double sum = 0;
            double x = 1.5;

            for (int i = 0; i <= input.Length - 1; i++)
            {
                sum += input[i] * Math.Pow(x, i);
            }
            return sum;
        }
    }

}
