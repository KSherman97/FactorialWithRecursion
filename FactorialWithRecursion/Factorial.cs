using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialWithRecursion
{
    class Factorial
    {
        public int RecursiveFactorial(int number)
        {
            // this is the base case
            // if the value for number is 1 then return 1
            if (number == 1)
                return 1;

            // not the base case, so make the recursive call
            return (number * RecursiveFactorial(number - 1));

        }
    }
}
