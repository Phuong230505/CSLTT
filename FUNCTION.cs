using System;
using System.Text;

namespace EXECRISE
{
    internal class FUNCTION
    {
        static void Main(string[] args)
        {
            Console.Write("Exercise 01");
            Console.WriteLine("Three numbers are 3, 10, 11");
            Console.Write($"The max number is {max(3, 10, 11)}");

            Console.WriteLine();
            Console.WriteLine("Exercise 02");
            Console.Write("Enter the numbers of sum: ");
            int num = Convert.ToInt16(Console.ReadLine());
            sum(num);
            Console.WriteLine();


            Console.WriteLine("Exercise 03");
            Console.Write("Enter a string to reverse: ");
            string str = Console.ReadLine();
            Console.WriteLine(Reverse(str));


            Console.WriteLine("Execrise 04");
            int n = 0;
            do
            {
                Console.Write("Enter a number that must be higher than 0: ");
                n = Convert.ToInt16(Console.ReadLine());
            }
            while (n < 0);
            int result = factorial(n);
            Console.WriteLine($"The factorial number is {result}");


            Console.WriteLine("Exercise 05");
            int val = 0;
            do
            {
                Console.Write("Enter a number that must be higher than 1: ");
                val = Convert.ToInt16(Console.ReadLine());

            } while (val <= 1);
            if (isPrime(val))
            {
                Console.WriteLine($"{val}  is a prime number");
            }
            else
            {
                Console.WriteLine($"{val} is not a prime number");
            }

            Console.WriteLine("Exercise 6.1");
            int a = 0;
            do
            {
                Console.Write("Enter a number to print all prime number: ");
                a = Convert.ToInt16(Console.ReadLine());
            } while (a <= 1);
            for (int i = 2; i < a; i++)
            {
                if (isPrime(i))
                {
                    Console.Write($" {i} ");
                }

            }

            Console.WriteLine("Exercise 6.2");
            PrintPrimeNumber();

            Console.WriteLine("Exercise 7");
            int c = 0;
            do
            {
                Console.Write("Enter a number to check whether a perfect or not: ");
                c = Convert.ToInt16(Console.ReadLine());
            } while (c < 1);
            if (isPerfect(c))
            {
                Console.WriteLine("This is a perfect number ");
            }
            else
            {
                Console.WriteLine("This is not a perfect number ");
            }

            Console.WriteLine("Exercise 7.1");
            PrintPerfect();

            isPan();


            Console.ReadKey();

        }
        static int max(int a, params int[] pars)
        {
            int c = 0;
            foreach (int i in pars)
            {
                if (c < i)
                {
                    c = i;
                }
            }
            return Math.Max(a, c);

        }
        static void sum(int num)
        {
            int result = 0;
            List<int> value = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter value {i + 1} =  ");
                value.Add(i);
                value[i] = Convert.ToInt16(Console.ReadLine());

                result += value[i];

            }
            Console.Write($"The sum is {result}");
        }

        static string Reverse(string input)
        {
            int len = input.Length - 1;
            char[] stringArray = input.ToCharArray();

            string reverse = String.Empty;

            for (int i = 0; i <= len; i++)
            {
                reverse = reverse + stringArray[len - i];
            }
            return reverse;

        }
        static int factorial(int n)
        {
            int fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
            return fac;
        }

        static bool isPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void PrintPrimeNumber()
        {
            Console.Write("Enter a number to print ");
            int n = Convert.ToInt16(Console.ReadLine());
            int count = 1;
            int number = 2;
            while (count <= n)
            {
                if (isPrime(number))
                {
                    Console.Write($"{number} ");
                    count++;
                }
                number++;
            }
        }

        static bool isPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void PrintPerfect()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (isPerfect(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static  void isPan()
        {
            Console.WriteLine("Enter a string  ");
            string s = Convert.ToString(Console.ReadLine());

            s = s.ToLower();
            char[] chars = s.ToCharArray();
            int len = s.Length - 1;
            int i, total = 0;

            int[] used = new int[26];
            used[26] = (0);

            
          

            for (i = 0; i < len; i++)
            {
                if ('a' <= s[i] && s[i] <= 'z')
                {
                    if(used[s[i] - 'a'] == 0)
                    {
                        total += 1;
                    }
                    else
                    {
                        total += used[s[i] - 'a'];
                    }
                    used[s[i] - 'a'] = 1;
                }

            }
            if (total == 26)
            {
                Console.WriteLine("\n The Entered String is a Pangram String.");
            }
            else
            {
                Console.WriteLine("\n The Entered String is not a Pangram String.");
            }

        }
    }
 }



