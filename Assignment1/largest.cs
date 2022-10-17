using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class largest
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("enter number 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 3");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
                Console.WriteLine("largest number is " + n1);
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine("largest number is " + n2);
            else
                Console.WriteLine("largest number is " + n3);


            Console.ReadLine();
        }
  

    }
}
