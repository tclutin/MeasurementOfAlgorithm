using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Sort
{
    public class ShellSortAlgorithm : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            ShellSort(input);
        }

        public static void ShellSort(int[] vector)
        {
            int step = vector.Length / 2;
            while (step >= 1)
            {   
                for (int i = step; i < vector.Length; i++)
                {
                    int j = i;
                    while (j >= step && vector[j - step] > vector[j])
                    {
                        int temp = vector[j];
                        vector[j] = vector[j - step];
                        vector[j - step] = temp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
        }
    }
}
