using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Exercises_1
{
    internal class session04
    {
        private static void Main()
        {
            //Question02();
            //Question03();
            Question05();
        }
        public static void Question02()
        {

            int y;
            for (y = -5; y <= 5; y++)
            {
                double x = Math.Pow(y, 2) - 2 * y + 1;
                Console.WriteLine($" y={y}; x = ({y})^2 - 2 * {y} + 1 = {x} ");
            }
        }
        public static void Question03()
        {
            // Tính thời gian
            Console.WriteLine("Nhap thoi gian di duoc tinh theo gio, phut, giay");
            Console.Write("Nhap so gio h = ");
            double hours = double.Parse(Console.ReadLine());
            Console.Write("Nhap so phut m = ");
            double minutes = double.Parse(Console.ReadLine());
            Console.Write("Nhap so giay s = ");
            double seconds = double.Parse(Console.ReadLine());
            double t = hours * 3600 + minutes * 60 + seconds;
            Console.WriteLine($"Tong so thoi gian di duoc tinh theo giay la: {t} ");

            // Đoạn đường
            Console.Write("doan duong di duoc tinh bang km hay m? Tra loi: ");
            string khoangcach = Console.ReadLine();
            if (khoangcach == "m")
            {
                Console.Write("Nhap doan duong di duoc s = ");
                double s = double.Parse(Console.ReadLine());
                double v1 = s / t;
                double v2 = (s / t) * 1000;
                Console.WriteLine($"Van toc di duoc \n Tinh m/s la v = {v1} \n Tinh theo km/s la v = {v2} ");
            }
            else
            {
                Console.Write("Nhap doan duong di duoc s = ");
                double s = double.Parse(Console.ReadLine());
                double v1 = s / t;
                double v2 = (s / t) / 1000;
                Console.WriteLine($"Van toc di duoc \nTinh km/s la v = {v1} \nTinh theo m/s la v = {v2} ");
            }
        }
        public static void Question05()
        {
            char c = char.Parse(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine(" ky tu duoc nhap vao la nguyen am");
            }
            else if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
            {
                Console.WriteLine("ky tu vua nhap la so");
            }
            else
            {
                Console.WriteLine("ky tu khac");
            }
                
        }
    }
}
