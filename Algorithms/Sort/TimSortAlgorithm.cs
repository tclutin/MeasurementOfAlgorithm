using Lab1_algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Sort
{
    public class TimSortAlgorithm : IAlgorithm<int[]>
    {
        public void Execute(int[] input)
        {
            TimSort(input, 32);
        }
          
        public void TimSort(int[] arr, int run)
        {
            int minRun = run;
            int len = arr.Length;

            for (int i = 0; i < len; i += minRun)
            {
                InsertionSortBoost(arr, i, Math.Min((i + minRun - 1), (len - 1)));
            }

            for (int size = minRun; size < len; size = 2 * size)
            {
                for (int left = 0; left < len; left += 2 * size)
                {
                    int mid = Math.Min((left + size - 1), (len - 1));
                    int right = Math.Min((left + 2 * size - 1), (len - 1));

                    if (mid < right)
                    {
                        MergedSortBoost(arr, left, mid, right);
                    }
                }
            }
        }
        private void InsertionSortBoost(int[] arr, int start, int end)
        {
            for (int i = start + 1; i <= end; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= start && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = temp;
            }
        }
        private void MergedSortBoost(int[] arr, int left, int mid, int right)
        {
            int len1 = mid - left + 1;
            int len2 = right - mid;

            int[] leftArr = new int[len1];
            int[] rightArr = new int[len2];

            for (int i = 0; i < len1; i++)
            {
                leftArr[i] = arr[left + i];
            }

            for (int i = 0; i < len2; i++)
            {
                rightArr[i] = arr[mid + i + 1];
            }

            int a = 0;
            int b = 0;
            int c = left;

            while (a < len1 && b < len2)
            {
                if (leftArr[a] < rightArr[b])
                {
                    arr[c] = leftArr[a];
                    a++;
                }
                else
                {
                    arr[c] = rightArr[b];
                    b++;
                }
                c++;
            }

            while (a < len1)
            {
                arr[c] = leftArr[a];
                a++;
                c++;
            }

            while (b < len2)
            {
                arr[c] = rightArr[b];
                b++;
                c++;
            }
        }
    }
}
