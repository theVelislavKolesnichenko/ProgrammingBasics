﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_After_10_Years
{
    class PrintMyAge
    {
        static void Main(string[] args)
        {
            bool successful = false;
            DateTime birthday;

            do{
                Console.Clear();
                Console.Write("Enter your birthday: ");
                successful = DateTime.TryParse(Console.ReadLine(), out birthday);
            }
            while (!successful);

            DateTime currentDate = DateTime.Now;
            int nowAge = currentDate.Year - birthday.Year;
            int after10Years = nowAge + 10;

            Console.WriteLine("Your age now is  {0}", nowAge);
            Console.WriteLine("Your age after 10 years will be {0}", after10Years);

        }
    }
}
