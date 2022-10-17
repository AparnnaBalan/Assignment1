using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class pyramid2
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i, j, k = 0;
            for (i = n; i >= 1; i--)
            {
                for (j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}



