using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial solveFactorial = new Factorial();

            Console.WriteLine("Solve 5!: " + solveFactorial.RecursiveFactorial(5));
        }
    }
}
