using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1
{
    internal class session06_02
    {
       
        /// <summary>
        /// create a random integer values array, then create functions that:
        /// 1. to calculate the average value of array elements.
        /// 2. to test if an array contains specific value.
        /// 3. to find the index of an array element.
        /// 4. to remove a specific element from an array.
        /// 5. to find the maximum and minimum value of an array.
        /// 6. to reverse an array of integer values.
        /// 7. to find duplicate elements from an array.
        /// </summary>
        public static void Main()
        {
            Console.Write("Nhap so phan tu de tao mang tu nhien: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(1, 100);

            }
            Console.WriteLine("-------------------------");
            Console.Write("Mang duoc tao tu nhien la ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n-------------------------");

            tinhtrungbinh(a);
            double avg = tinhtrungbinh(a);
            Console.Write($"Trung binh mang la {avg}");

            Console.WriteLine("\nMang co bao gom gia tri cu the hay khong?");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Nhap gia tri can kiem tra ");
            int x = int.Parse(Console.ReadLine());
            if (kiemtra(a, x) == true)
            {
                Console.WriteLine("Co gia tri");
            }
            else
            {
                Console.WriteLine("Khong co gia tri");
            }
            Console.WriteLine("-----------------------------------------");

            Console.Write("Nhap so can tim vi tri: ");
            int so = int.Parse(Console.ReadLine());
            if (timvitri(a, so) == -1)
            {
                Console.WriteLine("Khong tim duoc so can tim");
            }
            else
            {
                int index = timvitri(a, so);
                Console.WriteLine($"So tim duoc o vi tri thu {index + 1}");
            }
            Console.WriteLine("-----------------------------------------");


            Console.Write("Nhap gia tri can xoa ");
            int socanxoa = int.Parse(Console.ReadLine());
            xoa(a, socanxoa);


            nhonhat(a);
            int min = nhonhat(a);
            Console.Write($"So nho nhat trong mang la {min}\n");


        }
        static int nhonhat(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }


        /// <summary>
        /// 4. to remove a specific element from an array.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="socanxoa"></param>
        static int xoa(int[] a, int socanxoa)
        {
            if (timvitri(a, socanxoa) == -1)
            {
                Console.WriteLine("Khong tim thay so can xoa trong mang");
            }
            int i = timvitri(a, socanxoa);
            for (int j = 0; j < a.Length; j++) //sử dụng thuật toán sắp xếp đưa phần tử cần xóa sang vị trí 0 để xuất mảng bắt đầu từ vị trí 1
            {
                if (i == 0)
                {
                    break;
                }
                else if (j < i)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            int items = 0;
            int[] array2 = new int[a.Length - 1];
            for (int j = 1; j < a.Length; j++)
            {
                array2[items] = a[j];

            }
            foreach (int j in array2)
            {
                Console.Write(j + " ");
            }
            return array2[items];





        }
        /// <summary>
        ///3. to find the index of an array element.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="so"> so can tim vi tri </param>
        /// <returns> vi tri, hoac -1 </returns>
        static int timvitri(int[] a, int so)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == so)
                    return i;
            }
            return -1;
        }
        /// <summary>
        /// 2. to test if an array contains specific value. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static bool kiemtra(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 1. to calculate the average value of array elements.
        /// </summary>
        /// <param name="a"> mang </param>
        /// <returns> gia tri trung binh cua mang a</returns>
        static double tinhtrungbinh(int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            double avg = 0;
            avg = sum / a.Length;
            return avg;
        }
    }
}
