using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercises_1
{
    internal class session04_03
    {
        private static void Main()
        {
        //Question01();
        Question02();
        //Question03();
        //Question04();
        //Question05();
        //Question06();

        Console.WriteLine(" \nPress any key to stop");
        Console.ReadKey();
        }
        /// <summary>
        /// 1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        /// </summary>
        public static void Question01()
        {
            Console.WriteLine("Nhap do dai 3 canh cua tam giac");
            Console.Write(" a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write(" b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write(" c = ");
            double c = double.Parse(Console.ReadLine());
            if (a==b && b==c)
            {
                Console.WriteLine("Tam giac la tam giac deu");
            }    
            else if (a==b || b==c || a==c)
            {
                Console.WriteLine("Tam giac la tam giac can");
            }  
            else
            {
                Console.WriteLine("Tam gia la tam giac khong can");
            }    
        }
        /// <summary>
        /// 2. Write a program to read 10 numbers and find their average and sum.
        /// </summary>
        public static void Question02()
        {
            int sum=0, avg;
            Console.WriteLine("Lay 10 so lien tiep");
            for (int i=1; i<10;i++)
            {
                Console.WriteLine($"{i}");
                 sum += i;
            }
            Console.WriteLine($"tong 10 so la {sum}");
            avg = sum / 10;
            Console.WriteLine($"trung binh 10 so la {avg}");
            
        }

    }
}
