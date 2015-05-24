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
            int number = 0;

            for (int i = 0; i < count; i++)
            {
                number = start + i;

                if (number % 2 != 0)
                {
                    Console.Write("{0}, ", -number);
                }
                else 
                {
                    Console.Write("{0}, ", number);
                }
            }
            Console.WriteLine();
        }
    }
}
