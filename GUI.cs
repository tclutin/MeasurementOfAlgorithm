using Lab1_algorithm.Algorithms.Sort;
using Lab1_algorithm.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Lab1_algorithm.Algorithms.Arithmetic;
using Lab1_algorithm.Algorithms.Others;
using System.Reflection.Metadata;

namespace Lab1_algorithm
{
    public class GUI
    {
        public static int selectedOption = 0;
        public static string[] options =
            { "TimSort", "MergedSort", "BubbleSort", "QuickSort", "ShellSort",
            
            "Multiple", "Sum", "MultiplicateMatrix",

            "ClassicQuickPow", "SimplePow", "RecursivePow", "QuickPow",

            "ConstantFunc", "Gorner", "NativeMethod",

            "Выход" };

        public AlgorithmProfiler profiler = new AlgorithmProfiler(0, 2000);


        public void Start()
        {
            while (true)
            {

                Console.Clear();
                DrawMenu();

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    selectedOption = (selectedOption - 1 + options.Length) % options.Length;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    selectedOption = (selectedOption + 1) % options.Length;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (selectedOption == options.Length - 1)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        RunSelectedAlgorithm(selectedOption);
                        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                        Console.ReadKey();
                    }
                }
            }
        }

        public void DrawMenu()
        {
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedOption)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine(options[i]);
                Console.ResetColor();
            }
        }
        public void SetCounters()
        {
            Console.Write("Введите значение для _externalCounter: ");
            if (int.TryParse(Console.ReadLine(), out int externalCounter))
            {
                profiler._externalCounter = externalCounter;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. _externalCounter не изменен.");
            }

            Console.Write("Введите значение для _internalCounter: ");
            if (int.TryParse(Console.ReadLine(), out int internalCounter))
            {
                profiler._internalCounter = internalCounter;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. _internalCounter не изменен.");
            }
        }
        public void RunSelectedAlgorithm(int optionIndex)
        {
            SetCounters();
            switch (optionIndex)
            {
                //sorts
                case 0:
                    RunAlgorithm(new TimSortAlgorithm());
                    break;
                case 1:
                    RunAlgorithm(new MergedSortAlgorithm());
                    break;
                case 2:
                    RunAlgorithm(new BubbleSortAlgorithm());
                    break;
                case 3:
                    RunAlgorithm(new QuickSortAlgorithm());
                    break;
                case 4:
                    RunAlgorithm(new ShellSortAlgorithm());
                    break;

                //arithmetic
                case 5:
                    RunAlgorithm(new MultipleAlgorithm());
                    break;
                case 6:
                    RunAlgorithm(new SumAlgorithm());
                    break;
                case 7:
                    RunAlgorithm(new MultiplicateMatrixAlgorithm());
                    break;

                //pow
                case 8:
                    RunAlgorithm(new ClassicQuickPowAlgorithm());
                    break;
                case 9:
                    RunAlgorithm(new SimplePowAlgorithm());
                    break;
                case 10:
                    RunAlgorithm(new RecursivePowAlgorithm());
                    break;
                case 11:
                    RunAlgorithm(new QuickPowAlgorithm());
                    break;

                //others
                case 12:
                    RunAlgorithm(new ConstantFuncAlgorithm());
                    break;
                case 13:
                    RunAlgorithm(new GornerAlgorithm());
                    break;
                case 14:
                    RunAlgorithm(new NativeMethodAlgorithm());
                    break;
            }
        }

        public void RunAlgorithm(IAlgorithm<int[]> algorithm)
        {

            Console.Clear();
            profiler.ReloadFiles();
            Console.WriteLine($"Выполняется {algorithm.GetType().Name}...");
            profiler.Run(algorithm.GetType().Name, algorithm);
            Console.WriteLine($"{algorithm.GetType().Name} выполнен.");
        }

        public void RunAlgorithm(IAlgorithmInt<int> algorithm)
        {

            Console.Clear();
            profiler.ReloadFiles();
            Console.WriteLine($"Выполняется {algorithm.GetType().Name}...");
            profiler.Run(algorithm.GetType().Name, algorithm);
            Console.WriteLine($"{algorithm.GetType().Name} выполнен.");
        }

        public void RunAlgorithm(IAlgorithm<Tuple<Matrix, Matrix, int>> algorithm)
        {

            Console.Clear();
            profiler.ReloadFiles();
            Console.WriteLine($"Выполняется {algorithm.GetType().Name}...");
            profiler.Run(algorithm.GetType().Name, algorithm);
            Console.WriteLine($"{algorithm.GetType().Name} выполнен.");
        }


    }
}
