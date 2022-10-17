using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class positive
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("number is positive");
            }
            else

                Console.WriteLine("number is negative");
            Console.ReadLine();
        }
    }
}
