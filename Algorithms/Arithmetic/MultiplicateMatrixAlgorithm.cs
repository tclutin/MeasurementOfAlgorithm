using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms.Arithmetic
{
    class MultiplicateMatrixAlgorithm : IAlgorithm<Tuple<Matrix, Matrix, int>>
    {
        public void Execute(Tuple<Matrix, Matrix, int> input)
        {
            Multiplicate(input.Item1, input.Item2, input.Item3);
        }

        public Matrix Multiplicate(Matrix a, Matrix b, int n)
        {
           
            Matrix result = new Matrix(n);
            //Перебирает строки первой матрицы a
            for (int i = 0; i < n; i++)
            {
                //перебирает столбцы второй матрицы b
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        result.Base[i, j] += a.Base[i, k] * b.Base[k, j];
                    }
                }
            }
            return result;
        }

    }
}
