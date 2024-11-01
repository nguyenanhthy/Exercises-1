using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Exercises_1
{
    internal class session04_02
    {
        private static void Main1()
        {
            //Question01();
            //Question02();
            //Question03();

            Console.WriteLine("\nPress any key to stop");
            Console.ReadKey();
        }
 
        /// <summary>
        /// 6. Write a C# Sharp program to check whether a given number is even or odd.
        /// </summary>
        public static void Question01()
        {
            Console.Write("Nhap gia tri x = ");
            int x = int.Parse(Console.ReadLine());
            if ( x%2==1)
            {
                Console.WriteLine("x la so le");
            }    
            else 
            {
                Console.WriteLine("x la so chan");
            }
        }
        /// <summary>
        /// 7. Write a C# Sharp program to find the largest of three numbers.
        /// </summary>
        public static void Question02()
        {
            Console.Write("Nhap 3 so \nx = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());
            if (x>y)
            {
                if (x>z)
                {
                    Console.WriteLine($"{x} la so lon nhat");
                }   
                else
                {
                    Console.WriteLine($"{z} la so lon nhat");
                }    
            }
            else if (y>z)
            {
                Console.WriteLine($"{y} la so lon nhat");
            }
            else 
            { 
                Console.WriteLine($"{z} la so lon nhat"); 
            }  
        }
        /// <summary>
        /// 8. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine 
        /// in which quadrant the coordinate point lies.
        /// </summary>
        public static void Question03()
        {
            Console.Write("Nhap hoanh do x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap tung do y = ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nToa do diem vua nhap A({x},{y})\n");
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Diem A la goc toa do O");
            }
            else if (x == 0)
            {
                Console.WriteLine("Diem A thuoc truc Oy");
            }
            else if (x > 0)
            {
                if (y == 0)
                {
                    Console.WriteLine("Diem A thuoc truc Ox");
                }
                else if (y > 0)
                {
                    Console.WriteLine("Diem A thuoc goc phan tu thu I");

                }
                else
                {
                    Console.WriteLine("Diem A thuoc goc phan tu thu IV");
                }

            }
            else
            {
                if (y == 0)
                {
                    Console.WriteLine("Diem A thuoc truc Ox");
                }
                else if (y > 0)
                {
                    Console.WriteLine("Diem A thuoc goc phan tu thu II");
                }
                else
                {
                    Console.WriteLine("Diem A thuoc goc phan tu thu III");
                }
            }

        }
    }
}
