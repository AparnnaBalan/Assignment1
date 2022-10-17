using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, count = 0, n2 = 0;
            Console.WriteLine(" enter the number of odd number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + "odd numbers");
            for (int i = 1; i < 100; i++)
            {
                if (count < n1)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                        n2 = n2 + i;
                        count++;

                    }


                }
                else
                {
                    break;


                }
            }
            Console.WriteLine("sum of first " + n1 + " of odd numbers:" + n2);
            Console.ReadLine();


        }
    }
}

