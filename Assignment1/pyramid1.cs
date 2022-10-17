using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class pyramid1
    {
        static void Main(string[] args)
        {
            {
                int x = 5;
                for (int i = 1; i <= x; i++)
                {
                    for (int j = 1; j <= (x - i); j++)
                        Console.Write(" ");

                    for (int t = 1; t < i * 2; t++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                Console.ReadLine();


            }
        }
    }
}

