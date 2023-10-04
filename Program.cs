
using Lab1_algorithm.Algorithms.Arithmetic;
using Lab1_algorithm.Algorithms.Others;
using Lab1_algorithm.Algorithms.Sort;
using System;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Lab1_algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AlgorithmProfiler profiler =  new AlgorithmProfiler(2000, 5);
            profiler.ReloadFiles();

            //fast
            profiler.Run("TimSort",             new TimSortAlgorithm());
            profiler.Run("MergedSort",          new MergedSortAlgorithm());
            profiler.Run("QuickSort",           new QuickSortAlgorithm());
            profiler.Run("ShellSort",           new ShellSortAlgorithm());
            profiler.Run("Multiply",            new MultipleAlgorithm());
            profiler.Run("Sum",                 new SumAlgorithm());
            profiler.Run("Gorner",              new GornerAlgorithm());
            profiler.Run("ConstantFunc",        new ConstantFuncAlgorithm());
            profiler.Run("QuickPow",            new QuickPowAlgorithm());
            profiler.Run("QuickClassicPow",     new ClassicQuickPowAlgorithm());
            profiler.Run("SimplePow",           new SimplePowAlgorithm());
            profiler.Run("RecursePow",          new RecursivePowAlgorithm());

            //slow
            profiler._externalCounter = 200;
            profiler.Run("BubbleSort",          new BubbleSortAlgorithm());
            profiler.Run("MultiplicateMatrix",  new MultiplicateMatrixAlgorithm());
        }
    }
}