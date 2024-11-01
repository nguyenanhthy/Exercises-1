using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Exercises_1
{
    internal class session05
    {
        private static void Main()
        {
            //Question01();
            //Question02();
           // Question03();
            Question04();
            //Question05();

            Console.ReadKey();

        }


  
        public static int Max(int a, int b, int c )
        {
            int max;
            if (a>b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c>max)
            {
                max = c;
            }
            Console.WriteLine($"max={max}");
            return max;

        }
            public static void Question01()
            {
            Console.Write("Nhap 3 so \na = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Max(a, b, c);
            }
        /// <summary>
        /// 2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument
        /// </summary>
        public static long Factorial(int a)
        {
            long fac = 1;
            for (int i = 1; i <= a; i++)
                fac *= i;
            Console.WriteLine($"giai thua bang {fac}");
            return fac;
        }
        public static void Question02()
        {
            Console.Write("Nhap so can tinh giai thua: ");
            int a = int.Parse(Console.ReadLine());
            Factorial(a);
        }
 //3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        public static bool primeornot(int a)
        {
            for (int i = 2; i <= a; i++)
                if (a % i == 0)
                {

                    Console.WriteLine("so vua nhap khong la so nguyen to");
                    return false;
                }
                else
                {
                    Console.WriteLine("so vua nhap la so nguyen to");
                    return true;
                }
            return primeornot(a);
        }
        public static void Question03()
        {
            Console.WriteLine("Nhap so ");
            int a= int.Parse(Console.ReadLine());
            primeornot(a);
        }
// 4. Write a C# function to print
// 1. all prime numbers that less than a number(enter prompt keyboard).
// 2. the first N prime numbers        public static bool prime(int a)
        {
            for (int i=2; i<=a; i++ )

            return prime();

        }
        public static void Question04()
        {
            Console.Write("Nhap so ");
            int a = int.Parse(Console.ReadKey());
        }

    }
}
