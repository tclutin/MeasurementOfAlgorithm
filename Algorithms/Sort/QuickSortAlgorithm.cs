using Lab1_algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Sort
{
    public class QuickSortAlgorithm : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            QuickSort(input, 0, input.Length - 1);
        }

        public void QuickSort(int[] vector, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return;
            }
            int pivot = FindPivot(vector, minIndex, maxIndex);
            QuickSort(vector, minIndex, pivot - 1);
            QuickSort(vector, pivot + 1, maxIndex);
        }

        public int FindPivot(int[] vector, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            int temp = 0;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (vector[i] < vector[maxIndex])
                {
                    pivot++;
                    temp = vector[i];
                    vector[i] = vector[pivot];
                    vector[pivot] = temp;
                }
            }
            pivot++;
            temp = vector[maxIndex];
            vector[maxIndex] = vector[pivot];
            vector[pivot] = temp;

            return pivot;
        }

    }
}
