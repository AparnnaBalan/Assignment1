using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class sum_10
    {
        static void Main(string[] args)
        {
            int number = 123, sum = 0, reminder;

            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }
            Console.WriteLine("sum of digit is {0}", sum);
            Console.ReadLine();
        }
    
    }
}
