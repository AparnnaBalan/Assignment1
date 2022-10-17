using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class mark
    {
        static void Main(string[] args)
        {


            int rollnumber, mark1, mark2, mark3, total;
            string name;
            float percentage;

            Console.WriteLine("enter the roll number");
            rollnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the name");
            name = Console.ReadLine();

            Console.WriteLine("enter the mark1");
            mark1 = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("enter the mark2");
            mark2 = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("enter the mark3");
            mark3 = Convert.ToInt32(Console.ReadLine());

            total = mark1 + mark2 + mark3;

            percentage = total / 3.0f;

            Console.WriteLine("total mark : " + total);
            Console.WriteLine("percentage : " + percentage);
            Console.ReadLine();
       
}


    }
}
