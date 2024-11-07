using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercises_1
{
    internal class session05
    {
        private static void Main()
        {
            //Question01();
            //Question02();
            //Question03();
            //Question04_c1();
            //Question04_c2();
            Question05();
            //Question06();

            Console.ReadKey();

        }
        /// <summary>
        /// 1. Write a C# function to find the maximum of three numbers. Improve the next version that accept at least 1 parameter.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        ///           Console.WriteLine($"max={max}");
        public static int Max(int a, int b, int c)
        {
            int max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

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
            int maxnumber = Max(a, b, c);
            Console.WriteLine($"So lon nhat la {maxnumber}");
        }


        /// <summary>
        /// 2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>        
        public static long factorial(int a)
        {
            int fac = 1;
            for (int i = 1; i <= a; i++)
                fac *= i;
            return fac;
        }
        public static void Question02()
        {
            Console.Write("Nhap so can tinh giai thua: ");
            int a = int.Parse(Console.ReadLine());
            long giaithua = factorial(a);
            Console.WriteLine($"Giai thua cua {a} bang {giaithua}");
        }

        /// <summary>
        /// 3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool primeornot(int a)
        {
            if (a<=1) return false;
            int uoc = 0;
            for (int i = 2; i <= a; i++)
            {

                if (a % i == 0)
                {
                    uoc++;
                }
            }
            if (uoc == 2)
            {
                return true;
            }
            else return false;
          
        }

        public static void Question03()
        {
            Console.Write("Nhap so ");
            int a = int.Parse(Console.ReadLine());
            if (primeornot(a) == true)
            {
                Console.WriteLine("So vua nhap la so nguyen to");
            }
            else
            {
                Console.WriteLine("So vua nhap khong la so nguyen to");
            }
        }

        /// <summary>
        /// 4. Write a C# function to print
        ///   1. all prime numbers that less than a number(enter prompt keyboard)
        ///   2. the first N prime numbers
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>

        ///1. all prime numbers that less than a number (enter prompt keyboard)
        public static bool xacdinhsont(int a)
        {
            int uoc = 0;
            if (a <= 1) return false;
            for (int i = 1; i <= a; i++)
            {

                if (a % i == 0)
                {
                    uoc++;
                }
            }
            if ( uoc == 2)
            {
                return true;
            }
            else return false;
        }
        public static int inso(int a)
        {
            for( int i=2; i<=a; i++)
            if (xacdinhsont(i)==true)
                Console.WriteLine(i);
            return a;
        }
        public static void Question04_c1()
        {
            Console.Write("Nhap so ");
            int a = int.Parse(Console.ReadLine()) ;
            if (a == 2) 
            {
                Console.WriteLine(a);
            }
            
            else
            {
            inso(a);
            }
        }

        /// 2. tong N so nguyen to da in  <summary>
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Nsongtodau(int a)
        {
            do
            {
                int count = 0;
                for (int j = 1; j >= 1; j++)
                {
                    if (xacdinhsont(j) == true)
                    {
                        Console.WriteLine(j);
                        count++;
                    }
                    if (count == a)
                        break;
                }
                break;
            }
            while (true);
            return a;
        }
        public static void Question04_c2()
        {
            Console.Write("Nhap so ");
            int a = int.Parse(Console.ReadLine()) ;
            Nsongtodau(a);
        }
        /// <summary>
        /// 5. Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        /// </summary>
        public static bool perfectornot(int a)
        {
            if (a == 0) return false;
            int sum = 0; 
            for (int j =1; j < a; j++)
            {
                if (a % j == 0)
                {
                    sum += j;
                }
            }    
            if (sum == a)
            {
                return true;
            }
            return false;
        }
        public static int insoperfect(int i)
        {

            for ( i= 0; i<1000; i++)
            {
                if (perfectornot(i) == true)
                {
                    
                    Console.WriteLine(i);
                }    
            }
            return i;
        }

        public static void Question05()
        {
            Console.WriteLine("So nhap co phai la so chinh phuong khong?");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Nhap so ");
            int a = int.Parse(Console.ReadLine());
            if (perfectornot(a) == true)
            {
                Console.WriteLine($"{a} la so hoan hao");
            }
            else return;
            Console.WriteLine("In ra tat ca cac so hoan hao nho hon 1000");
            Console.WriteLine("-----------------------------------------");
            int i = 0;
            insoperfect(i);
        }
        /// <summary>
        /// 6. Write a C# function to check whether a string is a pangram or not.
        /// </summary>
        public static void Question06()
        {
            Console.Write("Nhap vao mot cau ");
            string a = Console.ReadLine();

        }
        public static bool pangramornot(string a)
        {
            
            foreach (int j in a)
            {
                if (j == a && j==b
            }    
        }
    }
     

}
