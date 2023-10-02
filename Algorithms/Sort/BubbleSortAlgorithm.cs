using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Sort
{
    public class BubbleSortAlgorithm : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            BubbleSort(input);
        }

        public void BubbleSort(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - i - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int n = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = n;
                    }
                }
            }
        }
    }
}
