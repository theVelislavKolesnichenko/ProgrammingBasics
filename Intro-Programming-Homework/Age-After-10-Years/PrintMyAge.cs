using System;
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
            DateTime currentDate = DateTime.Now;
            Console.Write("Enter your birthday: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            
            int nowAge = currentDate.Year - birthday.Year;
            int after10Years = nowAge + 10;

            Console.WriteLine("Your age now is  {0}", nowAge);
            Console.WriteLine("Your age after 10 years will be {0}", after10Years);

        }
    }
}
