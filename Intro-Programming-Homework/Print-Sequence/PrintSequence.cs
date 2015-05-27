using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Sequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int count = 10;
            int start = 2;

            for (int i = start; i <= count; i = i + 2)
            {
                Console.Write("{0}, {1}, ", i, (i + 1) * (-1));
            }
            Console.WriteLine();
        }
    }
}
