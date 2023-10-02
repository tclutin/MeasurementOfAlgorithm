using Lab1_algorithm.Algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm
{
    public class AlgorithmProfiler
    {
        public Random random = new Random();
        public Stopwatch stopwatch = new Stopwatch();

        public int _externalCounter { get; set; }
        public int _internalCounter { get; set; }

        public AlgorithmProfiler(int externalCounter = 2000, int internalCounter = 5)
        { 
            _externalCounter = externalCounter;
            _internalCounter = internalCounter; 
        }

        public int[] GenerateVector(int n)
        {
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = random.Next(1, 1000);
            }
            return vector;

        }

        //vector ? public ?type Name(int[])
        public void Run(string name, IAlgorithm<int[]> algorithm)
        {
            int[] vector = GenerateVector(_externalCounter);
            for (int n = 1; n <= vector.Length; n++)
            {
                double totalTime = 0;
                int[] segment = new ArraySegment<int>(vector, 0, n).ToArray();

                for (int i = 0; i < _internalCounter; i++)
                {
                    stopwatch.Reset();
                    stopwatch.Start();
                    algorithm.Execute(segment);
                    stopwatch.Stop();

                    double runTime = stopwatch.Elapsed.TotalSeconds;
                    totalTime += runTime;
                }
                double averageTime = totalTime / _internalCounter;
                Console.WriteLine($"Имя: {name} Элемент: {n} Время: {averageTime.ToString("F8")}");
                WriteToFile(name, $"{n};{averageTime.ToString("F8")}\n");
            }
        }

        //matrix ?  public ?type Name(Tuple<Matrix, Matrix, int>)
        public void Run(string name, IAlgorithm<Tuple<Matrix, Matrix, int>> algorithm)
        {
            for (int n = 1; n <= _externalCounter; n++)
            {
                Matrix matrixA = Matrix.CreateRandomMatrix(n);
                Matrix matrixB = Matrix.CreateRandomMatrix(n);

                double totalTime = 0;

                for (int i = 0; i < _internalCounter; i++)
                {
                    stopwatch.Reset();
                    stopwatch.Start();
                    algorithm.Execute(new Tuple<Matrix, Matrix, int>(matrixA, matrixB, n));
                    stopwatch.Stop();

                    double runTime = stopwatch.Elapsed.TotalSeconds;
                    totalTime += runTime;
                }

                double averageTime = totalTime / _internalCounter;
                Console.WriteLine($"Имя: {name} Элемент: {n} Время: {averageTime.ToString("F8")}");
                WriteToFile(name, $"{n};{averageTime.ToString("F8")}\n");
            }
        }

        //int ? public int Name(int)
        public void Run(string name, IAlgorithmInt<int> algorithm)
        {

            for (int n = 1; n <= _externalCounter; n++)
            {
                int value = algorithm.Execute(n);

                WriteToFile(name, $"{n};{value}\n");
            }
        }

        public void ReloadFiles()
        {
            string filePath = Path.Combine(("Data/"));
            if (Directory.Exists(filePath))
            {
                Directory.Delete(filePath, true);
            }
        }

        public void WriteToFile(string name, string text)
        {
            string filePath = Path.Combine(("Data/"));

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            File.AppendAllText(filePath + name + ".csv", text);
        }
    }
}
