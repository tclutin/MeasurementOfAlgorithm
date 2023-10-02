using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm
{
    public class Matrix
    {
        public int[,] Base { get; set; }
        public Matrix(int n)
        {
            Base = new int[n, n];
        }

        public static Matrix CreateRandomMatrix(int n)
        {
            Matrix matrix = new Matrix(n);
      
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix.Base[i, j] = random.Next(0, 10);
                }
            }
            return matrix;
        }

        public void WriteMatrix()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(Base[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
