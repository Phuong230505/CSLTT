using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EXECRISE
{
    internal class CONTROL_FLOW

    {
        static void Main(string[] args)
        {
            ex01();
            ex02();
            ex03();
            ex04();
            ex05();
            ex06();

            Console.WriteLine("Execrise 07");
            Console.Write("Enter the height of the triangle: ");
            int height = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                ex07( height - i, i+1);
            }
            Console.WriteLine();
            Console.WriteLine("Execrise 08");
            for(int k = 0; k < 4; k++)
            {
                ex08(k + 1);
            }
            ex81();
            ex82();
            ex9();
            ex10();

            Console.WriteLine("Execrise 11");
            int nu;
            do
            {
                Console.Write("Enter a positive number that is higher than 1:  ");
                nu = Convert.ToInt16(Console.ReadLine());
            } while (nu <= 1);
            if (ex11(nu))
            {
                Console.WriteLine("This is a prime number");
            }
            else
                Console.WriteLine("This is not a prime number");




            Console.ReadKey();
        }

        static void ex01()
        {
            // get input from the user
            Console.WriteLine("Execrise 01");

            Console.Write("Enter a number ");
            int num = Convert.ToInt16(Console.ReadLine());

            // checking whether it is odd or even
            if (num % 2 == 0)
            {
                Console.WriteLine("This is a even number ");
            }
            else
            {
                Console.WriteLine("This is an odd number ");
            }
        }
        static void ex02()
        {
            Console.WriteLine("Execrise 02");
            // get 3 inputs from the user


            Console.Write($"Enter  number: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write($"Enter  number: ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.Write($"Enter  number: ");
            int num3 = Convert.ToInt16(Console.ReadLine());
            // find the largest number
            int max = (num1 > num2) ? num1 : num2;
            max = (max > num3) ? max : num3;
            Console.WriteLine($"The largest number is {max}");

        }

        static void ex03()
        {
            Console.WriteLine("Execrise 03");
            // get inputs from the user
            Console.Write("Input the value for X coordinate : ");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Input the value for Y coordinate : ");
            int y = Convert.ToInt16(Console.ReadLine());

            // Do the math process
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }
            else if ((y < 0) && (x > 0))
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin");
            }


        }
        static void ex04()
        {
            Console.WriteLine("Execrise 04");
            int total = 0;
            int angleA, angleB, angleC;

            // enter the input and check whether it is a triangle or not.
            do
            {
                Console.Write("Enter the angle A = ");
                 angleA = Convert.ToInt16(Console.ReadLine());

                Console.Write("Enter the angle B = ");
                 angleB = Convert.ToInt16(Console.ReadLine());

                Console.Write("Enter the angle C = ");
                 angleC = Convert.ToInt16(Console.ReadLine());

                 total = angleA + angleB + angleC;
                if(total == 180)
                {
                   
                    break;
                }
                else
                {
                    Console.WriteLine("This is not a triangle, and total angle of the triangle must be equal to 180 ");
                }
            } while (true); 

            // check the type of triangle
            if((angleA == angleB) && (angleA == angleB) && (angleB == angleC))
            {
                Console.WriteLine("This is an Equilateral Triangle");
            }
            else if(angleC == angleB)
            {
                Console.WriteLine("This is an Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("This is a Scalene Triangle");
            }

        }
        static void ex05()
        {
            int sum = 0;
            float average = 0;
            Console.WriteLine("Execrise 05");
            List<int> number = new List<int>();
            for (int i = 0; i <= 9; i++)
            {
                Console.Write($"Enter number {1 + i} = ");
                number.Add(i);
                number[i] = Convert.ToInt16(Console.ReadLine()) ;
                
                sum += number[i];
                average = (float) ((sum*1.0 / 10)*1.0);
           
            }
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {average}");
        }
        static void ex06()
        {
            int mutiply; 
            Console.WriteLine("Execrise 06");
            Console.Write("Enter a number to display the multiplication table: ");
            int given = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"This is the multiplication table of {given}");


            for (int i = 1; i <= 10; i++)
            {
                mutiply = given * (i);
                Console.WriteLine($"{given} x {i} = {mutiply}");
            }
        }
        static void ex07(int space, int height)


        {
            for (int j = 0; j < space; j++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < height; i++)
            {
                
                    Console.Write("1");

                
            }
            Console.WriteLine();
            
        }
        static void ex08(int n)
        {
            
            for(int j = 0; j < n; j++)
            {
               
                Console.Write($"{j + 1}");
            }
            Console.WriteLine();
        }
        static void ex81()
        {
            int num = 1;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write($"{num} ");
                    num++;
                }
                Console.WriteLine();

            }

        }
        static void ex82()
        {
            Console.WriteLine("Execrise 82");
            int number = 1;
            for (int j = 0; j < 4; j++)
            {
                for (int m = 0; m < (4 - j); m++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <= j; i++)
                {
                    Console.Write($"{number}");
                    number++;
                }
                Console.WriteLine();
            }
        }

        static void ex9()
        {
            Console.WriteLine("Execrise 9");
            Console.Write("Enter n ");
            double n = Convert.ToDouble(Console.ReadLine());


            double total = 0.0d;
            for(int i = 1; i <= n; i++)
            {
                total += (1 /(double) i);
                Console.Write($"1/{i} +");
            }

            Console.Write($" = {total}");
            Console.WriteLine() ;
        }

        static bool ex11(int value)
        {
           

            for(int i = 2; i < value; i++)
            {
                if(value % i == 0)
                {
                    return false; 
                    
                }

            }
            return true;
        }
        static void ex10()
        {
            Console.WriteLine("Execrise 10");
            int num10;
            do
            {
                Console.Write("Enter a positive number ");
                num10 = Convert.ToInt16(Console.ReadLine());
            } while (num10 < 0);

            int sum = 0;
            for (int i = 1; i < num10; i++)
            {
                if (num10 % i == 0)
                {
                   sum = sum + i;
                }
            }
            if (sum == num10)
            {
                Console.WriteLine("This is a perfect number ");
            }
            else
            {
                Console.WriteLine("This is not a perfect number ");
            }
        }
        
    }
}

