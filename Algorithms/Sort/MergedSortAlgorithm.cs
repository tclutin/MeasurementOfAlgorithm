using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Sort
{
    class MergedSortAlgorithm : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            MergedSort(input);
        }

        public void MergedSort(int[] arr)
        {
            if (arr.Length > 1)
            {
                int mid = (arr.Length) / 2;

                int[] leftArr = new int[mid];
                int[] rightArr = new int[arr.Length - mid];

                for (int i = 0; i < mid; i++)
                {
                    leftArr[i] = arr[i];
                }

                for (int i = mid; i < arr.Length; i++)
                {
                    rightArr[i - mid] = arr[i];
                }

                MergedSort(leftArr);
                MergedSort(rightArr);

                int a = 0;
                int b = 0;
                int c = 0;

                while (a < leftArr.Length && b < rightArr.Length)
                {
                    if (leftArr[a] < rightArr[b])
                    {
                        arr[c] = leftArr[a];
                        a += 1;
                    }
                    else
                    {
                        arr[c] = rightArr[b];
                        b += 1;
                    }
                    c += 1;
                }

                while (a < leftArr.Length)
                {
                    arr[c] = leftArr[a];
                    a += 1;
                    c += 1;
                }

                while (b < rightArr.Length)
                {
                    arr[c] = rightArr[b];
                    b += 1;
                    c += 1;
                }
            }
        }
    }
}
