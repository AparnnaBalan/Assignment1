using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class pyramid3
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");


                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}