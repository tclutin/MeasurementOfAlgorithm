using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_algorithm.Algorithms
{
    public interface IAlgorithm<T>
    {
        public void Execute(T input);
    }

    public interface IAlgorithmInt<T>
    {
        public int Execute(T input);
    }
}
