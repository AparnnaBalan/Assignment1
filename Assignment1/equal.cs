using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class equal
    { 
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("number are equal", num1, num2);
            else
                Console.WriteLine("number are not  equal", num1, num2);
            Console.ReadLine();
        }
    
      
    }
}
