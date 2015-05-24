using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            double number = 12345;
            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("Square root of {0} is {1}", number, squareRoot);
        }
    }
}
