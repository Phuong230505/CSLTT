using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXECRISE
{
    internal class BT06den10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai tap o6");
            Console.Write("Enter a string ");
            string value = Convert.ToString(Console.ReadLine());

            
            Console.WriteLine("The lenngth of a data is {0} ", value.Length);
            Console.WriteLine();

            //Bai tap 07
            Console.WriteLine("Bai tap 07");
            const float pi = 3.14f;

            Console.Write("Enter r ");
            float r = Convert.ToSingle(Console.ReadLine());

            double rsqrt = (double)Math.Pow(r, 2);
            float result = (float)(pi * rsqrt);
            Console.WriteLine("The area of the cricle is {0}", result);

            // Baitap08
            Console.WriteLine("Bai tap 08");
            Console.Write("Enter a side ");
            int side = Convert.ToInt32(Console.ReadLine());

            double areaofsquare = (double)(side * side);
            Console.WriteLine("The area of square {0}", areaofsquare);
            Console.WriteLine();

            // Baitap09
            Console.WriteLine("Bai tap 09");
            // Get day(s) input from the user
            Console.Write("Enter day(s) ");
          int  days = Convert.ToInt32(Console.ReadLine());


            // process of convert
            // ing days to years
            int year = days / 365;
            int leftover0 = days % 365;

            // process of converting days to weeks and weeks
            int week = leftover0 / 7;
            int day = week % 7;

            Console.WriteLine($"{days} is equal to {year} year (s), {week} week(s) and {day} day(s)");
            Console.ReadKey();
        }
    }
}
