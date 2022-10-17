using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class _10sum
    {
        static void Main(string[] args)
        {
            int count, sum = 0;
        Console.WriteLine("\n");
            Console.WriteLine("the sum of first 10 natural numbers");
            Console.WriteLine("\n");
            Console.WriteLine("the 10 natural number are : \n");
            for(count=1;count<=10;count++)
            {
                sum = sum + count;
                Console.WriteLine("{0}", count);
            }
    Console.WriteLine("the sum is : {0}\n", sum);
            Console.ReadLine();
        }
    }
}
