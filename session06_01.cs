using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1
{
    internal class session06
    {
        private static void Main()
        {
            ex1();

            Console.ReadKey();
        }
        static void ex1()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            nhapmang(a);
            xuatmang(a);
            Console.WriteLine();
            tang2donvi(a);
            Console.WriteLine();
            tinhtongmang(a);
            int s = tinhtongmang(a);
        }
        static void nhapmang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            
        }
        static void xuatmang(int []a)
        {
            Console.Write("xuat mang: ");
            foreach ( int items in a )
            {
                Console.Write($"{items} ");
            }
       

        }
        static void tang2donvi(int[]a)
        {
            int somoi;
            Console.Write("xuat mang sau khi tang 2 don vi moi phan tu: ");
            for ( int i=0; i<a.Length; i++)
            {
                a[i] += 2;
                Console.Write(a[i] + " ");
            }
            
        }
        static void tinhtongmang(int[] a)
        {
            int sum = 0;
            Console.WriteLine("xuat tong mang sau khi tang: ");
            foreach ( int somoi in a )
            {
                sum += somoi;
            }
            Console.WriteLine(sum);
        }
        static void trungbinh(int[]a)
        {
            
            
        }
    
    }
}
